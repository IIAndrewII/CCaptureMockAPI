using CCaptureWinForm.Data;
using CCaptureWinForm.Presentation.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CCaptureWinForm
{
    public partial class SubmissionDetailsForm : Form
    {
        public SubmissionDetailsForm(SubmissionDetails details)
        {
            InitializeComponent();
            PopulateDetails(details);
        }

        private void PopulateDetails(SubmissionDetails details)
        {
            if (details == null)
            {
                MessageBox.Show("No submission details found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Submission Details
            txtGroupName.Text = details.GroupName;
            txtBatchClassName.Text = details.Submission.BatchClassName;
            txtSourceSystem.Text = details.Submission.SourceSystem;
            txtChannel.Text = details.Submission.Channel;
            txtSessionId.Text = details.Submission.SessionId;
            txtMessageId.Text = details.Submission.MessageId;
            txtUserCode.Text = details.Submission.UserCode;
            txtInteractionDateTime.Text = details.Submission.InteractionDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            txtRequestGuid.Text = details.Submission.RequestGuid;
            txtSubmittedAt.Text = details.Submission.SubmittedAt?.ToString("yyyy-MM-dd HH:mm:ss");

            // Documents
            dataGridViewDocuments.Rows.Clear();
            foreach (var doc in details.Documents)
            {
                dataGridViewDocuments.Rows.Add(
                    doc.FileName,
                    doc.PageType,
                    doc.FilePath,
                    doc.CreatedAt?.ToString("yyyy-MM-dd HH:mm:ss")
                );
            }

            // Fields
            dataGridViewFields.Rows.Clear();
            foreach (var field in details.Fields)
            {
                dataGridViewFields.Rows.Add(
                    field.FieldName,
                    field.FieldValue,
                    field.FieldType,
                    field.CreatedAt?.ToString("yyyy-MM-dd HH:mm:ss")
                );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}