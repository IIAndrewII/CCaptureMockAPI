using CCaptureWinForm.Core.Entities;
using CCaptureWinForm.Core.Interfaces;
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
        private readonly IDatabaseService _databaseService;

        private Dictionary<string, List<Document_Row>> _groups; // Store groups and their documents
        private int _groupCounter = 1; // For generating unique group names

        public MainForm(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
            InitializeComponent();
            _errorProvider = new ErrorProvider(this) { BlinkStyle = ErrorBlinkStyle.NeverBlink };

            // Add DataError handlers
            dataGridViewDocuments.DataError += DataGridViewDocuments_DataError;
            dataGridViewFields.DataError += DataGridViewFields_DataError;

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

            // Configure DataGridViewGroups columns *before* adding groups
            ConfigureDataGridViewGroupsColumns();

            // Add the first group
            AddNewGroup();

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
            dataGridViewGroups.SelectionChanged += dataGridViewGroups_SelectionChanged;
            dataGridViewGroups.CellValueChanged += dataGridViewGroups_CellValueChanged;
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

        private void ConfigureDataGridViewGroupsColumns()
        {
            dataGridViewGroups.Columns.Clear();
            dataGridViewGroups.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Submit",
                Name = "Submit",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dataGridViewGroups.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Group Name",
                Name = "GroupName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            // Ensure single row selection and full row select
            dataGridViewGroups.MultiSelect = false;
            dataGridViewGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            dataGridViewFields.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Field Type",
                Name = "FieldType",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });
        }

        private void AddNewGroup()
        {
            var groupName = $"Group {_groupCounter++}";
            _groups.Add(groupName, new List<Document_Row>());

            // Ensure columns exist before adding rows
            if (dataGridViewGroups.Columns.Count >= 2)
            {
                int rowIndex = dataGridViewGroups.Rows.Add(true, groupName); // Add checked by default
                dataGridViewGroups.ClearSelection();
                dataGridViewGroups.Rows[rowIndex].Selected = true; // Select the new group
            }
            else
            {
                throw new InvalidOperationException("DataGridViewGroups columns are not initialized.");
            }
        }

        private async void PopulateBatchClassNamesAsync()
        {
            try
            {
                var batchClassNames = await _databaseService.GetBatchClassNamesAsync();
                cboBatchClassName.Items.Clear();
                cboBatchClassName.Items.AddRange(batchClassNames.ToArray());
                if (cboBatchClassName.Items.Count > 0)
                {
                    cboBatchClassName.SelectedIndex = 0;

                    // Trigger field type population for existing rows
                    foreach (DataGridViewRow row in dataGridViewFields.Rows)
                    {
                        if (row.IsNewRow) continue;
                        var fieldName = row.Cells["FieldName"].Value?.ToString();
                        if (!string.IsNullOrEmpty(fieldName))
                        {
                            var fieldType = await _databaseService.GetFieldTypeAsync(fieldName);
                            row.Cells["FieldType"].Value = fieldType;
                        }
                    }
                }
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

                    // Reset invalid PageType in _groups
                    foreach (var group in _groups)
                    {
                        foreach (var doc in group.Value)
                        {
                            if (!string.IsNullOrEmpty(doc.PageType) && !pageTypes.Contains(doc.PageType))
                            {
                                doc.PageType = string.Empty; // Reset to default
                            }
                        }
                    }

                    // Reset invalid FieldName in dataGridViewFields
                    foreach (DataGridViewRow row in dataGridViewFields.Rows)
                    {
                        if (row.IsNewRow) continue;
                        var fieldName = row.Cells["FieldName"].Value?.ToString();
                        if (!string.IsNullOrEmpty(fieldName) && !fieldNames.Contains(fieldName))
                        {
                            row.Cells["FieldName"].Value = null;
                            row.Cells["FieldValue"].Value = null;
                            row.Cells["FieldType"].Value = string.Empty;
                        }
                    }

                    // Update PageType dropdown in dataGridViewDocuments
                    var pageTypeColumn = (DataGridViewComboBoxColumn)dataGridViewDocuments.Columns["PageType"];
                    pageTypeColumn.Items.Clear();
                    pageTypeColumn.Items.AddRange(pageTypes.ToArray());

                    // Update FieldName dropdown in dataGridViewFields
                    var fieldNameColumn = (DataGridViewComboBoxColumn)dataGridViewFields.Columns["FieldName"];
                    fieldNameColumn.Items.Clear();
                    fieldNameColumn.Items.AddRange(fieldNames.ToArray());

                    // Update FieldType for valid FieldName rows
                    foreach (DataGridViewRow row in dataGridViewFields.Rows)
                    {
                        if (row.IsNewRow) continue;
                        var fieldName = row.Cells["FieldName"].Value?.ToString();
                        if (!string.IsNullOrEmpty(fieldName) && fieldNames.Contains(fieldName))
                        {
                            var fieldType = await _databaseService.GetFieldTypeAsync(fieldName);
                            row.Cells["FieldType"].Value = fieldType;
                        }
                        else
                        {
                            row.Cells["FieldType"].Value = string.Empty;
                        }
                    }

                    // Refresh the document grid to reflect updated PageType values
                    UpdateDocumentGrid();
                }
                catch (Exception ex)
                {
                    statusLabel2.Text = $"Failed to load page types or field names: {ex.Message}";
                    statusLabel2.ForeColor = Color.Red;
                }
            }
        }

        private void dataGridViewGroups_SelectionChanged(object sender, EventArgs e)
        {
            // Debug: Log selection event
            statusLabel2.Text = "Group selection changed.";
            statusLabel2.ForeColor = Color.Blue;

            UpdateDocumentGrid();
        }

        private void dataGridViewGroups_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Handle checkbox changes in the Submit column
            if (e.ColumnIndex == dataGridViewGroups.Columns["Submit"].Index && e.RowIndex >= 0)
            {
                UpdateDocumentGrid(); // Refresh grid to ensure consistency
            }
        }

        private void UpdateDocumentGrid()
        {
            dataGridViewDocuments.Rows.Clear();
            var selectedRow = dataGridViewGroups.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                string selectedGroup = selectedRow.Cells["GroupName"].Value?.ToString();
                statusLabel2.Text = $"Selected group: {selectedGroup ?? "None"}";
                statusLabel2.ForeColor = Color.Blue;

                if (selectedGroup != null && _groups.ContainsKey(selectedGroup))
                {
                    var pageTypeColumn = (DataGridViewComboBoxColumn)dataGridViewDocuments.Columns["PageType"];
                    foreach (var doc in _groups[selectedGroup])
                    {
                        int rowIndex = dataGridViewDocuments.Rows.Add(doc.FilePath, null); // Set PageType to null initially
                        if (!string.IsNullOrEmpty(doc.PageType) && pageTypeColumn.Items.Contains(doc.PageType))
                        {
                            dataGridViewDocuments.Rows[rowIndex].Cells["PageType"].Value = doc.PageType;
                        }
                    }
                }
            }
            else
            {
                statusLabel2.Text = "No group selected.";
                statusLabel2.ForeColor = Color.Orange;
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
                if (!dataGridViewGroups.Rows.Cast<DataGridViewRow>()
                    .Any(row => (bool?)row.Cells["Submit"].Value == true && _groups[row.Cells["GroupName"].Value.ToString()].Any()))
                    _errorProvider.SetError(dataGridViewGroups, "Please check at least one group with documents.");

                if (_errorProvider.GetError(cboBatchClassName) != "" ||
                    _errorProvider.GetError(txtSourceSystem) != "" ||
                    _errorProvider.GetError(txtChannel) != "" ||
                    _errorProvider.GetError(txtSessionID) != "" ||
                    _errorProvider.GetError(txtMessageID) != "" ||
                    _errorProvider.GetError(txtUserCode) != "" ||
                    _errorProvider.GetError(dataGridViewGroups) != "")
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
                var checkedGroups = dataGridViewGroups.Rows.Cast<DataGridViewRow>()
                    .Where(row => (bool?)row.Cells["Submit"].Value == true)
                    .Select(row => row.Cells["GroupName"].Value.ToString())
                    .Where(group => _groups[group].Any())
                    .ToList(); // ToList to avoid collection modification issues

                foreach (string group in checkedGroups)
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

                    // Remove the submitted group
                    _groups.Remove(group);
                    var rowToRemove = dataGridViewGroups.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(r => r.Cells["GroupName"].Value?.ToString() == group);
                    if (rowToRemove != null)
                    {
                        dataGridViewGroups.Rows.Remove(rowToRemove);
                    }

                    // Update status fields for the last group submitted
                    txtStatusRequestGuid.Text = requestGuid;
                    txtStatusSourceSystem.Text = txtSourceSystem.Text;
                    txtStatusChannel.Text = txtChannel.Text;
                    txtStatusSessionID.Text = txtSessionID.Text;
                    txtStatusMessageID.Text = txtMessageID.Text;
                    txtStatusUserCode.Text = txtUserCode.Text;
                }

                // Handle post-submission state
                if (_groups.Count == 0)
                {
                    AddNewGroup(); // Ensure at least one group exists
                }
                else
                {
                    // Select the first remaining group
                    dataGridViewGroups.Rows[0].Selected = true;
                    UpdateDocumentGrid(); // Refresh document grid
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
            var selectedRow = dataGridViewGroups.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow == null)
            {
                MessageBox.Show("Please select a group first.", "No Group Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedGroup = selectedRow.Cells["GroupName"].Value.ToString();
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
                    if (dataGridViewGroups.SelectedRows.Count > 0 &&
                        dataGridViewGroups.SelectedRows[0].Cells["GroupName"].Value.ToString() == selectedGroup)
                    {
                        dataGridViewDocuments.Rows.Add(filePath, string.Empty);
                    }
                }
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewGroups.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow == null)
            {
                MessageBox.Show("Please select a group first.", "No Group Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedGroup = selectedRow.Cells["GroupName"].Value.ToString();
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
            var selectedRow = dataGridViewGroups.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var selectedGroup = selectedRow.Cells["GroupName"].Value.ToString();
                _groups.Remove(selectedGroup);
                dataGridViewGroups.Rows.Remove(selectedRow);
                if (dataGridViewGroups.Rows.Count == 0)
                {
                    AddNewGroup(); // Ensure at least one group exists
                }
                else
                {
                    // Select the first row without triggering SelectionChanged prematurely
                    dataGridViewGroups.Rows[0].Selected = true;
                    UpdateDocumentGrid(); // Manually update grid
                }
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
                var selectedRow = dataGridViewGroups.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
                if (selectedRow != null)
                {
                    string selectedGroup = selectedRow.Cells["GroupName"].Value.ToString();
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

        private async void dataGridViewFields_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Handle FieldName column changes
            if (e.ColumnIndex == dataGridViewFields.Columns["FieldName"].Index)
            {
                var fieldName = dataGridViewFields.Rows[e.RowIndex].Cells["FieldName"].Value?.ToString();
                var batchClassName = cboBatchClassName.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(fieldName) && !string.IsNullOrEmpty(batchClassName))
                {
                    try
                    {
                        // Fetch the field type
                        var fieldType = await _databaseService.GetFieldTypeAsync(fieldName);

                        // Update the FieldType cell
                        dataGridViewFields.Rows[e.RowIndex].Cells["FieldType"].Value = fieldType;
                    }
                    catch (Exception ex)
                    {
                        statusLabel2.Text = $"Failed to load field type: {ex.Message}";
                        statusLabel2.ForeColor = Color.Red;
                    }
                }
                else
                {
                    // Clear FieldType if FieldName is empty
                    dataGridViewFields.Rows[e.RowIndex].Cells["FieldType"].Value = string.Empty;
                }
            }
        }

        private void DataGridViewDocuments_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDocuments.Columns["PageType"].Index)
            {
                // Handle invalid PageType selection
                dataGridViewDocuments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                e.Cancel = true; // Suppress the error
            }
        }

        private void DataGridViewFields_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewFields.Columns["FieldCanvas"].Index)
            {
                // Handle invalid FieldName selection
                dataGridViewFields.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                dataGridViewFields.Rows[e.RowIndex].Cells["FieldType"].Value = string.Empty;
                e.Cancel = true; // Suppress the error
            }
        }
    }
}