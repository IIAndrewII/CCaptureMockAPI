namespace CCaptureWinForm
{
    partial class SubmissionDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSubmissionDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblBatchClassName;
        private System.Windows.Forms.TextBox txtBatchClassName;
        private System.Windows.Forms.Label lblSourceSystem;
        private System.Windows.Forms.TextBox txtSourceSystem;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label lblSessionId;
        private System.Windows.Forms.TextBox txtSessionId;
        private System.Windows.Forms.Label lblMessageId;
        private System.Windows.Forms.TextBox txtMessageId;
        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.Label lblInteractionDateTime;
        private System.Windows.Forms.TextBox txtInteractionDateTime;
        private System.Windows.Forms.Label lblRequestGuid;
        private System.Windows.Forms.TextBox txtRequestGuid;
        private System.Windows.Forms.Label lblSubmittedAt;
        private System.Windows.Forms.TextBox txtSubmittedAt;
        private System.Windows.Forms.Label lblDocuments;
        private System.Windows.Forms.DataGridView dataGridViewDocuments;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.DataGridView dataGridViewFields;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblSubmissionDetails = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblGroupName = new System.Windows.Forms.Label();
            txtGroupName = new System.Windows.Forms.TextBox();
            lblBatchClassName = new System.Windows.Forms.Label();
            txtBatchClassName = new System.Windows.Forms.TextBox();
            lblSourceSystem = new System.Windows.Forms.Label();
            txtSourceSystem = new System.Windows.Forms.TextBox();
            lblChannel = new System.Windows.Forms.Label();
            txtChannel = new System.Windows.Forms.TextBox();
            lblSessionId = new System.Windows.Forms.Label();
            txtSessionId = new System.Windows.Forms.TextBox();
            lblMessageId = new System.Windows.Forms.Label();
            txtMessageId = new System.Windows.Forms.TextBox();
            lblUserCode = new System.Windows.Forms.Label();
            txtUserCode = new System.Windows.Forms.TextBox();
            lblInteractionDateTime = new System.Windows.Forms.Label();
            txtInteractionDateTime = new System.Windows.Forms.TextBox();
            lblRequestGuid = new System.Windows.Forms.Label();
            txtRequestGuid = new System.Windows.Forms.TextBox();
            lblSubmittedAt = new System.Windows.Forms.Label();
            txtSubmittedAt = new System.Windows.Forms.TextBox();
            lblDocuments = new System.Windows.Forms.Label();
            dataGridViewDocuments = new System.Windows.Forms.DataGridView();
            lblFields = new System.Windows.Forms.Label();
            dataGridViewFields = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewFields)).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblSubmissionDetails, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDocuments, 0, 2);
            tableLayoutPanel1.Controls.Add(dataGridViewDocuments, 0, 3);
            tableLayoutPanel1.Controls.Add(lblFields, 0, 4);
            tableLayoutPanel1.Controls.Add(dataGridViewFields, 0, 5);
            tableLayoutPanel1.Controls.Add(btnClose, 0, 6);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(800, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSubmissionDetails
            // 
            lblSubmissionDetails.AutoSize = true;
            lblSubmissionDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSubmissionDetails.Location = new System.Drawing.Point(3, 0);
            lblSubmissionDetails.Name = "lblSubmissionDetails";
            lblSubmissionDetails.Size = new System.Drawing.Size(137, 21);
            lblSubmissionDetails.TabIndex = 0;
            lblSubmissionDetails.Text = "Submission Details";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(lblGroupName, 0, 0);
            tableLayoutPanel2.Controls.Add(txtGroupName, 0, 1);
            tableLayoutPanel2.Controls.Add(lblBatchClassName, 1, 0);
            tableLayoutPanel2.Controls.Add(txtBatchClassName, 1, 1);
            tableLayoutPanel2.Controls.Add(lblSourceSystem, 2, 0);
            tableLayoutPanel2.Controls.Add(txtSourceSystem, 2, 1);
            tableLayoutPanel2.Controls.Add(lblChannel, 3, 0);
            tableLayoutPanel2.Controls.Add(txtChannel, 3, 1);
            tableLayoutPanel2.Controls.Add(lblSessionId, 0, 2);
            tableLayoutPanel2.Controls.Add(txtSessionId, 0, 3);
            tableLayoutPanel2.Controls.Add(lblMessageId, 1, 2);
            tableLayoutPanel2.Controls.Add(txtMessageId, 1, 3);
            tableLayoutPanel2.Controls.Add(lblUserCode, 2, 2);
            tableLayoutPanel2.Controls.Add(txtUserCode, 2, 3);
            tableLayoutPanel2.Controls.Add(lblInteractionDateTime, 3, 2);
            tableLayoutPanel2.Controls.Add(txtInteractionDateTime, 3, 3);
            tableLayoutPanel2.Controls.Add(lblRequestGuid, 0, 4);
            tableLayoutPanel2.Controls.Add(txtRequestGuid, 0, 5);
            tableLayoutPanel2.Controls.Add(lblSubmittedAt, 1, 4);
            tableLayoutPanel2.Controls.Add(txtSubmittedAt, 1, 5);
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.Size = new System.Drawing.Size(794, 264);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblGroupName
            // 
            lblGroupName.AutoSize = true;
            lblGroupName.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblGroupName.Location = new System.Drawing.Point(3, 0);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new System.Drawing.Size(81, 19);
            lblGroupName.TabIndex = 0;
            lblGroupName.Text = "Group Name:";
            // 
            // txtGroupName
            // 
            txtGroupName.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtGroupName.Location = new System.Drawing.Point(3, 47);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.ReadOnly = true;
            txtGroupName.Size = new System.Drawing.Size(192, 25);
            txtGroupName.TabIndex = 1;
            // 
            // lblBatchClassName
            // 
            lblBatchClassName.AutoSize = true;
            lblBatchClassName.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblBatchClassName.Location = new System.Drawing.Point(201, 0);
            lblBatchClassName.Name = "lblBatchClassName";
            lblBatchClassName.Size = new System.Drawing.Size(108, 19);
            lblBatchClassName.TabIndex = 2;
            lblBatchClassName.Text = "Batch Class Name:";
            // 
            // txtBatchClassName
            // 
            txtBatchClassName.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtBatchClassName.Location = new System.Drawing.Point(201, 47);
            txtBatchClassName.Name = "txtBatchClassName";
            txtBatchClassName.ReadOnly = true;
            txtBatchClassName.Size = new System.Drawing.Size(192, 25);
            txtBatchClassName.TabIndex = 3;
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSourceSystem.Location = new System.Drawing.Point(399, 0);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new System.Drawing.Size(97, 19);
            lblSourceSystem.TabIndex = 4;
            lblSourceSystem.Text = "Source System:";
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSourceSystem.Location = new System.Drawing.Point(399, 47);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.ReadOnly = true;
            txtSourceSystem.Size = new System.Drawing.Size(192, 25);
            txtSourceSystem.TabIndex = 5;
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblChannel.Location = new System.Drawing.Point(597, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new System.Drawing.Size(60, 19);
            lblChannel.TabIndex = 6;
            lblChannel.Text = "Channel:";
            // 
            // txtChannel
            // 
            txtChannel.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtChannel.Location = new System.Drawing.Point(597, 47);
            txtChannel.Name = "txtChannel";
            txtChannel.ReadOnly = true;
            txtChannel.Size = new System.Drawing.Size(192, 25);
            txtChannel.TabIndex = 7;
            // 
            // lblSessionId
            // 
            lblSessionId.AutoSize = true;
            lblSessionId.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSessionId.Location = new System.Drawing.Point(3, 88);
            lblSessionId.Name = "lblSessionId";
            lblSessionId.Size = new System.Drawing.Size(72, 19);
            lblSessionId.TabIndex = 8;
            lblSessionId.Text = "Session ID:";
            // 
            // txtSessionId
            // 
            txtSessionId.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSessionId.Location = new System.Drawing.Point(3, 135);
            txtSessionId.Name = "txtSessionId";
            txtSessionId.ReadOnly = true;
            txtSessionId.Size = new System.Drawing.Size(192, 25);
            txtSessionId.TabIndex = 9;
            // 
            // lblMessageId
            // 
            lblMessageId.AutoSize = true;
            lblMessageId.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblMessageId.Location = new System.Drawing.Point(201, 88);
            lblMessageId.Name = "lblMessageId";
            lblMessageId.Size = new System.Drawing.Size(78, 19);
            lblMessageId.TabIndex = 10;
            lblMessageId.Text = "Message ID:";
            // 
            // txtMessageId
            // 
            txtMessageId.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtMessageId.Location = new System.Drawing.Point(201, 135);
            txtMessageId.Name = "txtMessageId";
            txtMessageId.ReadOnly = true;
            txtMessageId.Size = new System.Drawing.Size(192, 25);
            txtMessageId.TabIndex = 11;
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblUserCode.Location = new System.Drawing.Point(399, 88);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new System.Drawing.Size(55, 19);
            lblUserCode.TabIndex = 12;
            lblUserCode.Text = "User ID:";
            // 
            // txtUserCode
            // 
            txtUserCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtUserCode.Location = new System.Drawing.Point(399, 135);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.ReadOnly = true;
            txtUserCode.Size = new System.Drawing.Size(192, 25);
            txtUserCode.TabIndex = 13;
            // 
            // lblInteractionDateTime
            // 
            lblInteractionDateTime.AutoSize = true;
            lblInteractionDateTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblInteractionDateTime.Location = new System.Drawing.Point(597, 88);
            lblInteractionDateTime.Name = "lblInteractionDateTime";
            lblInteractionDateTime.Size = new System.Drawing.Size(134, 19);
            lblInteractionDateTime.TabIndex = 14;
            lblInteractionDateTime.Text = "Interaction Date Time:";
            // 
            // txtInteractionDateTime
            // 
            txtInteractionDateTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtInteractionDateTime.Location = new System.Drawing.Point(597, 135);
            txtInteractionDateTime.Name = "txtInteractionDateTime";
            txtInteractionDateTime.ReadOnly = true;
            txtInteractionDateTime.Size = new System.Drawing.Size(192, 25);
            txtInteractionDateTime.TabIndex = 15;
            // 
            // lblRequestGuid
            // 
            lblRequestGuid.AutoSize = true;
            lblRequestGuid.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblRequestGuid.Location = new System.Drawing.Point(3, 176);
            lblRequestGuid.Name = "lblRequestGuid";
            lblRequestGuid.Size = new System.Drawing.Size(95, 19);
            lblRequestGuid.TabIndex = 16;
            lblRequestGuid.Text = "Request GUID:";
            // 
            // txtRequestGuid
            // 
            txtRequestGuid.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtRequestGuid.Location = new System.Drawing.Point(3, 223);
            txtRequestGuid.Name = "txtRequestGuid";
            txtRequestGuid.ReadOnly = true;
            txtRequestGuid.Size = new System.Drawing.Size(192, 25);
            txtRequestGuid.TabIndex = 17;
            // 
            // lblSubmittedAt
            // 
            lblSubmittedAt.AutoSize = true;
            lblSubmittedAt.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSubmittedAt.Location = new System.Drawing.Point(201, 176);
            lblSubmittedAt.Name = "lblSubmittedAt";
            lblSubmittedAt.Size = new System.Drawing.Size(83, 19);
            lblSubmittedAt.TabIndex = 18;
            lblSubmittedAt.Text = "Submitted At:";
            // 
            // txtSubmittedAt
            // 
            txtSubmittedAt.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSubmittedAt.Location = new System.Drawing.Point(201, 223);
            txtSubmittedAt.Name = "txtSubmittedAt";
            txtSubmittedAt.ReadOnly = true;
            txtSubmittedAt.Size = new System.Drawing.Size(192, 25);
            txtSubmittedAt.TabIndex = 19;
            // 
            // lblDocuments
            // 
            lblDocuments.AutoSize = true;
            lblDocuments.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblDocuments.Location = new System.Drawing.Point(3, 297);
            lblDocuments.Name = "lblDocuments";
            lblDocuments.Size = new System.Drawing.Size(83, 21);
            lblDocuments.TabIndex = 2;
            lblDocuments.Text = "Documents";
            // 
            // dataGridViewDocuments
            // 
            dataGridViewDocuments.AllowUserToAddRows = false;
            dataGridViewDocuments.AllowUserToDeleteRows = false;
            dataGridViewDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocuments.Columns.Add("FileName", "File Name");
            dataGridViewDocuments.Columns.Add("PageType", "Page Type");
            dataGridViewDocuments.Columns.Add("FilePath", "File Path");
            dataGridViewDocuments.Columns.Add("CreatedAt", "Created At");
            dataGridViewDocuments.Location = new System.Drawing.Point(3, 321);
            dataGridViewDocuments.Name = "dataGridViewDocuments";
            dataGridViewDocuments.ReadOnly = true;
            dataGridViewDocuments.RowHeadersWidth = 51;
            dataGridViewDocuments.Size = new System.Drawing.Size(794, 92);
            dataGridViewDocuments.TabIndex = 3;
            // 
            // lblFields
            // 
            lblFields.AutoSize = true;
            lblFields.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblFields.Location = new System.Drawing.Point(3, 413);
            lblFields.Name = "lblFields";
            lblFields.Size = new System.Drawing.Size(50, 21);
            lblFields.TabIndex = 4;
            lblFields.Text = "Fields";
            // 
            // dataGridViewFields
            // 
            dataGridViewFields.AllowUserToAddRows = false;
            dataGridViewFields.AllowUserToDeleteRows = false;
            dataGridViewFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFields.Columns.Add("FieldName", "Field Name");
            dataGridViewFields.Columns.Add("FieldValue", "Field Value");
            dataGridViewFields.Columns.Add("FieldType", "Field Type");
            dataGridViewFields.Columns.Add("CreatedAt", "Created At");
            dataGridViewFields.Location = new System.Drawing.Point(3, 437);
            dataGridViewFields.Name = "dataGridViewFields";
            dataGridViewFields.ReadOnly = true;
            dataGridViewFields.RowHeadersWidth = 51;
            dataGridViewFields.Size = new System.Drawing.Size(794, 110);
            dataGridViewFields.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(649, 553);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(148, 44);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += new System.EventHandler(btnClose_Click);
            // 
            // SubmissionDetailsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SubmissionDetailsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Submission Details";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewFields)).EndInit();
            ResumeLayout(false);
        }
    }
}