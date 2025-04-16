using CCaptureWinForm.Core.Entities;
using CCaptureWinForm.Infrastructure.Services;
using CCaptureWinForm.Presentation;
using CCaptureWinForm.Presentation.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CCaptureWinForm
{
    public partial class MainForm : Form
    {
        private readonly MainViewModel _viewModel;
        private VerificationStatusViewer _statusViewer;
        private bool _viewerInitialized = false;
        private readonly ErrorProvider _errorProvider;
        private readonly IConfiguration _configuration;

        public MainForm()
        {
            InitializeComponent();
            _errorProvider = new ErrorProvider(this) { BlinkStyle = ErrorBlinkStyle.NeverBlink };

            // Load configuration from appsettings.json
            _configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var fileService = new FileService();
            var apiUrl = _configuration["ApiUrl"];
            if (string.IsNullOrEmpty(apiUrl))
            {
                throw new InvalidOperationException("ApiUrl is not configured in appsettings.json");
            }

            var apiService = new ApiService(apiUrl);
            _viewModel = new MainViewModel(apiService, fileService);

            // Attach event handlers
            btnBrowseFile.Click += btnBrowseFile_Click;
            btnRemoveFile.Click += btnRemoveFile_Click;
            btnSubmitDocument.Click += btnSubmitDocument_Click;
            btnCheckStatus.Click += btnCheckStatus_Click;
            btnClearResults.Click += btnClearResults_Click;
            submitDocumentToolStripMenuItem.Click += submitDocumentToolStripMenuItem_Click;
            checkStatusToolStripMenuItem.Click += checkStatusToolStripMenuItem_Click;
            Resize += MainForm_Resize;

            // Run loginAsync automatically
            var appName = _configuration["AppName"];
            var appLogin = _configuration["AppLogin"];
            var appPassword = _configuration["AppPassword"];
            _ = loginAsync(appName, appLogin, appPassword);
            submitDocumentToolStripMenuItem_Click(null, EventArgs.Empty);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void submitDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            submitPanel.Visible = true;
            checkStatusPanel.Visible = false;

            // Highlight Submit Document
            submitDocumentToolStripMenuItem.BackColor = Color.Gray; 
            submitDocumentToolStripMenuItem.ForeColor = Color.White;
            submitDocumentToolStripMenuItem.Font = new Font(submitDocumentToolStripMenuItem.Font, FontStyle.Bold);

            // Reset Check Status
            checkStatusToolStripMenuItem.BackColor = SystemColors.Control;
            checkStatusToolStripMenuItem.ForeColor = SystemColors.ControlText;
            checkStatusToolStripMenuItem.Font = new Font(checkStatusToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void checkStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            submitPanel.Visible = false;
            checkStatusPanel.Visible = true;

            // Highlight Check Status
            checkStatusToolStripMenuItem.BackColor = Color.Gray; 
            checkStatusToolStripMenuItem.ForeColor = Color.White;
            checkStatusToolStripMenuItem.Font = new Font(checkStatusToolStripMenuItem.Font, FontStyle.Bold);

            // Reset Submit Document
            submitDocumentToolStripMenuItem.BackColor = SystemColors.Control;
            submitDocumentToolStripMenuItem.ForeColor = SystemColors.ControlText;
            submitDocumentToolStripMenuItem.Font = new Font(submitDocumentToolStripMenuItem.Font, FontStyle.Regular);
        }


        private async Task loginAsync(string appName, string appLogin, string appPassword)
        {
            try
            {
                _errorProvider.Clear();
                statusLabel2.Text = string.Empty;
                statusLabel2.ForeColor = SystemColors.ControlText;
                statusLabel3.Text = string.Empty;
                statusLabel3.ForeColor = SystemColors.ControlText;

                statusLabel2.Text = "Logging in...";
                statusLabel2.ForeColor = Color.Blue;

                // Validate configuration
                if (string.IsNullOrEmpty(appName) || string.IsNullOrEmpty(appLogin) || string.IsNullOrEmpty(appPassword))
                {
                    statusLabel2.Text = "Configuration settings are missing.";
                    statusLabel2.ForeColor = Color.Red;
                    ShowLoginForm();
                    return;
                }

                var token = await _viewModel.GetAuthTokenAsync(appName, appLogin, appPassword);

                statusLabel2.Text = "You're logged in!";
                statusLabel2.ForeColor = Color.Green;
                submitPanel.Visible = true;
                checkStatusPanel.Visible = false;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("unauthorized") || ex.Message.Contains("401"))
                {
                    statusLabel2.Text = "Unauthorized configuration settings.";
                    statusLabel2.ForeColor = Color.Red;
                    ShowLoginForm();
                }
                else
                {
                    statusLabel2.Text = "Something went wrong. Please try again.";
                    statusLabel2.ForeColor = Color.Red;
                    ShowLoginForm();
                }
            }
        }

        private void ShowLoginForm()
        {
            submitPanel.Visible = false;
            checkStatusPanel.Visible = false;
            using (var loginForm = new LoginForm(_viewModel))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    statusLabel2.Text = "You're logged in!";
                    statusLabel2.ForeColor = Color.Green;
                    submitPanel.Visible = true;
                    checkStatusPanel.Visible = false;
                }
                else
                {
                    statusLabel2.Text = "Login failed. Please try again.";
                    statusLabel2.ForeColor = Color.Red;
                    submitPanel.Visible = false;
                    checkStatusPanel.Visible = false;
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Adjust button positions in submitPanel
            btnBrowseFile.Top = dataGridViewDocuments.Bottom + 10;
            btnRemoveFile.Top = dataGridViewDocuments.Bottom + 10;
            btnSubmitDocument.Top = dataGridViewDocuments.Bottom + 10;

            // Ensure tableLayout2 and tableLayout3 scale correctly
            tableLayout2.Width = metadataPanel.ClientSize.Width - tableLayout2.Margin.Horizontal;
            tableLayout2.Height = metadataPanel.ClientSize.Height - tableLayout2.Margin.Vertical;

            tableLayout3.Width = checkStatusPanel.ClientSize.Width - tableLayout3.Margin.Horizontal;
            tableLayout3.Height = checkStatusPanel.ClientSize.Height - tableLayout3.Margin.Vertical;

            // Adjust DataGridView sizes
            dataGridViewDocuments.Width = tableLayout2.GetColumnWidths()[0] - 10;
            dataGridViewFields.Width = tableLayout2.GetColumnWidths()[1] - 10;
        }

        private void InitializeStatusViewer()
        {
            if (!_viewerInitialized)
            {
                _statusViewer = new VerificationStatusViewer
                {
                    Dock = DockStyle.Fill,
                    Visible = false
                };
                panelStatusViewer.Controls.Add(_statusViewer);
                _viewerInitialized = true;
            }
        }

        private async void btnSubmitDocument_Click(object sender, EventArgs e)
        {
            try
            {
                _errorProvider.Clear();
                if (string.IsNullOrWhiteSpace(txtBatchClassName.Text))
                    _errorProvider.SetError(txtBatchClassName, "Please enter the batch category.");
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
                if (dataGridViewDocuments.RowCount == 1)
                    _errorProvider.SetError(dataGridViewDocuments, "Please add at least one document.");

                if (_errorProvider.GetError(txtBatchClassName) != "" ||
                    _errorProvider.GetError(txtSourceSystem) != "" ||
                    _errorProvider.GetError(txtChannel) != "" ||
                    _errorProvider.GetError(txtSessionID) != "" ||
                    _errorProvider.GetError(txtMessageID) != "" ||
                    _errorProvider.GetError(txtUserCode) != "" ||
                    _errorProvider.GetError(dataGridViewDocuments) != "")
                {
                    statusLabel2.Text = "Please fill in all required fields.";
                    statusLabel2.ForeColor = Color.Red;
                    return;
                }

                statusLabel2.Text = "Submitting your documents...";
                statusLabel2.ForeColor = Color.Blue;

                var fields = new List<Field>();
                foreach (DataGridViewRow row in dataGridViewFields.Rows)
                {
                    if (row.IsNewRow) continue;
                    var key = row.Cells["FieldName"].Value?.ToString();
                    var value = row.Cells["FieldValue"].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(key) && !string.IsNullOrWhiteSpace(value))
                    {
                        fields.Add(new Field { FieldName = key, FieldValue = value });
                    }
                }

                var documents = new List<Document_Row>();
                foreach (DataGridViewRow row in dataGridViewDocuments.Rows)
                {
                    if (row.IsNewRow) continue;
                    var key = row.Cells["FilePath"].Value?.ToString();
                    var value = row.Cells["PageType"].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(key))
                    {
                        documents.Add(new Document_Row { FilePath = key, PageType = value });
                    }
                }

                var requestGuid = await _viewModel.SubmitDocumentAsync(
                    txtBatchClassName.Text,
                    txtSourceSystem.Text,
                    txtChannel.Text,
                    txtSessionID.Text,
                    txtMessageID.Text,
                    txtUserCode.Text,
                    fields,
                    documents);

                statusLabel2.Text = $"Documents submitted! Your request Guid is: {requestGuid}";
                statusLabel2.ForeColor = Color.Green;
                txtStatusRequestGuid.Text = requestGuid;
                txtStatusSourceSystem.Text = txtSourceSystem.Text;
                txtStatusChannel.Text = txtChannel.Text;
                txtStatusSessionID.Text = txtSessionID.Text;
                txtStatusMessageID.Text = txtMessageID.Text;
                txtStatusUserCode.Text = txtUserCode.Text;
                submitPanel.Visible = false;
                checkStatusPanel.Visible = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("unauthorized") || ex.Message.Contains("401"))
                {
                    submitPanel.Visible = false;
                    checkStatusPanel.Visible = false;
                    using (var loginForm = new LoginForm(_viewModel))
                    {
                        if (loginForm.ShowDialog() == DialogResult.OK)
                        {
                            // Retry submission after successful login
                            btnSubmitDocument_Click(sender, e);
                        }
                        else
                        {
                            statusLabel2.Text = "Login failed. Please try again.";
                            statusLabel2.ForeColor = Color.Red;
                        }
                    }
                }
                else
                {
                    statusLabel2.Text = "Something went wrong while submitting. Please try again.";
                    statusLabel2.ForeColor = Color.Red;
                }
            }
        }

        private async void btnCheckStatus_Click(object sender, EventArgs e)
        {
            try
            {
                _errorProvider.Clear();
                if (string.IsNullOrWhiteSpace(txtStatusRequestGuid.Text))
                    _errorProvider.SetError(txtStatusRequestGuid, "Please enter the request ID.");
                if (string.IsNullOrWhiteSpace(txtStatusSourceSystem.Text))
                    _errorProvider.SetError(txtStatusSourceSystem, "Please enter the source system.");
                if (string.IsNullOrWhiteSpace(txtStatusChannel.Text))
                    _errorProvider.SetError(txtStatusChannel, "Please enter the channel.");
                if (string.IsNullOrWhiteSpace(txtStatusSessionID.Text))
                    _errorProvider.SetError(txtStatusSessionID, "Please enter the session ID.");
                if (string.IsNullOrWhiteSpace(txtStatusMessageID.Text))
                    _errorProvider.SetError(txtStatusMessageID, "Please enter the message ID.");
                if (string.IsNullOrWhiteSpace(txtStatusUserCode.Text))
                    _errorProvider.SetError(txtStatusUserCode, "Please enter the user ID.");

                if (_errorProvider.GetError(txtStatusRequestGuid) != "" ||
                    _errorProvider.GetError(txtStatusSourceSystem) != "" ||
                    _errorProvider.GetError(txtStatusChannel) != "" ||
                    _errorProvider.GetError(txtStatusSessionID) != "" ||
                    _errorProvider.GetError(txtStatusMessageID) != "" ||
                    _errorProvider.GetError(txtStatusUserCode) != "")
                {
                    statusLabel3.Text = "Please fill in all required fields.";
                    statusLabel3.ForeColor = Color.Red;
                    return;
                }

                btnCheckStatus.Enabled = false;
                progressBar.Visible = true;
                statusLabel3.Text = "Checking status...";
                statusLabel3.ForeColor = Color.Blue;

                InitializeStatusViewer();
                var result = await _viewModel.CheckVerificationStatusAsync(
                    txtStatusRequestGuid.Text,
                    txtStatusSourceSystem.Text,
                    txtStatusChannel.Text,
                    txtStatusSessionID.Text,
                    txtStatusMessageID.Text,
                    txtStatusUserCode.Text);

                _statusViewer.DisplayResults(result);
                _statusViewer.Visible = true;

                statusLabel3.Text = "Status retrieved!";
                statusLabel3.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("unauthorized") || ex.Message.Contains("401"))
                {
                    submitPanel.Visible = false;
                    checkStatusPanel.Visible = false;
                    using (var loginForm = new LoginForm(_viewModel))
                    {
                        if (loginForm.ShowDialog() == DialogResult.OK)
                        {
                            // Retry status check after successful login
                            btnCheckStatus_Click(sender, e);
                        }
                        else
                        {
                            statusLabel3.Text = "Login failed. Please try again.";
                            statusLabel3.ForeColor = Color.Red;
                        }
                    }
                }
                else
                {
                    statusLabel3.Text = "Something went wrong while checking the status. Please try again.";
                    statusLabel3.ForeColor = Color.Red;
                }
            }
            finally
            {
                btnCheckStatus.Enabled = true;
                progressBar.Visible = false;
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "PDF and Image Files (*.pdf;*.jpg;*.jpeg;*.png;*.bmp)|*.pdf;*.jpg;*.jpeg;*.png;*.bmp|PDF Files (*.pdf)|*.pdf|Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select PDF or Image Files"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var filePath in openFileDialog.FileNames)
                {
                    dataGridViewDocuments.Rows.Add(filePath, string.Empty);
                }
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDocuments.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataGridViewDocuments.Rows.Remove(row);
            }
        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            _statusViewer?.Controls.Clear();
            _statusViewer?.Dispose();
            _viewerInitialized = false;
            panelStatusViewer.Controls.Clear();
        }
    }
}