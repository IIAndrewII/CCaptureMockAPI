namespace CCaptureWinForm
{
    partial class SubmitForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel submitPanel;
        private System.Windows.Forms.Panel metadataPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout2;
        private System.Windows.Forms.TextBox txtMessageID;
        private System.Windows.Forms.Label lblMessageID;
        private System.Windows.Forms.TextBox txtSessionID;
        private System.Windows.Forms.Label lblSessionID;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.TextBox txtSourceSystem;
        private System.Windows.Forms.Label lblSourceSystem;
        private System.Windows.Forms.ComboBox cboBatchClassName;
        private System.Windows.Forms.Label lblBatchClassName;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel2;
        private System.Windows.Forms.DataGridView dataGridViewDocuments;
        private System.Windows.Forms.DataGridView dataGridViewFields;
        private System.Windows.Forms.Label lblDocuments;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnSubmitDocument;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Label lblInteractionDate;
        private System.Windows.Forms.DateTimePicker pickerInteractionDateTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveField;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.Label lblApiUrl;

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
            submitPanel = new Panel();
            statusStrip2 = new StatusStrip();
            statusLabel2 = new ToolStripStatusLabel();
            metadataPanel = new Panel();
            tableLayout2 = new TableLayoutPanel();
            lblDocuments = new Label();
            lblChannel = new Label();
            txtSourceSystem = new TextBox();
            lblSourceSystem = new Label();
            cboBatchClassName = new ComboBox();
            lblBatchClassName = new Label();
            lblUserCode = new Label();
            txtSessionID = new TextBox();
            lblSessionID = new Label();
            txtMessageID = new TextBox();
            txtUserCode = new TextBox();
            txtChannel = new TextBox();
            lblMessageID = new Label();
            dataGridViewFields = new DataGridView();
            lblFields = new Label();
            btnSubmitDocument = new Button();
            lblInteractionDate = new Label();
            pickerInteractionDateTime = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnRemoveFile = new Button();
            btnBrowseFile = new Button();
            dataGridViewDocuments = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnAddGroup = new Button();
            btnRemoveGroup = new Button();
            label1 = new Label();
            dataGridViewGroups = new DataGridView();
            btnRemoveField = new Button();
            errorProvider = new ErrorProvider(components);
            txtApiUrl = new TextBox();
            lblApiUrl = new Label();
            submitPanel.SuspendLayout();
            statusStrip2.SuspendLayout();
            metadataPanel.SuspendLayout();
            tableLayout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // submitPanel
            // 
            submitPanel.Controls.Add(statusStrip2);
            submitPanel.Controls.Add(metadataPanel);
            submitPanel.Dock = DockStyle.Fill;
            submitPanel.Font = new Font("Segoe UI", 12F);
            submitPanel.Location = new Point(0, 0);
            submitPanel.Name = "submitPanel";
            submitPanel.Size = new Size(1200, 583);
            submitPanel.TabIndex = 1;
            // 
            // statusStrip2
            // 
            statusStrip2.Font = new Font("Segoe UI", 10F);
            statusStrip2.Items.AddRange(new ToolStripItem[] { statusLabel2 });
            statusStrip2.Location = new Point(0, 561);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(1200, 22);
            statusStrip2.TabIndex = 11;
            // 
            // statusLabel2
            // 
            statusLabel2.Name = "statusLabel2";
            statusLabel2.Size = new Size(0, 17);
            // 
            // metadataPanel
            // 
            metadataPanel.Controls.Add(tableLayout2);
            metadataPanel.Dock = DockStyle.Fill;
            metadataPanel.Location = new Point(0, 0);
            metadataPanel.Name = "metadataPanel";
            metadataPanel.Size = new Size(1200, 583);
            metadataPanel.TabIndex = 9;
            // 
            // tableLayout2
            // 
            tableLayout2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayout2.ColumnCount = 6;
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0030022F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.33033347F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.003006F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.33033347F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.003006F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.33033347F));
            tableLayout2.Controls.Add(lblDocuments, 0, 7);
            tableLayout2.Controls.Add(lblChannel, 4, 0);
            tableLayout2.Controls.Add(txtSourceSystem, 2, 1);
            tableLayout2.Controls.Add(lblSourceSystem, 2, 0);
            tableLayout2.Controls.Add(cboBatchClassName, 0, 1);
            tableLayout2.Controls.Add(lblBatchClassName, 0, 0);
            tableLayout2.Controls.Add(lblUserCode, 0, 2);
            tableLayout2.Controls.Add(txtSessionID, 2, 3);
            tableLayout2.Controls.Add(lblSessionID, 2, 2);
            tableLayout2.Controls.Add(txtMessageID, 4, 3);
            tableLayout2.Controls.Add(txtUserCode, 0, 3);
            tableLayout2.Controls.Add(txtChannel, 4, 1);
            tableLayout2.Controls.Add(lblMessageID, 4, 2);
            tableLayout2.Controls.Add(dataGridViewFields, 4, 8);
            tableLayout2.Controls.Add(lblFields, 4, 7);
            tableLayout2.Controls.Add(btnSubmitDocument, 4, 10);
            tableLayout2.Controls.Add(lblInteractionDate, 0, 5);
            tableLayout2.Controls.Add(pickerInteractionDateTime, 0, 6);
            tableLayout2.Controls.Add(tableLayoutPanel3, 2, 9);
            tableLayout2.Controls.Add(dataGridViewDocuments, 2, 8);
            tableLayout2.Controls.Add(tableLayoutPanel4, 0, 9);
            tableLayout2.Controls.Add(label1, 2, 7);
            tableLayout2.Controls.Add(dataGridViewGroups, 0, 8);
            tableLayout2.Controls.Add(btnRemoveField, 4, 9);
            tableLayout2.Controls.Add(txtApiUrl, 2, 6);
            tableLayout2.Controls.Add(lblApiUrl, 2, 5);
            tableLayout2.Location = new Point(12, 12);
            tableLayout2.Name = "tableLayout2";
            tableLayout2.RowCount = 12;
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayout2.Size = new Size(1176, 546);
            tableLayout2.TabIndex = 0;
            // 
            // lblDocuments
            // 
            lblDocuments.AutoSize = true;
            lblDocuments.Font = new Font("Segoe UI", 12F);
            lblDocuments.Location = new Point(3, 240);
            lblDocuments.Name = "lblDocuments";
            lblDocuments.Size = new Size(140, 21);
            lblDocuments.TabIndex = 12;
            lblDocuments.Text = "Document Groups:";
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Font = new Font("Segoe UI", 12F);
            lblChannel.Location = new Point(785, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(70, 21);
            lblChannel.TabIndex = 0;
            lblChannel.Text = "Channel:";
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.Font = new Font("Segoe UI", 12F);
            txtSourceSystem.Location = new Point(394, 33);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new Size(346, 29);
            txtSourceSystem.TabIndex = 1;
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new Font("Segoe UI", 12F);
            lblSourceSystem.Location = new Point(394, 0);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new Size(116, 21);
            lblSourceSystem.TabIndex = 0;
            lblSourceSystem.Text = "Source System:";
            // 
            // cboBatchClassName
            // 
            cboBatchClassName.Font = new Font("Segoe UI", 12F);
            cboBatchClassName.FormattingEnabled = true;
            cboBatchClassName.Location = new Point(3, 33);
            cboBatchClassName.Name = "cboBatchClassName";
            cboBatchClassName.Size = new Size(346, 29);
            cboBatchClassName.TabIndex = 0;
            // 
            // lblBatchClassName
            // 
            lblBatchClassName.AutoSize = true;
            lblBatchClassName.Font = new Font("Segoe UI", 12F);
            lblBatchClassName.Location = new Point(3, 0);
            lblBatchClassName.Name = "lblBatchClassName";
            lblBatchClassName.Size = new Size(91, 21);
            lblBatchClassName.TabIndex = 0;
            lblBatchClassName.Text = "Batch Class:";
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new Font("Segoe UI", 12F);
            lblUserCode.Location = new Point(3, 70);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new Size(64, 21);
            lblUserCode.TabIndex = 0;
            lblUserCode.Text = "User ID:";
            // 
            // txtSessionID
            // 
            txtSessionID.Font = new Font("Segoe UI", 12F);
            txtSessionID.Location = new Point(394, 103);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.Size = new Size(346, 29);
            txtSessionID.TabIndex = 4;
            // 
            // lblSessionID
            // 
            lblSessionID.AutoSize = true;
            lblSessionID.Font = new Font("Segoe UI", 12F);
            lblSessionID.Location = new Point(394, 70);
            lblSessionID.Name = "lblSessionID";
            lblSessionID.Size = new Size(85, 21);
            lblSessionID.TabIndex = 0;
            lblSessionID.Text = "Session ID:";
            // 
            // txtMessageID
            // 
            txtMessageID.Font = new Font("Segoe UI", 12F);
            txtMessageID.Location = new Point(785, 103);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(346, 29);
            txtMessageID.TabIndex = 5;
            // 
            // txtUserCode
            // 
            txtUserCode.Font = new Font("Segoe UI", 12F);
            txtUserCode.Location = new Point(3, 103);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new Size(346, 29);
            txtUserCode.TabIndex = 3;
            // 
            // txtChannel
            // 
            txtChannel.Font = new Font("Segoe UI", 12F);
            txtChannel.Location = new Point(785, 33);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(346, 29);
            txtChannel.TabIndex = 2;
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Font = new Font("Segoe UI", 12F);
            lblMessageID.Location = new Point(785, 70);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(93, 21);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // dataGridViewFields
            // 
            dataGridViewFields.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewFields.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFields.Font = new Font("Segoe UI", 12F);
            dataGridViewFields.Location = new Point(785, 273);
            dataGridViewFields.Name = "dataGridViewFields";
            dataGridViewFields.RowHeadersWidth = 51;
            dataGridViewFields.Size = new Size(346, 164);
            dataGridViewFields.TabIndex = 14;
            // 
            // lblFields
            // 
            lblFields.AutoSize = true;
            lblFields.Font = new Font("Segoe UI", 12F);
            lblFields.Location = new Point(785, 240);
            lblFields.Name = "lblFields";
            lblFields.Size = new Size(82, 21);
            lblFields.TabIndex = 11;
            lblFields.Text = "Field Data:";
            // 
            // btnSubmitDocument
            // 
            btnSubmitDocument.BackColor = Color.RoyalBlue;
            btnSubmitDocument.FlatStyle = FlatStyle.Flat;
            btnSubmitDocument.Font = new Font("Segoe UI", 12F);
            btnSubmitDocument.ForeColor = Color.White;
            btnSubmitDocument.Location = new Point(785, 493);
            btnSubmitDocument.Name = "btnSubmitDocument";
            btnSubmitDocument.Size = new Size(346, 44);
            btnSubmitDocument.TabIndex = 17;
            btnSubmitDocument.Text = "Submit Groups";
            btnSubmitDocument.UseVisualStyleBackColor = false;
            // 
            // lblInteractionDate
            // 
            lblInteractionDate.AutoSize = true;
            lblInteractionDate.Font = new Font("Segoe UI", 12F);
            lblInteractionDate.Location = new Point(3, 170);
            lblInteractionDate.Name = "lblInteractionDate";
            lblInteractionDate.Size = new Size(161, 21);
            lblInteractionDate.TabIndex = 24;
            lblInteractionDate.Text = "Interaction Date Time:";
            // 
            // pickerInteractionDateTime
            // 
            pickerInteractionDateTime.CustomFormat = "ddd, dd MMM yyyy hh:mm tt";
            pickerInteractionDateTime.Font = new Font("Segoe UI", 12F);
            pickerInteractionDateTime.Format = DateTimePickerFormat.Custom;
            pickerInteractionDateTime.Location = new Point(3, 203);
            pickerInteractionDateTime.Name = "pickerInteractionDateTime";
            pickerInteractionDateTime.Size = new Size(346, 29);
            pickerInteractionDateTime.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnRemoveFile, 1, 0);
            tableLayoutPanel3.Controls.Add(btnBrowseFile, 0, 0);
            tableLayoutPanel3.Location = new Point(394, 443);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(346, 34);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // btnRemoveFile
            // 
            btnRemoveFile.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveFile.FlatStyle = FlatStyle.Flat;
            btnRemoveFile.Font = new Font("Segoe UI", 12F);
            btnRemoveFile.ForeColor = Color.White;
            btnRemoveFile.Location = new Point(176, 3);
            btnRemoveFile.Name = "btnRemoveFile";
            btnRemoveFile.Size = new Size(167, 28);
            btnRemoveFile.TabIndex = 16;
            btnRemoveFile.Text = "Remove File";
            btnRemoveFile.UseVisualStyleBackColor = false;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.BackColor = Color.Green;
            btnBrowseFile.FlatStyle = FlatStyle.Flat;
            btnBrowseFile.Font = new Font("Segoe UI", 12F);
            btnBrowseFile.ForeColor = Color.White;
            btnBrowseFile.Location = new Point(3, 3);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(167, 28);
            btnBrowseFile.TabIndex = 15;
            btnBrowseFile.Text = "Add Files";
            btnBrowseFile.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDocuments
            // 
            dataGridViewDocuments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocuments.Font = new Font("Segoe UI", 12F);
            dataGridViewDocuments.Location = new Point(394, 273);
            dataGridViewDocuments.Name = "dataGridViewDocuments";
            dataGridViewDocuments.RowHeadersWidth = 51;
            dataGridViewDocuments.Size = new Size(346, 164);
            dataGridViewDocuments.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnAddGroup, 0, 0);
            tableLayoutPanel4.Controls.Add(btnRemoveGroup, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 443);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(346, 34);
            tableLayoutPanel4.TabIndex = 26;
            // 
            // btnAddGroup
            // 
            btnAddGroup.BackColor = Color.Green;
            btnAddGroup.FlatStyle = FlatStyle.Flat;
            btnAddGroup.Font = new Font("Segoe UI", 12F);
            btnAddGroup.ForeColor = Color.White;
            btnAddGroup.Location = new Point(3, 3);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(167, 28);
            btnAddGroup.TabIndex = 20;
            btnAddGroup.Text = "Add";
            btnAddGroup.UseVisualStyleBackColor = false;
            // 
            // btnRemoveGroup
            // 
            btnRemoveGroup.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveGroup.FlatStyle = FlatStyle.Flat;
            btnRemoveGroup.Font = new Font("Segoe UI", 12F);
            btnRemoveGroup.ForeColor = Color.White;
            btnRemoveGroup.Location = new Point(176, 3);
            btnRemoveGroup.Name = "btnRemoveGroup";
            btnRemoveGroup.Size = new Size(167, 28);
            btnRemoveGroup.TabIndex = 12;
            btnRemoveGroup.Text = "Remove";
            btnRemoveGroup.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(394, 240);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 27;
            label1.Text = "Documents:";
            // 
            // dataGridViewGroups
            // 
            dataGridViewGroups.AllowUserToAddRows = false;
            dataGridViewGroups.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGroups.Font = new Font("Segoe UI", 12F);
            dataGridViewGroups.Location = new Point(3, 273);
            dataGridViewGroups.Name = "dataGridViewGroups";
            dataGridViewGroups.RowHeadersWidth = 51;
            dataGridViewGroups.Size = new Size(346, 164);
            dataGridViewGroups.TabIndex = 11;
            // 
            // btnRemoveField
            // 
            btnRemoveField.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveField.FlatStyle = FlatStyle.Flat;
            btnRemoveField.Font = new Font("Segoe UI", 12F);
            btnRemoveField.ForeColor = Color.White;
            btnRemoveField.Location = new Point(785, 443);
            btnRemoveField.Name = "btnRemoveField";
            btnRemoveField.Size = new Size(346, 34);
            btnRemoveField.TabIndex = 28;
            btnRemoveField.Text = "Remove Field";
            btnRemoveField.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // txtApiUrl
            // 
            txtApiUrl.Font = new Font("Segoe UI", 12F);
            txtApiUrl.Location = new Point(394, 203);
            txtApiUrl.Name = "txtApiUrl";
            txtApiUrl.Size = new Size(346, 29);
            txtApiUrl.TabIndex = 29;
            // 
            // lblApiUrl
            // 
            lblApiUrl.AutoSize = true;
            lblApiUrl.Font = new Font("Segoe UI", 12F);
            lblApiUrl.Location = new Point(394, 170);
            lblApiUrl.Name = "lblApiUrl";
            lblApiUrl.Size = new Size(69, 21);
            lblApiUrl.TabIndex = 30;
            lblApiUrl.Text = "API URL:";
            // 
            // SubmitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1200, 583);
            Controls.Add(submitPanel);
            Name = "SubmitForm";
            Text = "Submit Document";
            submitPanel.ResumeLayout(false);
            submitPanel.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            metadataPanel.ResumeLayout(false);
            tableLayout2.ResumeLayout(false);
            tableLayout2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroups).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }
    }
}