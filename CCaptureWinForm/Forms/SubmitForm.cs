using CCaptureWinForm.Core.Entities;
using CCaptureWinForm.Core.Interfaces;
using CCaptureWinForm.Presentation;
using CCaptureWinForm.Presentation.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCaptureWinForm
{
    public partial class SubmitForm : Form
    {
        private readonly IApiDatabaseService _apiDatabaseService;
        private readonly IDatabaseService _databaseService;
        private readonly IConfiguration _configuration;
        private readonly MainViewModel _viewModel;
        private readonly ErrorProvider _errorProvider;
        private Dictionary<string, List<Document_Row>> _groups;
        private int _groupCounter = 1;

        public SubmitForm(IApiDatabaseService apiDatabaseService, IDatabaseService databaseService, IConfiguration configuration, MainViewModel viewModel)
        {
            _apiDatabaseService = apiDatabaseService ?? throw new ArgumentNullException(nameof(apiDatabaseService));
            _databaseService = databaseService ?? throw new ArgumentNullException(nameof(databaseService));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
            InitializeComponent();
            _errorProvider = new ErrorProvider(this) { BlinkStyle = ErrorBlinkStyle.NeverBlink };
            _groups = new Dictionary<string, List<Document_Row>>();

            // Attach basic event handlers
            dataGridViewDocuments.DataError += DataGridViewDocuments_DataError;
            dataGridViewFields.DataError += DataGridViewFields_DataError;
            btnBrowseFile.Click += btnBrowseFile_Click;
            btnRemoveFile.Click += btnRemoveFile_Click;
            btnSubmitDocument.Click += btnSubmitDocument_Click;
            btnAddGroup.Click += btnAddGroup_Click;
            btnRemoveGroup.Click += btnRemoveGroup_Click;
            btnRemoveField.Click += btnRemoveField_Click;
            dataGridViewGroups.SelectionChanged += dataGridViewGroups_SelectionChanged;
            dataGridViewGroups.CellValueChanged += dataGridViewGroups_CellValueChanged;
            Resize += SubmitForm_Resize;
            cboBatchClassName.SelectedIndexChanged += cboBatchClassName_SelectedIndexChanged;
            dataGridViewDocuments.CellValueChanged += dataGridViewDocuments_CellValueChanged;
            dataGridViewFields.CellValueChanged += dataGridViewFields_CellValueChanged;

            // Perform async initialization
            Task.Run(() => InitializeAsync());
        }

        private async Task InitializeAsync()
        {
            try
            {
                // Configure DataGridViewGroups columns
                this.Invoke((Action)ConfigureDataGridViewGroupsColumns);

                // Add the first group
                this.Invoke((Action)AddNewGroup);

                // Populate Batch Class Names
                await PopulateBatchClassNamesAsync();

                // Configure DataGridView columns
                this.Invoke((Action)ConfigureDataGridViewColumns);

                // Run loginAsync
                var appName = _configuration["AppName"];
                var appLogin = _configuration["AppLogin"];
                var appPassword = _configuration["AppPassword"];
                await loginAsync(appName, appLogin, appPassword);
            }
            catch (Exception ex)
            {
                this.Invoke((Action)(() =>
                {
                    statusLabel2.Text = $"Initialization failed: {ex.Message}";
                    statusLabel2.ForeColor = Color.Red;
                }));
            }
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

            dataGridViewGroups.MultiSelect = false;
            dataGridViewGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ConfigureDataGridViewColumns()
        {
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

            if (dataGridViewGroups.Columns.Count >= 2)
            {
                int rowIndex = dataGridViewGroups.Rows.Add(true, groupName);
                dataGridViewGroups.ClearSelection();
                dataGridViewGroups.Rows[rowIndex].Selected = true;
            }
            else
            {
                throw new InvalidOperationException("DataGridViewGroups columns are not initialized.");
            }
        }

        private async Task PopulateBatchClassNamesAsync()
        {
            try
            {
                var batchClassNames = await _apiDatabaseService.GetBatchClassNamesAsync();
                this.Invoke((Action)(() =>
                {
                    cboBatchClassName.Items.Clear();
                    cboBatchClassName.Items.AddRange(batchClassNames.ToArray());
                    if (cboBatchClassName.Items.Count > 0)
                    {
                        cboBatchClassName.SelectedIndex = 0;
                    }
                }));

                foreach (DataGridViewRow row in dataGridViewFields.Rows)
                {
                    if (row.IsNewRow) continue;
                    var fieldName = row.Cells["FieldName"].Value?.ToString();
                    if (!string.IsNullOrEmpty(fieldName))
                    {
                        var fieldType = await _apiDatabaseService.GetFieldTypeAsync(fieldName);
                        this.Invoke((Action)(() =>
                        {
                            row.Cells["FieldType"].Value = fieldType;
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                this.Invoke((Action)(() =>
                {
                    statusLabel2.Text = $"Failed to load Batch Class Names: {ex.Message}";
                    statusLabel2.ForeColor = Color.Red;
                }));
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
                    var pageTypes = await _apiDatabaseService.GetPageTypesAsync(selectedBatchClass);
                    var fieldNames = await _apiDatabaseService.GetFieldNamesAsync(selectedBatchClass);

                    foreach (var group in _groups)
                    {
                        foreach (var doc in group.Value)
                        {
                            if (!string.IsNullOrEmpty(doc.PageType) && !pageTypes.Contains(doc.PageType))
                            {
                                doc.PageType = string.Empty;
                            }
                        }
                    }

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

                    var pageTypeColumn = (DataGridViewComboBoxColumn)dataGridViewDocuments.Columns["PageType"];
                    pageTypeColumn.Items.Clear();
                    pageTypeColumn.Items.AddRange(pageTypes.ToArray());

                    var fieldNameColumn = (DataGridViewComboBoxColumn)dataGridViewFields.Columns["FieldName"];
                    fieldNameColumn.Items.Clear();
                    fieldNameColumn.Items.AddRange(fieldNames.ToArray());

                    foreach (DataGridViewRow row in dataGridViewFields.Rows)
                    {
                        if (row.IsNewRow) continue;
                        var fieldName = row.Cells["FieldName"].Value?.ToString();
                        if (!string.IsNullOrEmpty(fieldName) && fieldNames.Contains(fieldName))
                        {
                            var fieldType = await _apiDatabaseService.GetFieldTypeAsync(fieldName);
                            row.Cells["FieldType"].Value = fieldType;
                        }
                        else
                        {
                            row.Cells["FieldType"].Value = string.Empty;
                        }
                    }

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
            statusLabel2.Text = "Group selection changed.";
            statusLabel2.ForeColor = Color.Blue;
            UpdateDocumentGrid();
        }

        private void dataGridViewGroups_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewGroups.Columns["Submit"].Index && e.RowIndex >= 0)
            {
                UpdateDocumentGrid();
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
                        int rowIndex = dataGridViewDocuments.Rows.Add(doc.FilePath, null);
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

        private async Task<bool> loginAsync(string appName, string appLogin, string appPassword)
        {
            try
            {
                _errorProvider.Clear();
                statusLabel2.Text = string.Empty;
                statusLabel2.ForeColor = SystemColors.ControlText;

                statusLabel2.Text = "Logging in...";
                statusLabel2.ForeColor = Color.Blue;

                if (string.IsNullOrEmpty(appName) || string.IsNullOrEmpty(appLogin) || string.IsNullOrEmpty(appPassword))
                {
                    statusLabel2.Text = "Configuration settings are missing.";
                    statusLabel2.ForeColor = Color.Red;
                    return await ShowLoginForm();
                }

                var token = await _viewModel.GetAuthTokenAsync(appName, appLogin, appPassword);

                statusLabel2.Text = "You're logged in!";
                statusLabel2.ForeColor = Color.Green;
                submitPanel.Visible = true;
                return true;
            }
            catch (Exception ex)
            {
                statusLabel2.Text = ex.Message.ToLower().Contains("unauthorized") || ex.Message.Contains("401")
                    ? "Unauthorized configuration settings."
                    : "Something went wrong. Please try again.";
                statusLabel2.ForeColor = Color.Red;
                return await ShowLoginForm();
            }
        }

        private async Task<bool> ShowLoginForm()
        {
            submitPanel.Visible = false;
            using (var loginForm = new LoginForm(_viewModel))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    statusLabel2.Text = "You're logged in!";
                    statusLabel2.ForeColor = Color.Green;
                    submitPanel.Visible = true;
                    return true;
                }
                else
                {
                    statusLabel2.Text = "Login failed. Please try again.";
                    statusLabel2.ForeColor = Color.Red;
                    submitPanel.Visible = false;
                    return false;
                }
            }
        }

        private void SubmitForm_Resize(object sender, EventArgs e)
        {
            tableLayout2.Width = metadataPanel.ClientSize.Width - tableLayout2.Margin.Horizontal;
            tableLayout2.Height = metadataPanel.ClientSize.Height - tableLayout2.Margin.Vertical;
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

                var checkedGroups = dataGridViewGroups.Rows.Cast<DataGridViewRow>()
                    .Where(row => (bool?)row.Cells["Submit"].Value == true)
                    .Select(row => row.Cells["GroupName"].Value.ToString())
                    .Where(group => _groups[group].Any())
                    .ToList();

                var requestGuids = new List<string>();

                foreach (string group in checkedGroups.ToList())
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
                        group,
                        documents);

                    requestGuids.Add(requestGuid);

                    statusLabel2.Text = $"Documents for {group} submitted! Request Guid: {requestGuid}";
                    statusLabel2.ForeColor = Color.Green;

                    _groups.Remove(group);
                    var rowToRemove = dataGridViewGroups.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(r => r.Cells["GroupName"].Value?.ToString() == group);
                    if (rowToRemove != null)
                    {
                        dataGridViewGroups.Rows.Remove(rowToRemove);
                    }
                }

                if (_groups.Count == 0)
                {
                    AddNewGroup();
                }
                else
                {
                    dataGridViewGroups.Rows[0].Selected = true;
                    UpdateDocumentGrid();
                }

                //// Auto-navigate to CheckStatusForm
                //if (requestGuids.Any())
                //{
                //    if (this.MdiParent is MainForm mainForm)
                //    {
                //        mainForm.OpenCheckStatusForm(requestGuids.ToArray());
                //    }
                //}
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("unauthorized") || ex.Message.Contains("401"))
                {
                    if (await ShowLoginForm())
                    {
                        btnSubmitDocument_Click(sender, e);
                    }
                }
                else
                {
                    statusLabel2.Text = $"Submission failed: {ex.Message}";
                    statusLabel2.ForeColor = Color.Red;
                }
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
                    AddNewGroup();
                }
                else
                {
                    dataGridViewGroups.Rows[0].Selected = true;
                    UpdateDocumentGrid();
                }
            }
        }

        private void btnRemoveField_Click(object sender, EventArgs e)
        {
            if (dataGridViewFields.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one row to remove.", "No Field Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewFields.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridViewFields.Rows.Remove(row);
                }
            }

            statusLabel2.Text = "Selected fields removed.";
            statusLabel2.ForeColor = Color.Green;
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

        private void DataGridViewDocuments_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDocuments.Columns["PageType"].Index)
            {
                dataGridViewDocuments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                e.Cancel = true;
            }
        }

        private void DataGridViewFields_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewFields.Columns["FieldName"].Index)
            {
                dataGridViewFields.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                dataGridViewFields.Rows[e.RowIndex].Cells["FieldType"].Value = string.Empty;
                e.Cancel = true;
            }
        }

        private async void dataGridViewFields_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (e.ColumnIndex == dataGridViewFields.Columns["FieldName"].Index)
            {
                var fieldName = dataGridViewFields.Rows[e.RowIndex].Cells["FieldName"].Value?.ToString();
                var batchClassName = cboBatchClassName.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(fieldName) && !string.IsNullOrEmpty(batchClassName))
                {
                    try
                    {
                        var fieldType = await _apiDatabaseService.GetFieldTypeAsync(fieldName);
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
                    dataGridViewFields.Rows[e.RowIndex].Cells["FieldType"].Value = string.Empty;
                }
            }
        }
    }
}