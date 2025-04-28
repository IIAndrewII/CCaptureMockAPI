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
            txtChannel = new System.Windows.Forms.TextBox();
            txtSourceSystem = new System.Windows.Forms.TextBox();
            cboBatchClassName = new System.Windows.Forms.ComboBox();
            txtUserCode = new System.Windows.Forms.TextBox();
            txtMessageID = new System.Windows.Forms.TextBox();
            txtSessionID = new System.Windows.Forms.TextBox();
            dataGridViewGroups = new System.Windows.Forms.DataGridView();
            btnRemoveGroup = new System.Windows.Forms.Button();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            submitPanel = new System.Windows.Forms.Panel();
            statusStrip2 = new System.Windows.Forms.StatusStrip();
            statusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            metadataPanel = new System.Windows.Forms.Panel();
            tableLayout2 = new System.Windows.Forms.TableLayoutPanel();
            lblDocuments = new System.Windows.Forms.Label();
            lblChannel = new System.Windows.Forms.Label();
            lblSourceSystem = new System.Windows.Forms.Label();
            lblBatchClassName = new System.Windows.Forms.Label();
            lblUserCode = new System.Windows.Forms.Label();
            lblSessionID = new System.Windows.Forms.Label();
            lblMessageID = new System.Windows.Forms.Label();
            dataGridViewFields = new System.Windows.Forms.DataGridView();
            lblFields = new System.Windows.Forms.Label();
            btnSubmitDocument = new System.Windows.Forms.Button();
            lblInteractionDate = new System.Windows.Forms.Label();
            pickerInteractionDateTime = new System.Windows.Forms.DateTimePicker();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnRemoveFile = new System.Windows.Forms.Button();
            btnBrowseFile = new System.Windows.Forms.Button();
            dataGridViewDocuments = new System.Windows.Forms.DataGridView();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnAddGroup = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnRemoveField = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider)).BeginInit();
            submitPanel.SuspendLayout();
            statusStrip2.SuspendLayout();
            metadataPanel.SuspendLayout();
            tableLayout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewFields)).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewDocuments)).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtChannel
            // 
            txtChannel.AccessibleName = "Channel";
            txtChannel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtChannel.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtChannel.Location = new System.Drawing.Point(799, 23);
            txtChannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new System.Drawing.Size(353, 29);
            txtChannel.TabIndex = 2;
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.AccessibleName = "Source System";
            txtSourceSystem.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSourceSystem.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSourceSystem.Location = new System.Drawing.Point(401, 23);
            txtSourceSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new System.Drawing.Size(353, 29);
            txtSourceSystem.TabIndex = 1;
            // 
            // cboBatchClassName
            // 
            cboBatchClassName.AccessibleName = "Batch Category";
            cboBatchClassName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboBatchClassName.Font = new System.Drawing.Font("Segoe UI", 12F);
            cboBatchClassName.FormattingEnabled = true;
            cboBatchClassName.Location = new System.Drawing.Point(3, 23);
            cboBatchClassName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cboBatchClassName.Name = "cboBatchClassName";
            cboBatchClassName.Size = new System.Drawing.Size(353, 29);
            cboBatchClassName.TabIndex = 0;
            // 
            // txtUserCode
            // 
            txtUserCode.AccessibleName = "User ID";
            txtUserCode.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtUserCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtUserCode.Location = new System.Drawing.Point(3, 77);
            txtUserCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new System.Drawing.Size(353, 29);
            txtUserCode.TabIndex = 3;
            // 
            // txtMessageID
            // 
            txtMessageID.AccessibleName = "Message ID";
            txtMessageID.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMessageID.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtMessageID.Location = new System.Drawing.Point(799, 77);
            txtMessageID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new System.Drawing.Size(353, 29);
            txtMessageID.TabIndex = 5;
            // 
            // txtSessionID
            // 
            txtSessionID.AccessibleName = "Session ID";
            txtSessionID.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSessionID.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSessionID.Location = new System.Drawing.Point(401, 77);
            txtSessionID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.Size = new System.Drawing.Size(353, 29);
            txtSessionID.TabIndex = 4;
            // 
            // dataGridViewGroups
            // 
            dataGridViewGroups.AccessibleName = "Submit Groups";
            dataGridViewGroups.AllowUserToAddRows = false;
            dataGridViewGroups.AllowUserToDeleteRows = false;
            dataGridViewGroups.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGroups.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewGroups.Location = new System.Drawing.Point(3, 254);
            dataGridViewGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridViewGroups.Name = "dataGridViewGroups";
            dataGridViewGroups.RowHeadersVisible = false;
            dataGridViewGroups.RowHeadersWidth = 51;
            dataGridViewGroups.Size = new System.Drawing.Size(242, 179);
            dataGridViewGroups.TabIndex = 11;
            // 
            // btnRemoveGroup
            // 
            btnRemoveGroup.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnRemoveGroup.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnRemoveGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveGroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnRemoveGroup.ForeColor = System.Drawing.Color.White;
            btnRemoveGroup.Location = new System.Drawing.Point(125, 2);
            btnRemoveGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRemoveGroup.Name = "btnRemoveGroup";
            btnRemoveGroup.Size = new System.Drawing.Size(117, 30);
            btnRemoveGroup.TabIndex = 12;
            btnRemoveGroup.Text = "Remove";
            btnRemoveGroup.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // submitPanel
            // 
            submitPanel.Controls.Add(statusStrip2);
            submitPanel.Controls.Add(metadataPanel);
            submitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            submitPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            submitPanel.Location = new System.Drawing.Point(0, 0);
            submitPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            submitPanel.Name = "submitPanel";
            submitPanel.Size = new System.Drawing.Size(1200, 583);
            submitPanel.TabIndex = 1;
            // 
            // statusStrip2
            // 
            statusStrip2.Font = new System.Drawing.Font("Segoe UI", 10F);
            statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel2 });
            statusStrip2.Location = new System.Drawing.Point(0, 561);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            statusStrip2.Size = new System.Drawing.Size(1200, 22);
            statusStrip2.TabIndex = 11;
            // 
            // statusLabel2
            // 
            statusLabel2.Name = "statusLabel2";
            statusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // metadataPanel
            // 
            metadataPanel.Controls.Add(tableLayout2);
            metadataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            metadataPanel.Location = new System.Drawing.Point(0, 0);
            metadataPanel.Margin = new System.Windows.Forms.Padding(12, 8, 12, 2);
            metadataPanel.Name = "metadataPanel";
            metadataPanel.Size = new System.Drawing.Size(1200, 609);
            metadataPanel.TabIndex = 9;
            // 
            // tableLayout2
            // 
            tableLayout2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tableLayout2.ColumnCount = 6;
            tableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0030022F));
            tableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.33033323F));
            tableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0030022F));
            tableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.33033323F));
            tableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0030022F));
            tableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.33033323F));
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
            tableLayout2.Location = new System.Drawing.Point(0, 0);
            tableLayout2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayout2.Name = "tableLayout2";
            tableLayout2.RowCount = 12;
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.85068F));
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.7166166F));
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayout2.Size = new System.Drawing.Size(1199, 567);
            tableLayout2.TabIndex = 0;
            // 
            // lblDocuments
            // 
            lblDocuments.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblDocuments.AutoSize = true;
            lblDocuments.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblDocuments.Location = new System.Drawing.Point(3, 231);
            lblDocuments.Name = "lblDocuments";
            lblDocuments.Size = new System.Drawing.Size(140, 21);
            lblDocuments.TabIndex = 12;
            lblDocuments.Text = "Document Groups:";
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblChannel.Location = new System.Drawing.Point(799, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new System.Drawing.Size(70, 21);
            lblChannel.TabIndex = 0;
            lblChannel.Text = "Channel:";
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSourceSystem.Location = new System.Drawing.Point(401, 0);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new System.Drawing.Size(116, 21);
            lblSourceSystem.TabIndex = 0;
            lblSourceSystem.Text = "Source System:";
            // 
            // lblBatchClassName
            // 
            lblBatchClassName.AutoSize = true;
            lblBatchClassName.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblBatchClassName.Location = new System.Drawing.Point(3, 0);
            lblBatchClassName.Name = "lblBatchClassName";
            lblBatchClassName.Size = new System.Drawing.Size(91, 21);
            lblBatchClassName.TabIndex = 0;
            lblBatchClassName.Text = "Batch Class:";
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblUserCode.Location = new System.Drawing.Point(3, 54);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new System.Drawing.Size(64, 21);
            lblUserCode.TabIndex = 0;
            lblUserCode.Text = "User ID:";
            // 
            // lblSessionID
            // 
            lblSessionID.AutoSize = true;
            lblSessionID.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSessionID.Location = new System.Drawing.Point(401, 54);
            lblSessionID.Name = "lblSessionID";
            lblSessionID.Size = new System.Drawing.Size(85, 21);
            lblSessionID.TabIndex = 0;
            lblSessionID.Text = "Session ID:";
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblMessageID.Location = new System.Drawing.Point(799, 54);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new System.Drawing.Size(93, 21);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // dataGridViewFields
            // 
            dataGridViewFields.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFields.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewFields.Location = new System.Drawing.Point(799, 254);
            dataGridViewFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridViewFields.Name = "dataGridViewFields";
            dataGridViewFields.RowHeadersWidth = 51;
            dataGridViewFields.Size = new System.Drawing.Size(353, 179);
            dataGridViewFields.TabIndex = 14;
            // 
            // lblFields
            // 
            lblFields.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblFields.AutoSize = true;
            lblFields.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblFields.Location = new System.Drawing.Point(799, 231);
            lblFields.Name = "lblFields";
            lblFields.Size = new System.Drawing.Size(82, 21);
            lblFields.TabIndex = 11;
            lblFields.Text = "Field Data:";
            // 
            // btnSubmitDocument
            // 
            btnSubmitDocument.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSubmitDocument.BackColor = System.Drawing.Color.RoyalBlue;
            btnSubmitDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmitDocument.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnSubmitDocument.ForeColor = System.Drawing.Color.White;
            btnSubmitDocument.Location = new System.Drawing.Point(888, 482);
            btnSubmitDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSubmitDocument.Name = "btnSubmitDocument";
            btnSubmitDocument.Size = new System.Drawing.Size(264, 40);
            btnSubmitDocument.TabIndex = 17;
            btnSubmitDocument.Text = "Submit Groups";
            btnSubmitDocument.UseVisualStyleBackColor = false;
            // 
            // lblInteractionDate
            // 
            lblInteractionDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblInteractionDate.AutoSize = true;
            lblInteractionDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblInteractionDate.Location = new System.Drawing.Point(3, 125);
            lblInteractionDate.Name = "lblInteractionDate";
            lblInteractionDate.Size = new System.Drawing.Size(161, 21);
            lblInteractionDate.TabIndex = 24;
            lblInteractionDate.Text = "Interaction Date Time:";
            // 
            // pickerInteractionDateTime
            // 
            pickerInteractionDateTime.CustomFormat = "";
            pickerInteractionDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            pickerInteractionDateTime.Location = new System.Drawing.Point(3, 148);
            pickerInteractionDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pickerInteractionDateTime.Name = "pickerInteractionDateTime";
            pickerInteractionDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            pickerInteractionDateTime.Size = new System.Drawing.Size(178, 29);
            pickerInteractionDateTime.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnRemoveFile, 1, 0);
            tableLayoutPanel3.Controls.Add(btnBrowseFile, 0, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(401, 437);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(334, 37);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // btnRemoveFile
            // 
            btnRemoveFile.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnRemoveFile.ForeColor = System.Drawing.Color.White;
            btnRemoveFile.Location = new System.Drawing.Point(170, 2);
            btnRemoveFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRemoveFile.Name = "btnRemoveFile";
            btnRemoveFile.Size = new System.Drawing.Size(161, 32);
            btnRemoveFile.TabIndex = 16;
            btnRemoveFile.Text = "Remove File";
            btnRemoveFile.UseVisualStyleBackColor = false;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.BackColor = System.Drawing.Color.Green;
            btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBrowseFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnBrowseFile.ForeColor = System.Drawing.Color.White;
            btnBrowseFile.Location = new System.Drawing.Point(3, 2);
            btnBrowseFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new System.Drawing.Size(161, 32);
            btnBrowseFile.TabIndex = 15;
            btnBrowseFile.Text = "Add Files";
            btnBrowseFile.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDocuments
            // 
            dataGridViewDocuments.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocuments.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewDocuments.Location = new System.Drawing.Point(401, 254);
            dataGridViewDocuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridViewDocuments.Name = "dataGridViewDocuments";
            dataGridViewDocuments.RowHeadersWidth = 51;
            dataGridViewDocuments.Size = new System.Drawing.Size(353, 179);
            dataGridViewDocuments.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnAddGroup, 0, 0);
            tableLayoutPanel4.Controls.Add(btnRemoveGroup, 1, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 437);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(245, 34);
            tableLayoutPanel4.TabIndex = 26;
            // 
            // btnAddGroup
            // 
            btnAddGroup.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAddGroup.BackColor = System.Drawing.Color.Green;
            btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddGroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnAddGroup.ForeColor = System.Drawing.Color.White;
            btnAddGroup.Location = new System.Drawing.Point(3, 2);
            btnAddGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new System.Drawing.Size(116, 30);
            btnAddGroup.TabIndex = 20;
            btnAddGroup.Text = "Add";
            btnAddGroup.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(401, 231);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 21);
            label1.TabIndex = 27;
            label1.Text = "Documents:";
            // 
            // btnRemoveField
            // 
            btnRemoveField.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnRemoveField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveField.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnRemoveField.ForeColor = System.Drawing.Color.White;
            btnRemoveField.Location = new System.Drawing.Point(799, 437);
            btnRemoveField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRemoveField.Name = "btnRemoveField";
            btnRemoveField.Size = new System.Drawing.Size(161, 32);
            btnRemoveField.TabIndex = 28;
            btnRemoveField.Text = "Remove Field";
            btnRemoveField.UseVisualStyleBackColor = false;
            // 
            // SubmitForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            ClientSize = new System.Drawing.Size(1200, 583);
            Controls.Add(submitPanel);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimumSize = new System.Drawing.Size(702, 383);
            Name = "SubmitForm";
            Text = "Submit Document";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider)).EndInit();
            submitPanel.ResumeLayout(false);
            submitPanel.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            metadataPanel.ResumeLayout(false);
            tableLayout2.ResumeLayout(false);
            tableLayout2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewFields)).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridViewDocuments)).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}