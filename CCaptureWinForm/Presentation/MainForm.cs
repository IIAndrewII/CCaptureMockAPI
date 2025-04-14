using CCaptureWinForm.Core.Entities;
using CCaptureWinForm.Infrastructure.Services;
using CCaptureWinForm.Presentation;
using CCaptureWinForm.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public MainForm()
        {

            InitializeComponent();
            _errorProvider = new ErrorProvider(this) { BlinkStyle = ErrorBlinkStyle.NeverBlink };
            var fileService = new FileService();
            var apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            var apiService = new ApiService("https://localhost:7059");
            _viewModel = new MainViewModel(apiService, fileService);

            // Attach event handlers
            btnGetToken.Click += btnGetToken_Click;
            chkShowPassword.CheckedChanged += (s, e) => txtAppPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            btnBrowseFile.Click += btnBrowseFile_Click;
            btnRemoveFile.Click += btnRemoveFile_Click;
            btnSubmitDocument.Click += btnSubmitDocument_Click;
            btnCheckStatus.Click += btnCheckStatus_Click;
            btnClearResults.Click += btnClearResults_Click;

            BackColor = Color.FromArgb(245, 245, 245);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = true;
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

        private async void btnGetToken_Click(object sender, EventArgs e)
        {
            try
            {
                _errorProvider.Clear();
                if (string.IsNullOrWhiteSpace(txtAppName.Text))
                    _errorProvider.SetError(txtAppName, "Application name is required.");
                if (string.IsNullOrWhiteSpace(txtAppLogin.Text))
                    _errorProvider.SetError(txtAppLogin, "Application login is required.");
                if (string.IsNullOrWhiteSpace(txtAppPassword.Text))
                    _errorProvider.SetError(txtAppPassword, "Application password is required.");

                if (_errorProvider.GetError(txtAppName) != "" ||
                    _errorProvider.GetError(txtAppLogin) != "" ||
                    _errorProvider.GetError(txtAppPassword) != "")
                {
                    statusLabel1.Text = "Please correct the errors.";
                    statusLabel1.ForeColor = Color.Red;
                    return;
                }

                btnGetToken.Enabled = false;
                statusLabel1.Text = "Authenticating...";
                statusLabel1.ForeColor = Color.Blue;

                var token = await _viewModel.GetAuthTokenAsync(
                    txtAppName.Text,
                    txtAppLogin.Text,
                    txtAppPassword.Text);

                statusLabel1.Text = "Authentication successful!";
                statusLabel1.ForeColor = Color.Green;
                tabControl1.SelectedTab = tabPage2;
            }
            catch (Exception ex)
            {
                statusLabel1.Text = $"Error: {ex.Message}";
                statusLabel1.ForeColor = Color.Red;
            }
            finally
            {
                btnGetToken.Enabled = true;
            }
        }

        private async void btnSubmitDocument_Click(object sender, EventArgs e)
        {
            try
            {
                _errorProvider.Clear();
                if (string.IsNullOrWhiteSpace(txtBatchClassName.Text))
                    _errorProvider.SetError(txtBatchClassName, "Batch category is required.");
                if (string.IsNullOrWhiteSpace(txtSourceSystem.Text))
                    _errorProvider.SetError(txtSourceSystem, "Source system is required.");
                if (string.IsNullOrWhiteSpace(txtChannel.Text))
                    _errorProvider.SetError(txtChannel, "Channel is required.");
                if (string.IsNullOrWhiteSpace(txtSessionID.Text))
                    _errorProvider.SetError(txtSessionID, "Session ID is required.");
                if (string.IsNullOrWhiteSpace(txtMessageID.Text))
                    _errorProvider.SetError(txtMessageID, "Message ID is required.");
                if (string.IsNullOrWhiteSpace(txtUserCode.Text))
                    _errorProvider.SetError(txtUserCode, "User ID is required.");
                if (dataGridViewDocuments.RowCount == 1)
                    _errorProvider.SetError(dataGridViewDocuments, "At least one document is required.");

                if (_errorProvider.GetError(txtBatchClassName) != "" ||
                    _errorProvider.GetError(txtSourceSystem) != "" ||
                    _errorProvider.GetError(txtChannel) != "" ||
                    _errorProvider.GetError(txtSessionID) != "" ||
                    _errorProvider.GetError(txtMessageID) != "" ||
                    _errorProvider.GetError(txtUserCode) != "" ||
                    _errorProvider.GetError(dataGridViewDocuments) != "")
                {
                    statusLabel2.Text = "Please correct the errors.";
                    statusLabel2.ForeColor = Color.Red;
                    return;
                }

                statusLabel2.Text = "Submitting...";
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

                statusLabel2.Text = $"Document submitted successfully! Request ID: {requestGuid}";
                statusLabel2.ForeColor = Color.Green;
                txtStatusRequestGuid.Text = requestGuid;
                txtStatusSourceSystem.Text = txtSourceSystem.Text;
                txtStatusChannel.Text = txtChannel.Text;
                txtStatusSessionID.Text = txtSessionID.Text;
                txtStatusMessageID.Text = txtMessageID.Text;
                txtStatusUserCode.Text = txtUserCode.Text;
                tabControl1.SelectedTab = tabPage3;
            }
            catch (Exception ex)
            {
                statusLabel2.Text = $"Error: {ex.Message}";
                statusLabel2.ForeColor = Color.Red;
            }
        }

        private async void btnCheckStatus_Click(object sender, EventArgs e)
        {
            try
            {
                _errorProvider.Clear();
                if (string.IsNullOrWhiteSpace(txtStatusRequestGuid.Text))
                    _errorProvider.SetError(txtStatusRequestGuid, "Request ID is required.");
                if (string.IsNullOrWhiteSpace(txtStatusSourceSystem.Text))
                    _errorProvider.SetError(txtStatusSourceSystem, "Source system is required.");
                if (string.IsNullOrWhiteSpace(txtStatusChannel.Text))
                    _errorProvider.SetError(txtStatusChannel, "Channel is required.");
                if (string.IsNullOrWhiteSpace(txtStatusSessionID.Text))
                    _errorProvider.SetError(txtStatusSessionID, "Session ID is required.");
                if (string.IsNullOrWhiteSpace(txtStatusMessageID.Text))
                    _errorProvider.SetError(txtStatusMessageID, "Message ID is required.");
                if (string.IsNullOrWhiteSpace(txtStatusUserCode.Text))
                    _errorProvider.SetError(txtStatusUserCode, "User ID is required.");

                if (_errorProvider.GetError(txtStatusRequestGuid) != "" ||
                    _errorProvider.GetError(txtStatusSourceSystem) != "" ||
                    _errorProvider.GetError(txtStatusChannel) != "" ||
                    _errorProvider.GetError(txtStatusSessionID) != "" ||
                    _errorProvider.GetError(txtStatusMessageID) != "" ||
                    _errorProvider.GetError(txtStatusUserCode) != "")
                {
                    statusLabel3.Text = "Please correct the errors.";
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

                statusLabel3.Text = "Status retrieved successfully!";
                statusLabel3.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                statusLabel3.Text = $"Error: {ex.Message}";
                statusLabel3.ForeColor = Color.Red;
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
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Select PDF Files"
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