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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblSubmissionDetails = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblGroupName = new Label();
            txtGroupName = new TextBox();
            lblBatchClassName = new Label();
            txtBatchClassName = new TextBox();
            lblSourceSystem = new Label();
            txtSourceSystem = new TextBox();
            lblChannel = new Label();
            txtChannel = new TextBox();
            lblSessionId = new Label();
            txtSessionId = new TextBox();
            lblMessageId = new Label();
            txtMessageId = new TextBox();
            lblUserCode = new Label();
            txtUserCode = new TextBox();
            lblInteractionDateTime = new Label();
            txtInteractionDateTime = new TextBox();
            lblRequestGuid = new Label();
            txtRequestGuid = new TextBox();
            lblSubmittedAt = new Label();
            txtSubmittedAt = new TextBox();
            lblDocuments = new Label();
            dataGridViewDocuments = new DataGridView();
            lblFields = new Label();
            dataGridViewFields = new DataGridView();
            btnClose = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblSubmissionDetails, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDocuments, 0, 2);
            tableLayoutPanel1.Controls.Add(dataGridViewDocuments, 0, 3);
            tableLayoutPanel1.Controls.Add(lblFields, 0, 4);
            tableLayoutPanel1.Controls.Add(dataGridViewFields, 0, 5);
            tableLayoutPanel1.Controls.Add(btnClose, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 284F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(800, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSubmissionDetails
            // 
            lblSubmissionDetails.AutoSize = true;
            lblSubmissionDetails.Font = new Font("Segoe UI", 12F);
            lblSubmissionDetails.Location = new Point(3, 0);
            lblSubmissionDetails.Name = "lblSubmissionDetails";
            lblSubmissionDetails.Size = new Size(142, 21);
            lblSubmissionDetails.TabIndex = 0;
            lblSubmissionDetails.Text = "Submission Details";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
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
            tableLayoutPanel2.Location = new Point(3, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.Size = new Size(794, 264);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblGroupName
            // 
            lblGroupName.AutoSize = true;
            lblGroupName.Font = new Font("Segoe UI", 10F);
            lblGroupName.Location = new Point(3, 0);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new Size(91, 19);
            lblGroupName.TabIndex = 0;
            lblGroupName.Text = "Group Name:";
            // 
            // txtGroupName
            // 
            txtGroupName.Font = new Font("Segoe UI", 10F);
            txtGroupName.Location = new Point(3, 47);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.ReadOnly = true;
            txtGroupName.Size = new Size(192, 25);
            txtGroupName.TabIndex = 1;
            // 
            // lblBatchClassName
            // 
            lblBatchClassName.AutoSize = true;
            lblBatchClassName.Font = new Font("Segoe UI", 10F);
            lblBatchClassName.Location = new Point(201, 0);
            lblBatchClassName.Name = "lblBatchClassName";
            lblBatchClassName.Size = new Size(121, 19);
            lblBatchClassName.TabIndex = 2;
            lblBatchClassName.Text = "Batch Class Name:";
            // 
            // txtBatchClassName
            // 
            txtBatchClassName.Font = new Font("Segoe UI", 10F);
            txtBatchClassName.Location = new Point(201, 47);
            txtBatchClassName.Name = "txtBatchClassName";
            txtBatchClassName.ReadOnly = true;
            txtBatchClassName.Size = new Size(192, 25);
            txtBatchClassName.TabIndex = 3;
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new Font("Segoe UI", 10F);
            lblSourceSystem.Location = new Point(399, 0);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new Size(101, 19);
            lblSourceSystem.TabIndex = 4;
            lblSourceSystem.Text = "Source System:";
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.Font = new Font("Segoe UI", 10F);
            txtSourceSystem.Location = new Point(399, 47);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.ReadOnly = true;
            txtSourceSystem.Size = new Size(192, 25);
            txtSourceSystem.TabIndex = 5;
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Font = new Font("Segoe UI", 10F);
            lblChannel.Location = new Point(597, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(62, 19);
            lblChannel.TabIndex = 6;
            lblChannel.Text = "Channel:";
            // 
            // txtChannel
            // 
            txtChannel.Font = new Font("Segoe UI", 10F);
            txtChannel.Location = new Point(597, 47);
            txtChannel.Name = "txtChannel";
            txtChannel.ReadOnly = true;
            txtChannel.Size = new Size(192, 25);
            txtChannel.TabIndex = 7;
            // 
            // lblSessionId
            // 
            lblSessionId.AutoSize = true;
            lblSessionId.Font = new Font("Segoe UI", 10F);
            lblSessionId.Location = new Point(3, 88);
            lblSessionId.Name = "lblSessionId";
            lblSessionId.Size = new Size(75, 19);
            lblSessionId.TabIndex = 8;
            lblSessionId.Text = "Session ID:";
            // 
            // txtSessionId
            // 
            txtSessionId.Font = new Font("Segoe UI", 10F);
            txtSessionId.Location = new Point(3, 135);
            txtSessionId.Name = "txtSessionId";
            txtSessionId.ReadOnly = true;
            txtSessionId.Size = new Size(192, 25);
            txtSessionId.TabIndex = 9;
            // 
            // lblMessageId
            // 
            lblMessageId.AutoSize = true;
            lblMessageId.Font = new Font("Segoe UI", 10F);
            lblMessageId.Location = new Point(201, 88);
            lblMessageId.Name = "lblMessageId";
            lblMessageId.Size = new Size(84, 19);
            lblMessageId.TabIndex = 10;
            lblMessageId.Text = "Message ID:";
            // 
            // txtMessageId
            // 
            txtMessageId.Font = new Font("Segoe UI", 10F);
            txtMessageId.Location = new Point(201, 135);
            txtMessageId.Name = "txtMessageId";
            txtMessageId.ReadOnly = true;
            txtMessageId.Size = new Size(192, 25);
            txtMessageId.TabIndex = 11;
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new Font("Segoe UI", 10F);
            lblUserCode.Location = new Point(399, 88);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new Size(58, 19);
            lblUserCode.TabIndex = 12;
            lblUserCode.Text = "User ID:";
            // 
            // txtUserCode
            // 
            txtUserCode.Font = new Font("Segoe UI", 10F);
            txtUserCode.Location = new Point(399, 135);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.ReadOnly = true;
            txtUserCode.Size = new Size(192, 25);
            txtUserCode.TabIndex = 13;
            // 
            // lblInteractionDateTime
            // 
            lblInteractionDateTime.AutoSize = true;
            lblInteractionDateTime.Font = new Font("Segoe UI", 10F);
            lblInteractionDateTime.Location = new Point(597, 88);
            lblInteractionDateTime.Name = "lblInteractionDateTime";
            lblInteractionDateTime.Size = new Size(144, 19);
            lblInteractionDateTime.TabIndex = 14;
            lblInteractionDateTime.Text = "Interaction Date Time:";
            // 
            // txtInteractionDateTime
            // 
            txtInteractionDateTime.Font = new Font("Segoe UI", 10F);
            txtInteractionDateTime.Location = new Point(597, 135);
            txtInteractionDateTime.Name = "txtInteractionDateTime";
            txtInteractionDateTime.ReadOnly = true;
            txtInteractionDateTime.Size = new Size(192, 25);
            txtInteractionDateTime.TabIndex = 15;
            // 
            // lblRequestGuid
            // 
            lblRequestGuid.AutoSize = true;
            lblRequestGuid.Font = new Font("Segoe UI", 10F);
            lblRequestGuid.Location = new Point(3, 176);
            lblRequestGuid.Name = "lblRequestGuid";
            lblRequestGuid.Size = new Size(99, 19);
            lblRequestGuid.TabIndex = 16;
            lblRequestGuid.Text = "Request GUID:";
            // 
            // txtRequestGuid
            // 
            txtRequestGuid.Font = new Font("Segoe UI", 10F);
            txtRequestGuid.Location = new Point(3, 223);
            txtRequestGuid.Name = "txtRequestGuid";
            txtRequestGuid.ReadOnly = true;
            txtRequestGuid.Size = new Size(192, 25);
            txtRequestGuid.TabIndex = 17;
            // 
            // lblSubmittedAt
            // 
            lblSubmittedAt.AutoSize = true;
            lblSubmittedAt.Font = new Font("Segoe UI", 10F);
            lblSubmittedAt.Location = new Point(201, 176);
            lblSubmittedAt.Name = "lblSubmittedAt";
            lblSubmittedAt.Size = new Size(93, 19);
            lblSubmittedAt.TabIndex = 18;
            lblSubmittedAt.Text = "Submitted At:";
            // 
            // txtSubmittedAt
            // 
            txtSubmittedAt.Font = new Font("Segoe UI", 10F);
            txtSubmittedAt.Location = new Point(201, 223);
            txtSubmittedAt.Name = "txtSubmittedAt";
            txtSubmittedAt.ReadOnly = true;
            txtSubmittedAt.Size = new Size(192, 25);
            txtSubmittedAt.TabIndex = 19;
            // 
            // lblDocuments
            // 
            lblDocuments.AutoSize = true;
            lblDocuments.Font = new Font("Segoe UI", 12F);
            lblDocuments.Location = new Point(3, 314);
            lblDocuments.Name = "lblDocuments";
            lblDocuments.Size = new Size(89, 21);
            lblDocuments.TabIndex = 2;
            lblDocuments.Text = "Documents";
            // 
            // dataGridViewDocuments
            // 
            dataGridViewDocuments.AllowUserToAddRows = false;
            dataGridViewDocuments.AllowUserToDeleteRows = false;
            dataGridViewDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocuments.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridViewDocuments.Location = new Point(3, 340);
            dataGridViewDocuments.Name = "dataGridViewDocuments";
            dataGridViewDocuments.ReadOnly = true;
            dataGridViewDocuments.RowHeadersWidth = 51;
            dataGridViewDocuments.Size = new Size(794, 85);
            dataGridViewDocuments.TabIndex = 3;
            // 
            // lblFields
            // 
            lblFields.AutoSize = true;
            lblFields.Font = new Font("Segoe UI", 12F);
            lblFields.Location = new Point(3, 428);
            lblFields.Name = "lblFields";
            lblFields.Size = new Size(50, 21);
            lblFields.TabIndex = 4;
            lblFields.Text = "Fields";
            // 
            // dataGridViewFields
            // 
            dataGridViewFields.AllowUserToAddRows = false;
            dataGridViewFields.AllowUserToDeleteRows = false;
            dataGridViewFields.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFields.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewFields.Location = new Point(3, 462);
            dataGridViewFields.Name = "dataGridViewFields";
            dataGridViewFields.ReadOnly = true;
            dataGridViewFields.RowHeadersWidth = 51;
            dataGridViewFields.Size = new Size(794, 85);
            dataGridViewFields.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.RoyalBlue;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(3, 553);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 44);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Field Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Field Value";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Field Type";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Created At";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "File Name";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Page Type";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "File Path";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Created At";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // SubmissionDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(800, 600);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SubmissionDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Submission Details";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).EndInit();
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}