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
            txtApiUrl = new TextBox();
            lblApiUrl = new Label();
            errorProvider = new ErrorProvider(components);
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
            statusStrip2.Font = new Font("Segoe UI", 11F);
            statusStrip2.Items.AddRange(new ToolStripItem[] { statusLabel2 });
            statusStrip2.Location = new Point(0, 588);
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
            metadataPanel.Size = new Size(1200, 588);
            metadataPanel.TabIndex = 9;
            // 
            // tableLayout2
            // 
            tableLayout2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayout2.ColumnCount = 3;
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayout2.Controls.Add(lblDocuments, 0, 7);
            tableLayout2.Controls.Add(lblChannel, 2, 0);
            tableLayout2.Controls.Add(txtSourceSystem, 1, 1);
            tableLayout2.Controls.Add(lblSourceSystem, 1, 0);
            tableLayout2.Controls.Add(cboBatchClassName, 0, 1);
            tableLayout2.Controls.Add(lblBatchClassName, 0, 0);
            tableLayout2.Controls.Add(lblUserCode, 0, 2);
            tableLayout2.Controls.Add(txtSessionID, 1, 3);
            tableLayout2.Controls.Add(lblSessionID, 1, 2);
            tableLayout2.Controls.Add(txtMessageID, 2, 3);
            tableLayout2.Controls.Add(txtUserCode, 0, 3);
            tableLayout2.Controls.Add(txtChannel, 2, 1);
            tableLayout2.Controls.Add(lblMessageID, 2, 2);
            tableLayout2.Controls.Add(dataGridViewFields, 2, 8);
            tableLayout2.Controls.Add(lblFields, 2, 7);
            tableLayout2.Controls.Add(btnSubmitDocument, 2, 10);
            tableLayout2.Controls.Add(lblInteractionDate, 0, 5);
            tableLayout2.Controls.Add(pickerInteractionDateTime, 0, 6);
            tableLayout2.Controls.Add(tableLayoutPanel3, 1, 9);
            tableLayout2.Controls.Add(dataGridViewDocuments, 1, 8);
            tableLayout2.Controls.Add(tableLayoutPanel4, 0, 9);
            tableLayout2.Controls.Add(label1, 1, 7);
            tableLayout2.Controls.Add(dataGridViewGroups, 0, 8);
            tableLayout2.Controls.Add(btnRemoveField, 2, 9);
            tableLayout2.Controls.Add(txtApiUrl, 1, 6);
            tableLayout2.Controls.Add(lblApiUrl, 1, 5);
            tableLayout2.Location = new Point(12, 12);
            tableLayout2.Name = "tableLayout2";
            tableLayout2.RowCount = 11;
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout2.Size = new Size(1176, 600);
            tableLayout2.TabIndex = 0;
            // 
            // lblDocuments
            // 
            lblDocuments.AutoSize = true;
            lblDocuments.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDocuments.Location = new Point(3, 275);
            lblDocuments.Name = "lblDocuments";
            lblDocuments.Size = new Size(160, 30);
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
            txtSourceSystem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSourceSystem.Font = new Font("Segoe UI", 12F);
            txtSourceSystem.Location = new Point(395, 38);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new Size(384, 29);
            txtSourceSystem.TabIndex = 1;
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new Font("Segoe UI", 12F);
            lblSourceSystem.Location = new Point(395, 0);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new Size(116, 21);
            lblSourceSystem.TabIndex = 0;
            lblSourceSystem.Text = "Source System:";
            // 
            // cboBatchClassName
            // 
            cboBatchClassName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboBatchClassName.Font = new Font("Segoe UI", 12F);
            cboBatchClassName.FormattingEnabled = true;
            cboBatchClassName.Location = new Point(3, 38);
            cboBatchClassName.Name = "cboBatchClassName";
            cboBatchClassName.Size = new Size(386, 29);
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
            lblUserCode.Location = new Point(3, 80);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new Size(64, 21);
            lblUserCode.TabIndex = 0;
            lblUserCode.Text = "User ID:";
            // 
            // txtSessionID
            // 
            txtSessionID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSessionID.Font = new Font("Segoe UI", 12F);
            txtSessionID.Location = new Point(395, 118);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.Size = new Size(384, 29);
            txtSessionID.TabIndex = 4;
            // 
            // lblSessionID
            // 
            lblSessionID.AutoSize = true;
            lblSessionID.Font = new Font("Segoe UI", 12F);
            lblSessionID.Location = new Point(395, 80);
            lblSessionID.Name = "lblSessionID";
            lblSessionID.Size = new Size(85, 21);
            lblSessionID.TabIndex = 0;
            lblSessionID.Text = "Session ID:";
            // 
            // txtMessageID
            // 
            txtMessageID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMessageID.Font = new Font("Segoe UI", 12F);
            txtMessageID.Location = new Point(785, 118);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(388, 29);
            txtMessageID.TabIndex = 5;
            // 
            // txtUserCode
            // 
            txtUserCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUserCode.Font = new Font("Segoe UI", 12F);
            txtUserCode.Location = new Point(3, 118);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new Size(386, 29);
            txtUserCode.TabIndex = 3;
            // 
            // txtChannel
            // 
            txtChannel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtChannel.Font = new Font("Segoe UI", 12F);
            txtChannel.Location = new Point(785, 38);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(388, 29);
            txtChannel.TabIndex = 2;
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Font = new Font("Segoe UI", 12F);
            lblMessageID.Location = new Point(785, 80);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(93, 21);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // dataGridViewFields
            // 
            dataGridViewFields.AllowUserToAddRows = false;
            dataGridViewFields.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFields.ColumnHeadersHeight = 40;
            dataGridViewFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewFields.Dock = DockStyle.Fill;
            dataGridViewFields.Font = new Font("Segoe UI", 11F);
            dataGridViewFields.Location = new Point(785, 310);
            dataGridViewFields.Name = "dataGridViewFields";
            dataGridViewFields.RowHeadersWidth = 51;
            dataGridViewFields.RowTemplate.Height = 30;
            dataGridViewFields.Size = new Size(388, 240);
            dataGridViewFields.TabIndex = 14;
            // 
            // lblFields
            // 
            lblFields.AutoSize = true;
            lblFields.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFields.Location = new Point(785, 275);
            lblFields.Name = "lblFields";
            lblFields.Size = new Size(93, 30);
            lblFields.TabIndex = 11;
            lblFields.Text = "Field Data:";
            // 
            // btnSubmitDocument
            // 
            btnSubmitDocument.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSubmitDocument.BackColor = Color.RoyalBlue;
            btnSubmitDocument.FlatStyle = FlatStyle.Flat;
            btnSubmitDocument.Font = new Font("Segoe UI", 14F);
            btnSubmitDocument.ForeColor = Color.White;
            btnSubmitDocument.Location = new Point(785, 553);
            btnSubmitDocument.Name = "btnSubmitDocument";
            btnSubmitDocument.Size = new Size(388, 44);
            btnSubmitDocument.TabIndex = 17;
            btnSubmitDocument.Text = "Submit Groups";
            btnSubmitDocument.UseVisualStyleBackColor = false;
            // 
            // lblInteractionDate
            // 
            lblInteractionDate.AutoSize = true;
            lblInteractionDate.Font = new Font("Segoe UI", 12F);
            lblInteractionDate.Location = new Point(3, 195);
            lblInteractionDate.Name = "lblInteractionDate";
            lblInteractionDate.Size = new Size(161, 21);
            lblInteractionDate.TabIndex = 24;
            lblInteractionDate.Text = "Interaction Date Time:";
            // 
            // pickerInteractionDateTime
            // 
            pickerInteractionDateTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pickerInteractionDateTime.CustomFormat = "ddd, dd MMM yyyy hh:mm tt";
            pickerInteractionDateTime.Font = new Font("Segoe UI", 12F);
            pickerInteractionDateTime.Format = DateTimePickerFormat.Custom;
            pickerInteractionDateTime.Location = new Point(3, 238);
            pickerInteractionDateTime.Name = "pickerInteractionDateTime";
            pickerInteractionDateTime.Size = new Size(386, 29);
            pickerInteractionDateTime.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnRemoveFile, 1, 0);
            tableLayoutPanel3.Controls.Add(btnBrowseFile, 0, 0);
            tableLayoutPanel3.Location = new Point(395, 553);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(384, 44);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // btnRemoveFile
            // 
            btnRemoveFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRemoveFile.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveFile.FlatStyle = FlatStyle.Flat;
            btnRemoveFile.Font = new Font("Segoe UI", 14F);
            btnRemoveFile.ForeColor = Color.White;
            btnRemoveFile.Location = new Point(195, 3);
            btnRemoveFile.Name = "btnRemoveFile";
            btnRemoveFile.Size = new Size(186, 38);
            btnRemoveFile.TabIndex = 16;
            btnRemoveFile.Text = "Remove File";
            btnRemoveFile.UseVisualStyleBackColor = false;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnBrowseFile.BackColor = Color.Green;
            btnBrowseFile.FlatStyle = FlatStyle.Flat;
            btnBrowseFile.Font = new Font("Segoe UI", 14F);
            btnBrowseFile.ForeColor = Color.White;
            btnBrowseFile.Location = new Point(3, 3);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(186, 38);
            btnBrowseFile.TabIndex = 15;
            btnBrowseFile.Text = "Add Files";
            btnBrowseFile.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDocuments
            // 
            dataGridViewDocuments.AllowUserToAddRows = false;
            dataGridViewDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDocuments.ColumnHeadersHeight = 40;
            dataGridViewDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewDocuments.Dock = DockStyle.Fill;
            dataGridViewDocuments.Font = new Font("Segoe UI", 11F);
            dataGridViewDocuments.Location = new Point(395, 310);
            dataGridViewDocuments.Name = "dataGridViewDocuments";
            dataGridViewDocuments.RowHeadersWidth = 51;
            dataGridViewDocuments.RowTemplate.Height = 30;
            dataGridViewDocuments.Size = new Size(384, 240);
            dataGridViewDocuments.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnAddGroup, 0, 0);
            tableLayoutPanel4.Controls.Add(btnRemoveGroup, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 553);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(386, 44);
            tableLayoutPanel4.TabIndex = 26;
            // 
            // btnAddGroup
            // 
            btnAddGroup.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddGroup.BackColor = Color.Green;
            btnAddGroup.FlatStyle = FlatStyle.Flat;
            btnAddGroup.Font = new Font("Segoe UI", 14F);
            btnAddGroup.ForeColor = Color.White;
            btnAddGroup.Location = new Point(3, 3);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(190, 38);
            btnAddGroup.TabIndex = 20;
            btnAddGroup.Text = "Add Group";
            btnAddGroup.UseVisualStyleBackColor = false;
            // 
            // btnRemoveGroup
            // 
            btnRemoveGroup.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRemoveGroup.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveGroup.FlatStyle = FlatStyle.Flat;
            btnRemoveGroup.Font = new Font("Segoe UI", 14F);
            btnRemoveGroup.ForeColor = Color.White;
            btnRemoveGroup.Location = new Point(196, 3);
            btnRemoveGroup.Name = "btnRemoveGroup";
            btnRemoveGroup.Size = new Size(187, 38);
            btnRemoveGroup.TabIndex = 12;
            btnRemoveGroup.Text = "Remove Group";
            btnRemoveGroup.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(395, 275);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 27;
            label1.Text = "Documents:";
            // 
            // dataGridViewGroups
            // 
            dataGridViewGroups.AllowUserToAddRows = false;
            dataGridViewGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGroups.ColumnHeadersHeight = 40;
            dataGridViewGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewGroups.Dock = DockStyle.Fill;
            dataGridViewGroups.Font = new Font("Segoe UI", 11F);
            dataGridViewGroups.Location = new Point(3, 310);
            dataGridViewGroups.Name = "dataGridViewGroups";
            dataGridViewGroups.RowHeadersWidth = 51;
            dataGridViewGroups.RowTemplate.Height = 30;
            dataGridViewGroups.Size = new Size(386, 240);
            dataGridViewGroups.TabIndex = 11;
            // 
            // btnRemoveField
            // 
            btnRemoveField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRemoveField.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveField.FlatStyle = FlatStyle.Flat;
            btnRemoveField.Font = new Font("Segoe UI", 14F);
            btnRemoveField.ForeColor = Color.White;
            btnRemoveField.Location = new Point(785, 553);
            btnRemoveField.Name = "btnRemoveField";
            btnRemoveField.Size = new Size(388, 38);
            btnRemoveField.TabIndex = 28;
            btnRemoveField.Text = "Remove Field";
            btnRemoveField.UseVisualStyleBackColor = false;
            // 
            // txtApiUrl
            // 
            txtApiUrl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApiUrl.Font = new Font("Segoe UI", 12F);
            txtApiUrl.Location = new Point(395, 238);
            txtApiUrl.Name = "txtApiUrl";
            txtApiUrl.Size = new Size(384, 29);
            txtApiUrl.TabIndex = 29;
            // 
            // lblApiUrl
            // 
            lblApiUrl.AutoSize = true;
            lblApiUrl.Font = new Font("Segoe UI", 12F);
            lblApiUrl.Location = new Point(395, 195);
            lblApiUrl.Name = "lblApiUrl";
            lblApiUrl.Size = new Size(69, 21);
            lblApiUrl.TabIndex = 30;
            lblApiUrl.Text = "API URL:";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // SubmitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1200, 610);
            Controls.Add(submitPanel);
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "SubmitForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Submit Document";
            WindowState = FormWindowState.Maximized;
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