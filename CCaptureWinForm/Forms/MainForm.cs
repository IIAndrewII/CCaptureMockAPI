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
        private readonly DatabaseService _databaseService;
        private Dictionary<string, List<Document_Row>> _groups; // Store groups and their documents
        private int _groupCounter = 1; // For generating unique group names

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
            _databaseService = new DatabaseService(_configuration);
            _viewModel = new MainViewModel(apiService, fileService);

            // Initialize groups
            _groups = new Dictionary<string, List<Document_Row>>();
            AddNewGroup(); // Add the first group by default

            // Populate Batch Class Names
            PopulateBatchClassNamesAsync();

            // Configure DataGridView columns
            ConfigureDataGridViewColumns();

            // Attach event handlers
            btnBrowseFile.Click += btnBrowseFile_Click;
            btnRemoveFile.Click += btnRemoveFile_Click;
            btnSubmitDocument.Click += btnSubmitDocument_Click;
            btnCheckStatus.Click += btnCheckStatus_Click;
            btnClearResults.Click += btnClearResults_Click;
            btnAddGroup.Click += btnAddGroup_Click;
            btnRemoveGroup.Click += btnRemoveGroup_Click;
            lstSubmitGroups.SelectedIndexChanged += lstSubmitGroups_SelectedIndexChanged;
            Resize += MainForm_Resize;
            cboBatchClassName.SelectedIndexChanged += cboBatchClassName_SelectedIndexChanged;
            dataGridViewDocuments.CellValueChanged += dataGridViewDocuments_CellValueChanged;
            dataGridViewFields.CellValueChanged += dataGridViewFields_CellValueChanged;

            // Run loginAsync automatically
            var appName = _configuration["AppName"];
            var appLogin = _configuration["AppLogin"];
            var appPassword = _configuration["AppPassword"];
            _ = loginAsync(appName, appLogin, appPassword);
        }

        private void ConfigureDataGridViewColumns()
        {
            // Configure Documents DataGridView
            dataGridViewDocuments.Columns.Clear();
            dataGridViewDocuments.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "File Path",
                Name = "FilePath",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            var pageTypeColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Page Type",
                Name = "PageType",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FlatStyle = FlatStyle.Flat
            };
            dataGridViewDocuments.Columns.Add(pageTypeColumn);

            // Configure Fields DataGridView
            dataGridViewFields.Columns.Clear();
            var fieldNameColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Field Name",
                Name = "FieldName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FlatStyle = FlatStyle.Flat
            };
            dataGridViewFields.Columns.Add(fieldNameColumn);
            dataGridViewFields.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Field Value",
                Name = "FieldValue",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void AddNewGroup()
        {
            var groupName = $"Group {_groupCounter++}";
            _groups.Add(groupName, new List<Document_Row>());
            lstSubmitGroups.Items.Add(groupName, true); // Add + checked
            lstSubmitGroups.SelectedItem = groupName; // Select the new group
        }

        private async void PopulateBatchClassNamesAsync()
        {
            try
            {
                var batchClassNames = await _databaseService.GetBatchClassNamesAsync();
                cboBatchClassName.Items.Clear();
                cboBatchClassName.Items.AddRange(batchClassNames.ToArray());
                if (cboBatchClassName.Items.Count > 0)
                    cboBatchClassName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                statusLabel2.Text = $"Failed to load Batch Class Names: {ex.Message}";
                statusLabel2.ForeColor = Color.Red;
            }
        }

        private async void cboBatchClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBatchClassName.SelectedIndex != -1)
            {
                _errorProvider.SetError(cboBatchClassName, "");
                string selectedBatchClass = cboBatchClassName.SelectedItem.ToString();

                try
                {
                    // Fetch page types and field names
                    var pageTypes = await _databaseService.GetPageTypesAsync(selectedBatchClass);
                    var fieldNames = await _databaseService.GetFieldNamesAsync(selectedBatchClass);

                    // Update PageType dropdown in dataGridViewDocuments
                    var pageTypeColumn = (DataGridViewComboBoxColumn)dataGridViewDocuments.Columns["PageType"];
                    pageTypeColumn.Items.Clear();
                    pageTypeColumn.Items.AddRange(pageTypes.ToArray());

                    // Update FieldName dropdown in dataGridViewFields
                    var fieldNameColumn = (DataGridViewComboBoxColumn)dataGridViewFields.Columns["FieldName"];
                    fieldNameColumn.Items.Clear();
                    fieldNameColumn.Items.AddRange(fieldNames.ToArray());

                    // Refresh the document grid to ensure dropdowns reflect the new options
                    UpdateDocumentGrid();
                }
                catch (Exception ex)
                {
                    statusLabel2.Text = $"Failed to load page types or field names: {ex.Message}";
                    statusLabel2.ForeColor = Color.Red;
                }
            }
        }

        private void lstSubmitGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDocumentGrid();
        }

        private void UpdateDocumentGrid()
        {
            dataGridViewDocuments.Rows.Clear();
            if (lstSubmitGroups.SelectedItem != null)
            {
                string selectedGroup = lstSubmitGroups.SelectedItem.ToString();
                foreach (var doc in _groups[selectedGroup])
                {
                    int rowIndex = dataGridViewDocuments.Rows.Add(doc.FilePath, doc.PageType);
                    // Ensure the PageType is selected if it exists in the dropdown
                    if (!string.IsNullOrEmpty(doc.PageType))
                    {
                        var pageTypeCell = dataGridViewDocuments.Rows[rowIndex].Cells["PageType"];
                        if (((DataGridViewComboBoxColumn)dataGridViewDocuments.Columns["PageType"]).Items.Contains(doc.PageType))
                        {
                            pageTypeCell.Value = doc.PageType;
                        }
                    }
                }
            }
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
                tabControl.SelectedTab = submitTab;
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
                    tabControl.SelectedTab = submitTab;
                    submitPanel.Visible = true;
                    checkStatusPanel.Visible = true;
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
            tableLayout2.Width = metadataPanel.ClientSize.Width - tableLayout2.Margin.Horizontal;
            tableLayout2.Height = metadataPanel.ClientSize.Height - tableLayout2.Margin.Vertical;

            tableLayout3.Width = checkStatusPanel.ClientSize.Width - tableLayout3.Margin.Horizontal;
            tableLayout3.Height = checkStatusPanel.ClientSize.Height - tableLayout3.Margin.Vertical;

            dataGridViewDocuments.Width = tableLayout2.GetColumnWidths()[0] - 10;
            dataGridViewFields.Width = tableLayout2.GetColumnWidths()[4] - 10;
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
                if (cboBatchClassName.SelectedIndex == -1)
                    _errorProvider.SetError(cboBatchClassName, "Please select a batch category.");
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
                if (!lstSubmitGroups.CheckedItems.Cast<string>().Any(group => _groups[group].Any()))
                    _errorProvider.SetError(lstSubmitGroups, "Please check at least one group with documents.");

                if (_errorProvider.GetError(cboBatchClassName) != "" ||
                    _errorProvider.GetError(txtSourceSystem) != "" ||
                    _errorProvider.GetError(txtChannel) != "" ||
                    _errorProvider.GetError(txtSessionID) != "" ||
                    _errorProvider.GetError(txtMessageID) != "" ||
                    _errorProvider.GetError(txtUserCode) != "" ||
                    _errorProvider.GetError(lstSubmitGroups) != "")
                {
                    statusLabel2.Text = "Please fill in all required fields and check at least one group with documents.";
                    statusLabel2.ForeColor = Color.Red;
                    return;
                }

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

                // Update PageType in _groups based on DataGridView
                foreach (string group in lstSubmitGroups.CheckedItems.Cast<string>().Where(g => _groups[g].Any()))
                {
                    var documents = _groups[group];
                    foreach (DataGridViewRow row in dataGridViewDocuments.Rows)
                    {
                        if (row.IsNewRow) continue;
                        var filePath = row.Cells["FilePath"].Value?.ToString();
                        var pageType = row.Cells["PageType"].Value?.ToString();
                        var doc = documents.FirstOrDefault(d => d.FilePath == filePath);
                        if (doc != null)
                        {
                            doc.PageType = pageType ?? string.Empty;
                        }
                    }

                    statusLabel2.Text = $"Submitting {group} documents...";
                    statusLabel2.ForeColor = Color.Blue;
                    var requestGuid = await _viewModel.SubmitDocumentAsync(
                        cboBatchClassName.SelectedItem.ToString(),
                        txtSourceSystem.Text,
                        txtChannel.Text,
                        txtSessionID.Text,
                        txtMessageID.Text,
                        txtUserCode.Text,
                        pickerInteractionDateTime.Value.ToString("o"),
                        fields,
                        documents);

                    statusLabel2.Text = $"Documents for {group} submitted! Request Guid: {requestGuid}";
                    statusLabel2.ForeColor = Color.Green;

                    // Update status fields for the last group submitted
                    txtStatusRequestGuid.Text = requestGuid;
                    txtStatusSourceSystem.Text = txtSourceSystem.Text;
                    txtStatusChannel.Text = txtChannel.Text;
                    txtStatusSessionID.Text = txtSessionID.Text;
                    txtStatusMessageID.Text = txtMessageID.Text;
                    txtStatusUserCode.Text = txtUserCode.Text;
                }

                tabControl.SelectedTab = checkStatusTab;
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
            if (lstSubmitGroups.SelectedItem == null)
            {
                MessageBox.Show("Please select a group first.", "No Group Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedGroup = lstSubmitGroups.SelectedItem.ToString();
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
                    var doc = new Document_Row { FilePath = filePath, PageType = string.Empty };
                    _groups[selectedGroup].Add(doc);
                    // Update grid only if the selected group is still selected
                    if (lstSubmitGroups.SelectedItem?.ToString() == selectedGroup)
                    {
                        dataGridViewDocuments.Rows.Add(filePath, string.Empty);
                    }
                }
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (lstSubmitGroups.SelectedItem == null)
            {
                MessageBox.Show("Please select a group first.", "No Group Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedGroup = lstSubmitGroups.SelectedItem.ToString();
            foreach (DataGridViewRow row in dataGridViewDocuments.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    var filePath = row.Cells["FilePath"].Value?.ToString();
                    _groups[selectedGroup].RemoveAll(doc => doc.FilePath == filePath);
                    dataGridViewDocuments.Rows.Remove(row);
                }
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            AddNewGroup();
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            if (lstSubmitGroups.SelectedItem != null)
            {
                var selectedGroup = lstSubmitGroups.SelectedItem.ToString();
                _groups.Remove(selectedGroup);
                int prevIndex = lstSubmitGroups.SelectedIndex;
                lstSubmitGroups.Items.Remove(selectedGroup);
                if (lstSubmitGroups.Items.Count > 0)
                {
                    // Select the next or previous item
                    lstSubmitGroups.SelectedIndex = Math.Min(prevIndex, lstSubmitGroups.Items.Count - 1);
                }
                else
                {
                    AddNewGroup(); // Ensure at least one group exists
                }
                UpdateDocumentGrid();
            }
        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            _statusViewer?.Controls.Clear();
            _statusViewer?.Dispose();
            _viewerInitialized = false;
            panelStatusViewer.Controls.Clear();
        }

        private void dataGridViewDocuments_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDocuments.Columns["PageType"].Index && e.RowIndex >= 0)
            {
                string selectedGroup = lstSubmitGroups.SelectedItem?.ToString();
                if (selectedGroup != null)
                {
                    var filePath = dataGridViewDocuments.Rows[e.RowIndex].Cells["FilePath"].Value?.ToString();
                    var pageType = dataGridViewDocuments.Rows[e.RowIndex].Cells["PageType"].Value?.ToString();
                    var doc = _groups[selectedGroup].FirstOrDefault(d => d.FilePath == filePath);
                    if (doc != null)
                    {
                        doc.PageType = pageType ?? string.Empty;
                    }
                }
            }
        }

        private void dataGridViewFields_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}