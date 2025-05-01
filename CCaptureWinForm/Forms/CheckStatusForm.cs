using CCaptureWinForm.Core.Entities;
using CCaptureWinForm.Core.Interfaces;
using CCaptureWinForm.Infrastructure.Services;
using CCaptureWinForm.Presentation.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
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

        public CheckStatusForm()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;

            _errorProvider = new ErrorProvider(this) { BlinkStyle = ErrorBlinkStyle.NeverBlink };
        }

        public CheckStatusForm(IApiDatabaseService apiDatabaseService, IDatabaseService databaseService, IConfiguration configuration, MainViewModel viewModel)
            : this()
        {
            _apiDatabaseService = apiDatabaseService;
            _databaseService = databaseService;
            _configuration = configuration;
            _viewModel = viewModel;

            // Initialize the API URL textbox with the configured value
            txtApiUrl.Text = _configuration["ApiUrl"];
            ConfigureDataGridViewRequests();
            ConfigureTreeView();
            AttachEventHandlers();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            var appName = _configuration["AppName"];
            var appLogin = _configuration["AppLogin"];
            var appPassword = _configuration["AppPassword"];
            await loginAsync(appName, appLogin, appPassword);
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
            dataGridViewRequests.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Details",
                Name = "Details",
                Text = "View Details",
                UseColumnTextForButtonValue = true,
                Width = 100
            });
            dataGridViewRequests.AllowUserToAddRows = true;
            dataGridViewRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ConfigureTreeView()
        {
            VerificationStatusTree.Nodes.Clear();
            VerificationStatusTree.Font = new Font("Segoe UI", 12F);
            VerificationStatusTree.ShowLines = true;
            VerificationStatusTree.ShowPlusMinus = true;
        }

        private void AttachEventHandlers()
        {
            btnCheckStatus.Click += btnCheckStatus_Click;
            btnExpandAll.Click += btnExpandAll_Click;
            btnCollapseAll.Click += btnCollapseAll_Click;
            dataGridViewRequests.DataError += DataGridViewRequests_DataError;
            dataGridViewRequests.CellContentClick += DataGridViewRequests_CellContentClick;
        }

        private async void DataGridViewRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewRequests.Columns["Details"].Index && e.RowIndex >= 0)
            {
                var requestGuid = dataGridViewRequests.Rows[e.RowIndex].Cells["RequestGuid"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(requestGuid) && Guid.TryParse(requestGuid, out _))
                {
                    try
                    {
                        var details = await _databaseService.GetSubmissionDetailsAsync(requestGuid);
                        using (var detailsForm = new SubmissionDetailsForm(details))
                        {
                            detailsForm.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            VerificationStatusTree.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            VerificationStatusTree.CollapseAll();
        }

        private async Task loginAsync(string appName, string appLogin, string appPassword)
        {
            try
            {
                _errorProvider.Clear();
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
                statusLabel3.Text = ex.Message.ToLower().Contains("unauthorized") || ex.Message.Contains("401")
                    ? "Unauthorized configuration settings."
                    : $"Login failed: {ex.Message}";
                statusLabel3.ForeColor = Color.Red;
                ShowLoginForm();
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

                // Collect valid RequestGuids
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
                    _errorProvider.GetError(txtUserCode) != "")
                {
                    statusLabel3.Text = "Please fill in all required fields and provide at least one valid Request Guid.";
                    statusLabel3.ForeColor = Color.Red;
                    return;
                }

                // Use the textbox value if provided, otherwise fall back to configuration
                var apiUrl = string.IsNullOrWhiteSpace(txtApiUrl.Text) ? _configuration["ApiUrl"] : txtApiUrl.Text;
                if (string.IsNullOrEmpty(apiUrl))
                {
                    throw new InvalidOperationException("API URL is not configured in appsettings.json or provided in the textbox");
                }
                // Update the ApiService with the selected URL
                var apiService = new ApiService(apiUrl);
                _viewModel.UpdateApiService(apiService);

                statusLabel3.Text = "Checking status...";
                statusLabel3.ForeColor = Color.Blue;
                toolStripProgressBar1.Visible = true;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Maximum = requestGuids.Count;
                VerificationStatusTree.Nodes.Clear();

                foreach (var requestGuid in requestGuids)
                {
                    try
                    {
                        statusLabel3.Text = $"Checking status for {requestGuid}...";
                        var responseJson = await _viewModel.CheckVerificationStatusAsync(
                            requestGuid,
                            txtSourceSystem.Text,
                            txtChannel.Text,
                            txtSessionID.Text,
                            txtMessageID.Text,
                            txtUserCode.Text,
                            pickerInteractionDateTime.Value.ToString("o"));

                        // Deserialize the JSON response
                        var response = JsonSerializer.Deserialize<VerificationResponse>(responseJson, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        // Save the VerificationResponse to the database
                        await _databaseService.SaveVerificationResponseAsync(response, requestGuid);

                        // Build TreeView for this request
                        var requestNode = VerificationStatusTree.Nodes.Add($"Request Guid: {requestGuid}");
                        requestNode.ForeColor = Color.Black;

                        // Add top-level response fields
                        var statusNode = requestNode.Nodes.Add($"Status: {response.Status}");
                        statusNode.ForeColor = response.Status == 0 ? Color.Green : Color.Red;

                        var executionDateNode = requestNode.Nodes.Add($"Execution Date: {response.ExecutionDate:yyyy-MM-dd HH:mm:ss}");
                        executionDateNode.ForeColor = Color.Black;

                        if (!string.IsNullOrEmpty(response.ErrorMessage))
                        {
                            var errorNode = requestNode.Nodes.Add($"Error Message: {response.ErrorMessage}");
                            errorNode.ForeColor = Color.Red;
                        }

                        // Add Batch details
                        if (response.Batch != null)
                        {
                            var batchNode = requestNode.Nodes.Add("Batch");
                            batchNode.ForeColor = Color.Black;

                            batchNode.Nodes.Add($"Id: {response.Batch.Id}").ForeColor = Color.Black;
                            batchNode.Nodes.Add($"Name: {response.Batch.Name}").ForeColor = Color.Black;
                            batchNode.Nodes.Add($"Creation Date: {response.Batch.CreationDate:yyyy-MM-dd HH:mm:ss}").ForeColor = Color.Black;
                            batchNode.Nodes.Add($"Close Date: {response.Batch.CloseDate:yyyy-MM-dd HH:mm:ss}").ForeColor = Color.Black;

                            // BatchClass
                            if (response.Batch.BatchClass != null)
                            {
                                var batchClassNode = batchNode.Nodes.Add($"Batch Class: {response.Batch.BatchClass.Name}");
                                batchClassNode.ForeColor = Color.Black;
                            }

                            // BatchFields
                            if (response.Batch.BatchFields?.Any() == true)
                            {
                                var fieldsNode = batchNode.Nodes.Add("Batch Fields");
                                fieldsNode.ForeColor = Color.Black;
                                foreach (var field in response.Batch.BatchFields)
                                {
                                    var fieldNode = fieldsNode.Nodes.Add($"Field: {field.Name}");
                                    fieldNode.ForeColor = Color.Black;
                                    fieldNode.Nodes.Add($"Value: {field.Value}").ForeColor = Color.Black;
                                    fieldNode.Nodes.Add($"Confidence: {field.Confidence}").ForeColor = Color.Black;
                                }
                            }

                            // Documents
                            if (response.Batch.Documents?.Any() == true)
                            {
                                var docsNode = batchNode.Nodes.Add("Documents");
                                docsNode.ForeColor = Color.Black;
                                foreach (var doc in response.Batch.Documents)
                                {
                                    var docNode = docsNode.Nodes.Add($"Document: {doc.Name}");
                                    docNode.ForeColor = Color.Black;

                                    if (doc.DocumentClass != null)
                                    {
                                        docNode.Nodes.Add($"Document Class: {doc.DocumentClass.Name}").ForeColor = Color.Black;
                                    }

                                    if (doc.Pages?.Any() == true)
                                    {
                                        var pagesNode = docNode.Nodes.Add("Pages");
                                        pagesNode.ForeColor = Color.Black;
                                        foreach (var page in doc.Pages)
                                        {
                                            var pageNode = pagesNode.Nodes.Add($"Page: {page.FileName}");
                                            pageNode.ForeColor = Color.Black;

                                            if (page.PageTypes?.Any() == true)
                                            {
                                                var pageTypesNode = pageNode.Nodes.Add("Page Types");
                                                pageTypesNode.ForeColor = Color.Black;
                                                foreach (var pageType in page.PageTypes)
                                                {
                                                    var pageTypeNode = pageTypesNode.Nodes.Add($"Type: {pageType.Name}");
                                                    pageTypeNode.ForeColor = Color.Black;
                                                    pageTypeNode.Nodes.Add($"Confidence: {pageType.Confidence}").ForeColor = Color.Black;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            // BatchStates
                            if (response.Batch.BatchStates?.Any() == true)
                            {
                                var statesNode = batchNode.Nodes.Add("Batch States");
                                statesNode.ForeColor = Color.Black;
                                foreach (var state in response.Batch.BatchStates)
                                {
                                    var stateNode = statesNode.Nodes.Add($"State: {state.Value}");
                                    stateNode.ForeColor = Color.Black;
                                    stateNode.Nodes.Add($"Track Date: {state.TrackDate:yyyy-MM-dd HH:mm:ss}").ForeColor = Color.Black;
                                    stateNode.Nodes.Add($"Workstation: {state.Workstation}").ForeColor = Color.Black;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        var requestNode = VerificationStatusTree.Nodes.Add($"Request Guid: {requestGuid}");
                        requestNode.ForeColor = Color.Black;
                        var errorNode = requestNode.Nodes.Add($"Error: {ex.Message}");
                        errorNode.ForeColor = Color.Red;
                    }
                    toolStripProgressBar1.Value++;
                    Application.DoEvents();
                }

                VerificationStatusTree.ExpandAll();
                toolStripProgressBar1.Visible = false;
                statusLabel3.Text = "Status check completed.";
                statusLabel3.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                toolStripProgressBar1.Visible = false;
                statusLabel3.Text = $"Error: {ex.Message}";
                statusLabel3.ForeColor = Color.Red;
                if (ex.Message.ToLower().Contains("unauthorized") || ex.Message.Contains("401"))
                    ShowLoginForm();
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