using CCaptureWinForm.Core.Entities;
using CCaptureWinForm.Infrastructure.Services;
using CCaptureWinForm.Presentation.ViewModels;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCaptureWinForm
{
    public partial class MainForm : Form
    {
        private readonly MainViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();

            var apiService = new ApiService("https://localhost:7059");
            var fileService = new FileService();
            _viewModel = new MainViewModel(apiService, fileService);
        }

        private async void btnGetToken_Click(object sender, EventArgs e)
        {
            try
            {
                var token = await _viewModel.GetAuthTokenAsync(
                    txtAppName.Text,
                    txtAppLogin.Text,
                    txtAppPassword.Text);

                lblTokenStatus.Text = "Token obtained successfully!";
                lblTokenStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblTokenStatus.Text = $"Error: {ex.Message}";
                lblTokenStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private async void btnSubmitDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDocuments.RowCount == 0 ||
                    string.IsNullOrWhiteSpace(txtBatchClassName.Text) ||
                    string.IsNullOrWhiteSpace(txtSourceSystem.Text) ||
                    string.IsNullOrWhiteSpace(txtChannel.Text) ||
                    string.IsNullOrWhiteSpace(txtSessionID.Text) ||
                    string.IsNullOrWhiteSpace(txtMessageID.Text) ||
                    string.IsNullOrWhiteSpace(txtUserCode.Text))
                {
                    lblDocumentStatus.Text = "Error: All fields are required.";
                    lblDocumentStatus.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                lblDocumentStatus.Text = $"Loading...";
                lblDocumentStatus.ForeColor = System.Drawing.Color.Blue;


                // Collect data from DataGridViewFields
                var fields = new List<Field>();
                foreach (DataGridViewRow row in dataGridViewFields.Rows)
                {
                    if (row.IsNewRow) continue;
                    var key = row.Cells["FieldName"].Value?.ToString();
                    var value = row.Cells["FieldValue"].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(key) && !string.IsNullOrWhiteSpace(value))
                    {
                        fields.Add(new Field
                        {
                            FieldName = key,
                            FieldValue = value
                        });
                    }
                }

                // Collect data from DataGridViewDocuments
                var documents = new List<Document_Row>();
                foreach (DataGridViewRow row in dataGridViewDocuments.Rows)
                {
                    if (row.IsNewRow) continue;
                    var key = row.Cells["FilePath"].Value?.ToString();
                    var value = row.Cells["PageType"].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(key))
                    {
                        documents.Add(new Document_Row
                        {
                            FilePath = key,
                            PageType = value
                        });
                    }
                }

                // Pass the fields to the SubmitDocumentAsync method
                var requestGuid = await _viewModel.SubmitDocumentAsync(
                    txtBatchClassName.Text,
                    txtSourceSystem.Text,
                    txtChannel.Text,
                    txtSessionID.Text,
                    txtMessageID.Text,
                    txtUserCode.Text,
                    fields,
                    documents);

                lblDocumentStatus.Text = $"Document submitted successfully! Request GUID: {requestGuid}";
                lblDocumentStatus.ForeColor = System.Drawing.Color.Green;
                txtStatusRequestGuid.Text = requestGuid;
            }
            catch (Exception ex)
            {
                lblDocumentStatus.Text = $"Error: {ex.Message}";
                lblDocumentStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private async void btnCheckStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStatusRequestGuid.Text) ||
                    string.IsNullOrWhiteSpace(txtStatusSourceSystem.Text) ||
                    string.IsNullOrWhiteSpace(txtStatusChannel.Text) ||
                    string.IsNullOrWhiteSpace(txtStatusSessionID.Text) ||
                    string.IsNullOrWhiteSpace(txtStatusMessageID.Text) ||
                    string.IsNullOrWhiteSpace(txtStatusUserCode.Text))
                {
                    lblReadStatus.Text = "Error: All fields are required.";
                    lblReadStatus.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                lblReadStatus.Text = $"Loading...";
                lblReadStatus.ForeColor = System.Drawing.Color.Blue;

                var result = await _viewModel.CheckVerificationStatusAsync(
                    txtStatusRequestGuid.Text,
                    txtStatusSourceSystem.Text,
                    txtStatusChannel.Text,
                    txtStatusSessionID.Text,
                    txtStatusMessageID.Text,
                    txtStatusUserCode.Text);

                txtStatusResult.Text = result;

                // Show in the new viewer instead of raw text box
                var statusForm = new VerificationStatusForm(result);
                statusForm.ShowDialog();

                lblReadStatus.Text = $"Done successfully!";
                lblReadStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                txtStatusResult.Text = $"Error: {ex.Message}";
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                //Filter = "All Files (*.*)|*.*",
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Select PDF Files"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var filePath in openFileDialog.FileNames)
                {
                    // Add each file path to the DataGridView with an empty Page Type
                    dataGridViewDocuments.Rows.Add(filePath, string.Empty);
                }
            }
        }

        private void dataGridViewFields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStatusRequestGuid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStatusResult_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class VerificationStatusForm : Form
    {
        private readonly string _jsonResponse;
        private TreeView _treeView;
        private Button _btnClose;
        private Button _btnExport;

        public VerificationStatusForm(string jsonResponse)
        {
            _jsonResponse = jsonResponse;
            InitializeComponents();
            PopulateTreeView();
            this.Text = "Document Verification Details";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void InitializeComponents()
        {
            _treeView = new TreeView
            {
                Dock = DockStyle.Fill,
                CheckBoxes = false,
                FullRowSelect = true,
                ShowPlusMinus = true,
                ShowRootLines = true,
                HideSelection = false
            };

            _btnClose = new Button
            {
                Text = "Close",
                Dock = DockStyle.Bottom,
                Height = 40
            };
            _btnClose.Click += (s, e) => this.Close();

            _btnExport = new Button
            {
                Text = "Export to JSON",
                Dock = DockStyle.Bottom,
                Height = 40
            };
            _btnExport.Click += (s, e) => ExportToJson();

            this.Controls.Add(_treeView);
            this.Controls.Add(_btnExport);
            this.Controls.Add(_btnClose);
        }

        private void PopulateTreeView()
        {
            try
            {
                var jsonDocument = JsonDocument.Parse(_jsonResponse);
                var rootNode = _treeView.Nodes.Add("Verification Results");

                // Add Batch 
                var batchNode = rootNode.Nodes.Add("Batch Information");
                AddBatchDetails(batchNode, jsonDocument.RootElement.GetProperty("Batch"));

                // Add Status 
                rootNode.Nodes.Add($"Status: {jsonDocument.RootElement.GetProperty("Status").GetInt32()}");

                // Add Execution Date
                rootNode.Nodes.Add($"Execution Date: {jsonDocument.RootElement.GetProperty("ExecutionDate").GetString()}");

                // Expand the first level
                rootNode.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing response: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBatchDetails(TreeNode parentNode, JsonElement batchElement)
        {
            // Basic batch info
            parentNode.Nodes.Add($"ID: {batchElement.GetProperty("Id").GetInt32()}");
            parentNode.Nodes.Add($"Name: {batchElement.GetProperty("Name").GetString()}");
            parentNode.Nodes.Add($"Creation Date: {batchElement.GetProperty("CreationDate").GetString()}");
            parentNode.Nodes.Add($"Close Date: {batchElement.GetProperty("CloseDate").GetString()}");

            // Batch Class
            var batchClassNode = parentNode.Nodes.Add("Batch Class");
            batchClassNode.Nodes.Add($"Name: {batchElement.GetProperty("BatchClass").GetProperty("Name").GetString()}");

            // Batch Fields
            var fieldsNode = parentNode.Nodes.Add("Batch Fields");
            foreach (var field in batchElement.GetProperty("BatchFields").EnumerateArray())
            {
                fieldsNode.Nodes.Add($"{field.GetProperty("Name").GetString()}: {field.GetProperty("Value").GetString()} " +
                                   $"(Confidence: {field.GetProperty("Confidence").GetDouble():P0})");
            }

            // Documents
            var documentsNode = parentNode.Nodes.Add("Documents");
            foreach (var doc in batchElement.GetProperty("Documents").EnumerateArray())
            {
                var docNode = documentsNode.Nodes.Add($"Document: {doc.GetProperty("Name").GetString()}");
                docNode.Nodes.Add($"Class: {doc.GetProperty("DocumentClass").GetProperty("Name").GetString()}");

                // Pages
                var pagesNode = docNode.Nodes.Add("Pages");
                foreach (var page in doc.GetProperty("Pages").EnumerateArray())
                {
                    var pageNode = pagesNode.Nodes.Add($"Page: {page.GetProperty("FileName").GetString()}");

                    // Page Types
                    var typesNode = pageNode.Nodes.Add("Page Types");
                    foreach (var type in page.GetProperty("PageTypes").EnumerateArray())
                    {
                        typesNode.Nodes.Add($"{type.GetProperty("Name").GetString()} " +
                                          $"(Confidence: {type.GetProperty("Confidence").GetDouble():P1})");
                    }
                }
            }

            // Batch States
            var statesNode = parentNode.Nodes.Add("Processing States");
            foreach (var state in batchElement.GetProperty("BatchStates").EnumerateArray())
            {
                statesNode.Nodes.Add($"{state.GetProperty("Value").GetString()} at " +
                                   $"{state.GetProperty("TrackDate").GetString()} " +
                                   $"(Workstation: {state.GetProperty("Workstation").GetString()})");
            }
        }

        private void ExportToJson()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                Title = "Save verification results"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, _jsonResponse);
                MessageBox.Show("Results exported successfully!", "Export Complete",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}