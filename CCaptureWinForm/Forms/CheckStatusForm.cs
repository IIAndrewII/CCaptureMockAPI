using CCaptureWinForm.Core.Interfaces;
using CCaptureWinForm.Presentation.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CCaptureWinForm
{
    public partial class CheckStatusForm : Form
    {
        private readonly IApiDatabaseService _apiDatabaseService;
        private readonly IDatabaseService _databaseService;
        private readonly IConfiguration _configuration;
        private readonly MainViewModel _viewModel;
        private readonly ErrorProvider _errorProvider;

        public CheckStatusForm(IApiDatabaseService apiDatabaseService, IDatabaseService databaseService, IConfiguration configuration, MainViewModel viewModel)
        {
            _apiDatabaseService = apiDatabaseService;
            _databaseService = databaseService;
            _configuration = configuration;
            _viewModel = viewModel;
            InitializeComponent();
            _errorProvider = new ErrorProvider(this) { BlinkStyle = ErrorBlinkStyle.NeverBlink };

            // Configure DataGridViewRequests
            ConfigureDataGridViewRequests();

            // Attach event handlers
            btnCheckStatus.Click += btnCheckStatus_Click;
            dataGridViewRequests.DataError += DataGridViewRequests_DataError;

            // Initialize login
            var appName = _configuration["AppName"];
            var appLogin = _configuration["AppLogin"];
            var appPassword = _configuration["AppPassword"];
            _ = loginAsync(appName, appLogin, appPassword);
        }

        private void ConfigureDataGridViewRequests()
        {
            dataGridViewRequests.Columns.Clear();
            dataGridViewRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Request Guid",
                Name = "RequestGuid",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewRequests.AllowUserToAddRows = true;
            dataGridViewRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async Task loginAsync(string appName, string appLogin, string appPassword)
        {
            try
            {
                _errorProvider.Clear();
                statusLabel3.Text = string.Empty;
                statusLabel3.ForeColor = SystemColors.ControlText;

                statusLabel3.Text = "Logging in...";
                statusLabel3.ForeColor = Color.Blue;

                if (string.IsNullOrEmpty(appName) || string.IsNullOrEmpty(appLogin) || string.IsNullOrEmpty(appPassword))
                {
                    statusLabel3.Text = "Configuration settings are missing.";
                    statusLabel3.ForeColor = Color.Red;
                    ShowLoginForm();
                    return;
                }

                var token = await _viewModel.GetAuthTokenAsync(appName, appLogin, appPassword);

                statusLabel3.Text = "You're logged in!";
                statusLabel3.ForeColor = Color.Green;
                checkStatusPanel.Visible = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("unauthorized") || ex.Message.Contains("401"))
                {
                    statusLabel3.Text = "Unauthorized configuration settings.";
                    statusLabel3.ForeColor = Color.Red;
                    ShowLoginForm();
                }
                else
                {
                    statusLabel3.Text = "Something went wrong. Please try again.";
                    statusLabel3.ForeColor = Color.Red;
                    ShowLoginForm();
                }
            }
        }

        private void ShowLoginForm()
        {
            checkStatusPanel.Visible = false;
            using (var loginForm = new LoginForm(_viewModel))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    statusLabel3.Text = "You're logged in!";
                    statusLabel3.ForeColor = Color.Green;
                    checkStatusPanel.Visible = true;
                }
                else
                {
                    statusLabel3.Text = "Login failed. Please try again.";
                    statusLabel3.ForeColor = Color.Red;
                    checkStatusPanel.Visible = false;
                }
            }
        }

        private async void btnCheckStatus_Click(object sender, EventArgs e)
        {
            try
            {
                _errorProvider.Clear();

                // Validate metadata inputs
                if (string.IsNullOrWhiteSpace(txtSourceSystem.Text))
                    _errorProvider.SetError(txtSourceSystem, "Please enter the source system.");
                if (string.IsNullOrWhiteSpace(txtChannel.Text))
                    _errorProvider.SetError(txtChannel, "Please enter the channel.");
                if (string.IsNullOrWhiteSpace(txtSessionID.Text))
                    _errorProvider.SetError(txtSessionID, "Please enter the session ID.");
                if (string.IsNullOrWhiteSpace(txtMessageID.Text))
                    _errorProvider.SetError(txtMessageID, "Please enter the message ID.");
                if (string.IsNullOrWhiteSpace(txtUserCode.Text))
                    _errorProvider.SetError(txtUserCode, "Please enter the user ID.");

                // Collect valid RequestGuids from DataGridView
                var requestGuids = dataGridViewRequests.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => !row.IsNewRow)
                    .Select(row => row.Cells["RequestGuid"].Value?.ToString())
                    .Where(guid => !string.IsNullOrWhiteSpace(guid) && Guid.TryParse(guid, out _))
                    .Distinct()
                    .ToList();

                if (!requestGuids.Any())
                    _errorProvider.SetError(dataGridViewRequests, "Please enter at least one valid Request Guid.");

                if (_errorProvider.GetError(txtSourceSystem) != "" ||
                    _errorProvider.GetError(txtChannel) != "" ||
                    _errorProvider.GetError(txtSessionID) != "" ||
                    _errorProvider.GetError(txtMessageID) != "" ||
                    _errorProvider.GetError(txtUserCode) != "" ||
                    _errorProvider.GetError(dataGridViewRequests) != "")
                {
                    statusLabel3.Text = "Please fill in all required fields and provide at least one valid Request Guid.";
                    statusLabel3.ForeColor = Color.Red;
                    return;
                }

                statusLabel3.Text = "Checking status...";
                statusLabel3.ForeColor = Color.Blue;
                toolStripProgressBar1.Visible = true;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Maximum = requestGuids.Count;

                VerificationStatusViewer.Text = string.Empty;

                foreach (var requestGuid in requestGuids)
                {
                    try
                    {
                        var status = await _viewModel.CheckVerificationStatusAsync(
                            requestGuid,
                            txtSourceSystem.Text,
                            txtChannel.Text,
                            txtSessionID.Text,
                            txtMessageID.Text,
                            txtUserCode.Text);
                        VerificationStatusViewer.AppendText($"Request Guid: {requestGuid}\n");
                        VerificationStatusViewer.AppendText($"Status: {status}\n");
                        VerificationStatusViewer.AppendText("------------------------\n");
                    }
                    catch (Exception ex)
                    {
                        VerificationStatusViewer.AppendText($"Request Guid: {requestGuid}\n");
                        VerificationStatusViewer.AppendText($"Error: {ex.Message}\n");
                        VerificationStatusViewer.AppendText("------------------------\n");
                    }
                    toolStripProgressBar1.Value++;
                }

                toolStripProgressBar1.Visible = false;
                statusLabel3.Text = "Status check completed.";
                statusLabel3.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                toolStripProgressBar1.Visible = false;
                statusLabel3.Text = "Something went wrong while checking status.";
                statusLabel3.ForeColor = Color.Red;
                if (ex.Message.ToLower().Contains("unauthorized") || ex.Message.Contains("401"))
                {
                    checkStatusPanel.Visible = false;
                    using (var loginForm = new LoginForm(_viewModel))
                    {
                        if (loginForm.ShowDialog() == DialogResult.OK)
                        {
                            btnCheckStatus_Click(sender, e);
                        }
                        else
                        {
                            statusLabel3.Text = "Login failed. Please try again.";
                            statusLabel3.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void DataGridViewRequests_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewRequests.Columns["RequestGuid"].Index)
            {
                dataGridViewRequests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                e.Cancel = true;
            }
        }
    }
}