using CCaptureWinForm.Data;
using CCaptureWinForm.Presentation.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CCaptureWinForm
{
    public partial class SubmissionDetailsForm : Form
    {
        private ContextMenuStrip documentContextMenu;

        public SubmissionDetailsForm(SubmissionDetails details)
        {
            InitializeComponent();
            PopulateDetails(details);
            // Register the double-click event handler
            dataGridViewDocuments.CellDoubleClick += DataGridViewDocuments_CellDoubleClick;
            // Initialize context menu
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            documentContextMenu = new ContextMenuStrip();
            var viewDocumentItem = new ToolStripMenuItem("View Document", null, ViewDocument_Click);
            documentContextMenu.Items.Add(viewDocumentItem);
            dataGridViewDocuments.ContextMenuStrip = documentContextMenu;
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

        private void DataGridViewDocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                OpenDocument(e.RowIndex);
            }
        }

        private void ViewDocument_Click(object sender, EventArgs e)
        {
            // Get the row under the mouse when the context menu was opened
            var point = dataGridViewDocuments.PointToClient(Control.MousePosition);
            var hitTest = dataGridViewDocuments.HitTest(point.X, point.Y);
            if (hitTest.RowIndex >= 0)
            {
                OpenDocument(hitTest.RowIndex);
            }
        }

        private void OpenDocument(int rowIndex)
        {
            string filePath = dataGridViewDocuments.Rows[rowIndex].Cells[2].Value?.ToString();

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("No file path specified for this document.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (File.Exists(filePath))
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show($"The file '{filePath}' does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed/kube to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}