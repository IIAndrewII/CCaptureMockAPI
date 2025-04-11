using CCaptureWinForm.Infrastructure.Services;
using CCaptureWinForm.Presentation.ViewModels;
using System;
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
                //if (string.IsNullOrWhiteSpace(txtFilePath.Text) ||
                //    string.IsNullOrWhiteSpace(txtBatchClassName.Text) ||
                //    string.IsNullOrWhiteSpace(txtPageType.Text) ||
                //    string.IsNullOrWhiteSpace(txtSourceSystem.Text) ||
                //    string.IsNullOrWhiteSpace(txtChannel.Text) ||
                //    string.IsNullOrWhiteSpace(txtSessionID.Text) ||
                //    string.IsNullOrWhiteSpace(txtMessageID.Text) ||
                //    string.IsNullOrWhiteSpace(txtUserCode.Text))
                //{
                //    lblDocumentStatus.Text = "Error: All fields are required.";
                //    lblDocumentStatus.ForeColor = System.Drawing.Color.Red;
                //    return;
                //}


                // Collect data from DataGridView
                var fields = new List<CCaptureWinForm.Core.Entities.Field>();
                foreach (DataGridViewRow row in dataGridViewFields.Rows)
                {
                    if (row.IsNewRow) continue;
                    var key = row.Cells["FieldName"].Value?.ToString();
                    var value = row.Cells["FieldValue"].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(key) && !string.IsNullOrWhiteSpace(value))
                    {
                        fields.Add(new CCaptureWinForm.Core.Entities.Field
                        {
                            FieldName = key,
                            FieldValue = value
                        });
                    }
                }

                // Pass the fields to the SubmitDocumentAsync method
                var requestGuid = await _viewModel.SubmitDocumentAsync(
                    txtFilePath.Text,
                    txtBatchClassName.Text,
                    txtPageType.Text,
                    txtSourceSystem.Text,
                    txtChannel.Text,
                    txtSessionID.Text,
                    txtMessageID.Text,
                    txtUserCode.Text,
                    fields);

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
                var result = await _viewModel.CheckVerificationStatusAsync(
                    txtStatusRequestGuid.Text,
                    txtStatusSourceSystem.Text,
                    txtStatusChannel.Text,
                    txtStatusSessionID.Text,
                    txtStatusMessageID.Text,
                    txtStatusUserCode.Text);

                txtStatusResult.Text = result;
            }
            catch (Exception ex)
            {
                txtStatusResult.Text = $"Error: {ex.Message}";
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void dataGridViewFields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStatusRequestGuid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}