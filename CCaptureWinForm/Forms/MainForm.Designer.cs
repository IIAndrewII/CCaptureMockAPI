namespace CCaptureWinForm
{
    partial class MainForm
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
        private System.Windows.Forms.TextBox txtBatchClassName;
        private System.Windows.Forms.Label lblBatchClassName;
        private System.Windows.Forms.Panel checkStatusPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout3;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.TextBox txtStatusUserCode;
        private System.Windows.Forms.Label lblStatusUserCode;
        private System.Windows.Forms.TextBox txtStatusMessageID;
        private System.Windows.Forms.Label lblStatusMessageID;
        private System.Windows.Forms.TextBox txtStatusSessionID;
        private System.Windows.Forms.Label lblStatusSessionID;
        private System.Windows.Forms.TextBox txtStatusChannel;
        private System.Windows.Forms.Label lblStatusChannel;
        private System.Windows.Forms.TextBox txtStatusSourceSystem;
        private System.Windows.Forms.Label lblStatusSourceSystem;
        private System.Windows.Forms.TextBox txtStatusRequestGuid;
        private System.Windows.Forms.Label lblStatusRequestGuid;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panelStatusViewer;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem submitDocumentToolStripMenuItem;

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
            txtChannel = new TextBox();
            txtSourceSystem = new TextBox();
            txtBatchClassName = new TextBox();
            txtUserCode = new TextBox();
            txtMessageID = new TextBox();
            txtSessionID = new TextBox();
            txtStatusUserCode = new TextBox();
            txtStatusMessageID = new TextBox();
            txtStatusSessionID = new TextBox();
            txtStatusChannel = new TextBox();
            txtStatusSourceSystem = new TextBox();
            txtStatusRequestGuid = new TextBox();
            errorProvider = new ErrorProvider(components);
            submitPanel = new Panel();
            statusStrip2 = new StatusStrip();
            statusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            metadataPanel = new Panel();
            tableLayout2 = new TableLayoutPanel();
            lblChannel = new Label();
            lblSourceSystem = new Label();
            lblBatchClassName = new Label();
            lblUserCode = new Label();
            lblSessionID = new Label();
            lblMessageID = new Label();
            btnSubmitDocument = new Button();
            btnRemoveFile = new Button();
            btnBrowseFile = new Button();
            dataGridViewDocuments = new DataGridView();
            FilePath = new DataGridViewTextBoxColumn();
            PageType = new DataGridViewTextBoxColumn();
            lblDocuments = new Label();
            dataGridViewFields = new DataGridView();
            FieldName = new DataGridViewTextBoxColumn();
            FieldValue = new DataGridViewTextBoxColumn();
            lblFields = new Label();
            checkStatusPanel = new Panel();
            tableLayout3 = new TableLayoutPanel();
            inputPanel = new Panel();
            lblStatusUserCode = new Label();
            lblStatusMessageID = new Label();
            lblStatusSessionID = new Label();
            lblStatusChannel = new Label();
            lblStatusSourceSystem = new Label();
            lblStatusRequestGuid = new Label();
            buttonPanel = new Panel();
            btnCheckStatus = new Button();
            btnClearResults = new Button();
            progressBar = new ProgressBar();
            panelStatusViewer = new Panel();
            statusStrip3 = new StatusStrip();
            statusLabel3 = new ToolStripStatusLabel();
            mainMenuStrip = new MenuStrip();
            submitDocumentToolStripMenuItem = new ToolStripMenuItem();
            checkStatusToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            submitPanel.SuspendLayout();
            statusStrip2.SuspendLayout();
            metadataPanel.SuspendLayout();
            tableLayout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).BeginInit();
            checkStatusPanel.SuspendLayout();
            tableLayout3.SuspendLayout();
            inputPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            statusStrip3.SuspendLayout();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // txtChannel
            // 
            txtChannel.AccessibleName = "Channel";
            txtChannel.Font = new Font("Segoe UI", 12F);
            txtChannel.Location = new Point(800, 24);
            txtChannel.Margin = new Padding(3, 2, 3, 2);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(219, 29);
            txtChannel.TabIndex = 2;
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.AccessibleName = "Source System";
            txtSourceSystem.Font = new Font("Segoe UI", 12F);
            txtSourceSystem.Location = new Point(387, 24);
            txtSourceSystem.Margin = new Padding(3, 2, 3, 2);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new Size(219, 29);
            txtSourceSystem.TabIndex = 1;
            // 
            // txtBatchClassName
            // 
            txtBatchClassName.AccessibleName = "Batch Category";
            txtBatchClassName.Font = new Font("Segoe UI", 12F);
            txtBatchClassName.Location = new Point(3, 24);
            txtBatchClassName.Margin = new Padding(3, 2, 3, 2);
            txtBatchClassName.Name = "txtBatchClassName";
            txtBatchClassName.Size = new Size(219, 29);
            txtBatchClassName.TabIndex = 0;
            // 
            // txtUserCode
            // 
            txtUserCode.AccessibleName = "User ID";
            txtUserCode.Font = new Font("Segoe UI", 12F);
            txtUserCode.Location = new Point(3, 90);
            txtUserCode.Margin = new Padding(3, 2, 3, 2);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new Size(219, 29);
            txtUserCode.TabIndex = 3;
            // 
            // txtMessageID
            // 
            txtMessageID.AccessibleName = "Message ID";
            txtMessageID.Font = new Font("Segoe UI", 12F);
            txtMessageID.Location = new Point(800, 90);
            txtMessageID.Margin = new Padding(3, 2, 3, 2);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(219, 29);
            txtMessageID.TabIndex = 5;
            // 
            // txtSessionID
            // 
            txtSessionID.AccessibleName = "Session ID";
            txtSessionID.Font = new Font("Segoe UI", 12F);
            txtSessionID.Location = new Point(387, 90);
            txtSessionID.Margin = new Padding(3, 2, 3, 2);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.Size = new Size(219, 29);
            txtSessionID.TabIndex = 4;
            // 
            // txtStatusUserCode
            // 
            txtStatusUserCode.AccessibleName = "User ID";
            txtStatusUserCode.Font = new Font("Segoe UI", 12F);
            txtStatusUserCode.Location = new Point(545, 65);
            txtStatusUserCode.Margin = new Padding(3, 2, 3, 2);
            txtStatusUserCode.Name = "txtStatusUserCode";
            txtStatusUserCode.Size = new Size(219, 29);
            txtStatusUserCode.TabIndex = 5;
            // 
            // txtStatusMessageID
            // 
            txtStatusMessageID.AccessibleName = "Message ID";
            txtStatusMessageID.Font = new Font("Segoe UI", 12F);
            txtStatusMessageID.Location = new Point(279, 65);
            txtStatusMessageID.Margin = new Padding(3, 2, 3, 2);
            txtStatusMessageID.Name = "txtStatusMessageID";
            txtStatusMessageID.Size = new Size(219, 29);
            txtStatusMessageID.TabIndex = 4;
            // 
            // txtStatusSessionID
            // 
            txtStatusSessionID.AccessibleName = "Session ID";
            txtStatusSessionID.Font = new Font("Segoe UI", 12F);
            txtStatusSessionID.Location = new Point(18, 65);
            txtStatusSessionID.Margin = new Padding(3, 2, 3, 2);
            txtStatusSessionID.Name = "txtStatusSessionID";
            txtStatusSessionID.Size = new Size(219, 29);
            txtStatusSessionID.TabIndex = 3;
            // 
            // txtStatusChannel
            // 
            txtStatusChannel.AccessibleName = "Channel";
            txtStatusChannel.Font = new Font("Segoe UI", 12F);
            txtStatusChannel.Location = new Point(545, 24);
            txtStatusChannel.Margin = new Padding(3, 2, 3, 2);
            txtStatusChannel.Name = "txtStatusChannel";
            txtStatusChannel.Size = new Size(219, 29);
            txtStatusChannel.TabIndex = 2;
            // 
            // txtStatusSourceSystem
            // 
            txtStatusSourceSystem.AccessibleName = "Source System";
            txtStatusSourceSystem.Font = new Font("Segoe UI", 12F);
            txtStatusSourceSystem.Location = new Point(279, 24);
            txtStatusSourceSystem.Margin = new Padding(3, 2, 3, 2);
            txtStatusSourceSystem.Name = "txtStatusSourceSystem";
            txtStatusSourceSystem.Size = new Size(219, 29);
            txtStatusSourceSystem.TabIndex = 1;
            // 
            // txtStatusRequestGuid
            // 
            txtStatusRequestGuid.AccessibleName = "Request ID";
            txtStatusRequestGuid.Font = new Font("Segoe UI", 12F);
            txtStatusRequestGuid.Location = new Point(18, 24);
            txtStatusRequestGuid.Margin = new Padding(3, 2, 3, 2);
            txtStatusRequestGuid.Name = "txtStatusRequestGuid";
            txtStatusRequestGuid.Size = new Size(219, 29);
            txtStatusRequestGuid.TabIndex = 0;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // submitPanel
            // 
            submitPanel.Controls.Add(statusStrip2);
            submitPanel.Controls.Add(metadataPanel);
            submitPanel.Dock = DockStyle.Fill;
            submitPanel.Font = new Font("Segoe UI", 12F);
            submitPanel.Location = new Point(0, 29);
            submitPanel.Margin = new Padding(3, 2, 3, 2);
            submitPanel.Name = "submitPanel";
            submitPanel.Size = new Size(1214, 590);
            submitPanel.TabIndex = 1;
            // 
            // statusStrip2
            // 
            statusStrip2.Font = new Font("Segoe UI", 10F);
            statusStrip2.ImageScalingSize = new Size(20, 20);
            statusStrip2.Items.AddRange(new ToolStripItem[] { statusLabel2, toolStripStatusLabel1 });
            statusStrip2.Location = new Point(0, 568);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Padding = new Padding(1, 0, 10, 0);
            statusStrip2.Size = new Size(1214, 22);
            statusStrip2.TabIndex = 11;
            // 
            // statusLabel2
            // 
            statusLabel2.Name = "statusLabel2";
            statusLabel2.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // metadataPanel
            // 
            metadataPanel.Controls.Add(tableLayout2);
            metadataPanel.Dock = DockStyle.Top;
            metadataPanel.Location = new Point(0, 0);
            metadataPanel.Margin = new Padding(12, 8, 12, 2);
            metadataPanel.Name = "metadataPanel";
            metadataPanel.Size = new Size(1214, 640);
            metadataPanel.TabIndex = 9;
            // 
            // tableLayout2
            // 
            tableLayout2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayout2.ColumnCount = 3;
            tableLayout2.ColumnStyles.Add(new ColumnStyle());
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout2.Controls.Add(lblChannel, 2, 0);
            tableLayout2.Controls.Add(txtSourceSystem, 1, 1);
            tableLayout2.Controls.Add(lblSourceSystem, 1, 0);
            tableLayout2.Controls.Add(txtBatchClassName, 0, 1);
            tableLayout2.Controls.Add(lblBatchClassName, 0, 0);
            tableLayout2.Controls.Add(lblUserCode, 0, 2);
            tableLayout2.Controls.Add(txtSessionID, 1, 3);
            tableLayout2.Controls.Add(lblSessionID, 1, 2);
            tableLayout2.Controls.Add(txtMessageID, 2, 3);
            tableLayout2.Controls.Add(txtUserCode, 0, 3);
            tableLayout2.Controls.Add(txtChannel, 2, 1);
            tableLayout2.Controls.Add(lblMessageID, 2, 2);
            tableLayout2.Controls.Add(btnSubmitDocument, 2, 7);
            tableLayout2.Controls.Add(btnRemoveFile, 0, 7);
            tableLayout2.Controls.Add(btnBrowseFile, 0, 6);
            tableLayout2.Controls.Add(dataGridViewDocuments, 0, 5);
            tableLayout2.Controls.Add(lblDocuments, 0, 4);
            tableLayout2.Controls.Add(dataGridViewFields, 1, 5);
            tableLayout2.Controls.Add(lblFields, 1, 4);
            tableLayout2.Location = new Point(0, 0);
            tableLayout2.Margin = new Padding(3, 2, 3, 2);
            tableLayout2.Name = "tableLayout2";
            tableLayout2.RowCount = 8;
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.051565F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.471455F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 3.68324137F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.73480654F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.34069967F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.48803F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.1012888F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1289139F));
            tableLayout2.Size = new Size(1211, 549);
            tableLayout2.TabIndex = 0;
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Font = new Font("Segoe UI", 12F);
            lblChannel.Location = new Point(800, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(70, 21);
            lblChannel.TabIndex = 0;
            lblChannel.Text = "Channel:";
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new Font("Segoe UI", 12F);
            lblSourceSystem.Location = new Point(387, 0);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new Size(116, 21);
            lblSourceSystem.TabIndex = 0;
            lblSourceSystem.Text = "Source System:";
            // 
            // lblBatchClassName
            // 
            lblBatchClassName.AutoSize = true;
            lblBatchClassName.Font = new Font("Segoe UI", 12F);
            lblBatchClassName.Location = new Point(3, 0);
            lblBatchClassName.Name = "lblBatchClassName";
            lblBatchClassName.Size = new Size(137, 21);
            lblBatchClassName.TabIndex = 0;
            lblBatchClassName.Text = "Batch Class Name:";
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new Font("Segoe UI", 12F);
            lblUserCode.Location = new Point(3, 68);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new Size(64, 20);
            lblUserCode.TabIndex = 0;
            lblUserCode.Text = "User ID:";
            // 
            // lblSessionID
            // 
            lblSessionID.AutoSize = true;
            lblSessionID.Font = new Font("Segoe UI", 12F);
            lblSessionID.Location = new Point(387, 68);
            lblSessionID.Name = "lblSessionID";
            lblSessionID.Size = new Size(85, 20);
            lblSessionID.TabIndex = 0;
            lblSessionID.Text = "Session ID:";
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Font = new Font("Segoe UI", 12F);
            lblMessageID.Location = new Point(800, 68);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(93, 20);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // btnSubmitDocument
            // 
            btnSubmitDocument.BackColor = Color.FromArgb(40, 167, 69);
            btnSubmitDocument.FlatStyle = FlatStyle.Flat;
            btnSubmitDocument.Font = new Font("Segoe UI", 12F);
            btnSubmitDocument.ForeColor = Color.White;
            btnSubmitDocument.Location = new Point(800, 492);
            btnSubmitDocument.Margin = new Padding(3, 2, 3, 2);
            btnSubmitDocument.Name = "btnSubmitDocument";
            btnSubmitDocument.Size = new Size(183, 32);
            btnSubmitDocument.TabIndex = 17;
            btnSubmitDocument.Text = "Submit Documents";
            btnSubmitDocument.UseVisualStyleBackColor = false;
            // 
            // btnRemoveFile
            // 
            btnRemoveFile.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveFile.FlatStyle = FlatStyle.Flat;
            btnRemoveFile.Font = new Font("Segoe UI", 12F);
            btnRemoveFile.ForeColor = Color.White;
            btnRemoveFile.Location = new Point(3, 492);
            btnRemoveFile.Margin = new Padding(3, 2, 3, 2);
            btnRemoveFile.Name = "btnRemoveFile";
            btnRemoveFile.Size = new Size(143, 32);
            btnRemoveFile.TabIndex = 16;
            btnRemoveFile.Text = "Remove Selected";
            btnRemoveFile.UseVisualStyleBackColor = false;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBrowseFile.BackColor = Color.FromArgb(0, 120, 215);
            btnBrowseFile.FlatStyle = FlatStyle.Flat;
            btnBrowseFile.Font = new Font("Segoe UI", 12F);
            btnBrowseFile.ForeColor = Color.White;
            btnBrowseFile.Location = new Point(3, 456);
            btnBrowseFile.Margin = new Padding(3, 2, 3, 2);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(154, 32);
            btnBrowseFile.TabIndex = 15;
            btnBrowseFile.Text = "Add Files";
            btnBrowseFile.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDocuments
            // 
            dataGridViewDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocuments.Columns.AddRange(new DataGridViewColumn[] { FilePath, PageType });
            dataGridViewDocuments.Font = new Font("Segoe UI", 12F);
            dataGridViewDocuments.Location = new Point(3, 161);
            dataGridViewDocuments.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDocuments.Name = "dataGridViewDocuments";
            dataGridViewDocuments.RowHeadersWidth = 51;
            dataGridViewDocuments.Size = new Size(378, 243);
            dataGridViewDocuments.TabIndex = 13;
            // 
            // FilePath
            // 
            FilePath.HeaderText = "File Path";
            FilePath.MinimumWidth = 6;
            FilePath.Name = "FilePath";
            // 
            // PageType
            // 
            PageType.HeaderText = "Page Type";
            PageType.MinimumWidth = 6;
            PageType.Name = "PageType";
            // 
            // lblDocuments
            // 
            lblDocuments.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDocuments.AutoSize = true;
            lblDocuments.Font = new Font("Segoe UI", 12F);
            lblDocuments.Location = new Point(3, 138);
            lblDocuments.Name = "lblDocuments";
            lblDocuments.Size = new Size(113, 21);
            lblDocuments.TabIndex = 12;
            lblDocuments.Text = "Document List:";
            // 
            // dataGridViewFields
            // 
            dataGridViewFields.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFields.Columns.AddRange(new DataGridViewColumn[] { FieldName, FieldValue });
            dataGridViewFields.Font = new Font("Segoe UI", 12F);
            dataGridViewFields.Location = new Point(387, 161);
            dataGridViewFields.Margin = new Padding(3, 2, 3, 2);
            dataGridViewFields.Name = "dataGridViewFields";
            dataGridViewFields.RowHeadersWidth = 51;
            dataGridViewFields.Size = new Size(379, 243);
            dataGridViewFields.TabIndex = 14;
            // 
            // FieldName
            // 
            FieldName.HeaderText = "Field Name";
            FieldName.MinimumWidth = 6;
            FieldName.Name = "FieldName";
            // 
            // FieldValue
            // 
            FieldValue.HeaderText = "Field Value";
            FieldValue.MinimumWidth = 6;
            FieldValue.Name = "FieldValue";
            // 
            // lblFields
            // 
            lblFields.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFields.AutoSize = true;
            lblFields.Font = new Font("Segoe UI", 12F);
            lblFields.Location = new Point(387, 138);
            lblFields.Name = "lblFields";
            lblFields.Size = new Size(82, 21);
            lblFields.TabIndex = 11;
            lblFields.Text = "Field Data:";
            // 
            // checkStatusPanel
            // 
            checkStatusPanel.Controls.Add(tableLayout3);
            checkStatusPanel.Dock = DockStyle.Fill;
            checkStatusPanel.Font = new Font("Segoe UI", 12F);
            checkStatusPanel.Location = new Point(0, 29);
            checkStatusPanel.Margin = new Padding(3, 2, 3, 2);
            checkStatusPanel.Name = "checkStatusPanel";
            checkStatusPanel.Size = new Size(1214, 590);
            checkStatusPanel.TabIndex = 2;
            checkStatusPanel.Visible = false;
            // 
            // tableLayout3
            // 
            tableLayout3.ColumnCount = 1;
            tableLayout3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout3.Controls.Add(inputPanel, 0, 0);
            tableLayout3.Controls.Add(buttonPanel, 0, 1);
            tableLayout3.Controls.Add(panelStatusViewer, 0, 2);
            tableLayout3.Controls.Add(statusStrip3, 0, 3);
            tableLayout3.Dock = DockStyle.Fill;
            tableLayout3.Location = new Point(0, 0);
            tableLayout3.Margin = new Padding(3, 2, 3, 2);
            tableLayout3.Name = "tableLayout3";
            tableLayout3.RowCount = 4;
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayout3.Size = new Size(1214, 590);
            tableLayout3.TabIndex = 0;
            // 
            // inputPanel
            // 
            inputPanel.Controls.Add(txtStatusUserCode);
            inputPanel.Controls.Add(lblStatusUserCode);
            inputPanel.Controls.Add(txtStatusMessageID);
            inputPanel.Controls.Add(lblStatusMessageID);
            inputPanel.Controls.Add(txtStatusSessionID);
            inputPanel.Controls.Add(lblStatusSessionID);
            inputPanel.Controls.Add(txtStatusChannel);
            inputPanel.Controls.Add(lblStatusChannel);
            inputPanel.Controls.Add(txtStatusSourceSystem);
            inputPanel.Controls.Add(lblStatusSourceSystem);
            inputPanel.Controls.Add(txtStatusRequestGuid);
            inputPanel.Controls.Add(lblStatusRequestGuid);
            inputPanel.Dock = DockStyle.Fill;
            inputPanel.Location = new Point(3, 2);
            inputPanel.Margin = new Padding(3, 2, 3, 2);
            inputPanel.Name = "inputPanel";
            inputPanel.Size = new Size(1208, 86);
            inputPanel.TabIndex = 0;
            // 
            // lblStatusUserCode
            // 
            lblStatusUserCode.AutoSize = true;
            lblStatusUserCode.Font = new Font("Segoe UI", 12F);
            lblStatusUserCode.Location = new Point(545, 43);
            lblStatusUserCode.Name = "lblStatusUserCode";
            lblStatusUserCode.Size = new Size(64, 21);
            lblStatusUserCode.TabIndex = 0;
            lblStatusUserCode.Text = "User ID:";
            // 
            // lblStatusMessageID
            // 
            lblStatusMessageID.AutoSize = true;
            lblStatusMessageID.Font = new Font("Segoe UI", 12F);
            lblStatusMessageID.Location = new Point(279, 43);
            lblStatusMessageID.Name = "lblStatusMessageID";
            lblStatusMessageID.Size = new Size(93, 21);
            lblStatusMessageID.TabIndex = 0;
            lblStatusMessageID.Text = "Message ID:";
            // 
            // lblStatusSessionID
            // 
            lblStatusSessionID.AutoSize = true;
            lblStatusSessionID.Font = new Font("Segoe UI", 12F);
            lblStatusSessionID.Location = new Point(18, 43);
            lblStatusSessionID.Name = "lblStatusSessionID";
            lblStatusSessionID.Size = new Size(85, 21);
            lblStatusSessionID.TabIndex = 0;
            lblStatusSessionID.Text = "Session ID:";
            // 
            // lblStatusChannel
            // 
            lblStatusChannel.AutoSize = true;
            lblStatusChannel.Font = new Font("Segoe UI", 12F);
            lblStatusChannel.Location = new Point(545, 5);
            lblStatusChannel.Name = "lblStatusChannel";
            lblStatusChannel.Size = new Size(70, 21);
            lblStatusChannel.TabIndex = 0;
            lblStatusChannel.Text = "Channel:";
            // 
            // lblStatusSourceSystem
            // 
            lblStatusSourceSystem.AutoSize = true;
            lblStatusSourceSystem.Font = new Font("Segoe UI", 12F);
            lblStatusSourceSystem.Location = new Point(279, 5);
            lblStatusSourceSystem.Name = "lblStatusSourceSystem";
            lblStatusSourceSystem.Size = new Size(116, 21);
            lblStatusSourceSystem.TabIndex = 0;
            lblStatusSourceSystem.Text = "Source System:";
            // 
            // lblStatusRequestGuid
            // 
            lblStatusRequestGuid.AutoSize = true;
            lblStatusRequestGuid.Font = new Font("Segoe UI", 12F);
            lblStatusRequestGuid.Location = new Point(18, 5);
            lblStatusRequestGuid.Name = "lblStatusRequestGuid";
            lblStatusRequestGuid.Size = new Size(88, 21);
            lblStatusRequestGuid.TabIndex = 0;
            lblStatusRequestGuid.Text = "Request ID:";
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(btnCheckStatus);
            buttonPanel.Controls.Add(btnClearResults);
            buttonPanel.Controls.Add(progressBar);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(3, 92);
            buttonPanel.Margin = new Padding(3, 2, 3, 2);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(1208, 34);
            buttonPanel.TabIndex = 1;
            // 
            // btnCheckStatus
            // 
            btnCheckStatus.BackColor = Color.FromArgb(0, 120, 215);
            btnCheckStatus.FlatStyle = FlatStyle.Flat;
            btnCheckStatus.Font = new Font("Segoe UI", 12F);
            btnCheckStatus.ForeColor = Color.White;
            btnCheckStatus.Location = new Point(18, 9);
            btnCheckStatus.Margin = new Padding(3, 2, 3, 2);
            btnCheckStatus.Name = "btnCheckStatus";
            btnCheckStatus.Size = new Size(201, 27);
            btnCheckStatus.TabIndex = 5;
            btnCheckStatus.Text = "Check Status";
            btnCheckStatus.UseVisualStyleBackColor = false;
            // 
            // btnClearResults
            // 
            btnClearResults.BackColor = Color.FromArgb(108, 117, 125);
            btnClearResults.FlatStyle = FlatStyle.Flat;
            btnClearResults.Font = new Font("Segoe UI", 12F);
            btnClearResults.ForeColor = Color.White;
            btnClearResults.Location = new Point(224, 9);
            btnClearResults.Margin = new Padding(3, 2, 3, 2);
            btnClearResults.Name = "btnClearResults";
            btnClearResults.Size = new Size(201, 27);
            btnClearResults.TabIndex = 6;
            btnClearResults.Text = "Clear Results";
            btnClearResults.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(494, 14);
            progressBar.Margin = new Padding(3, 2, 3, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(250, 15);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 7;
            progressBar.Visible = false;
            // 
            // panelStatusViewer
            // 
            panelStatusViewer.BorderStyle = BorderStyle.FixedSingle;
            panelStatusViewer.Dock = DockStyle.Fill;
            panelStatusViewer.Location = new Point(3, 130);
            panelStatusViewer.Margin = new Padding(3, 2, 3, 2);
            panelStatusViewer.Name = "panelStatusViewer";
            panelStatusViewer.Size = new Size(1208, 436);
            panelStatusViewer.TabIndex = 8;
            // 
            // statusStrip3
            // 
            statusStrip3.Font = new Font("Segoe UI", 10F);
            statusStrip3.ImageScalingSize = new Size(20, 20);
            statusStrip3.Items.AddRange(new ToolStripItem[] { statusLabel3 });
            statusStrip3.Location = new Point(0, 568);
            statusStrip3.Name = "statusStrip3";
            statusStrip3.Padding = new Padding(1, 0, 10, 0);
            statusStrip3.Size = new Size(1214, 22);
            statusStrip3.TabIndex = 9;
            // 
            // statusLabel3
            // 
            statusLabel3.Name = "statusLabel3";
            statusLabel3.Size = new Size(0, 17);
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Font = new Font("Segoe UI", 8F);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { submitDocumentToolStripMenuItem, checkStatusToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Padding = new Padding(5, 2, 0, 10);
            mainMenuStrip.Size = new Size(1214, 29);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "mainMenuStrip";
            // 
            // submitDocumentToolStripMenuItem
            // 
            submitDocumentToolStripMenuItem.Name = "submitDocumentToolStripMenuItem";
            submitDocumentToolStripMenuItem.Size = new Size(111, 17);
            submitDocumentToolStripMenuItem.Text = "Submit Document";
            // 
            // checkStatusToolStripMenuItem
            // 
            checkStatusToolStripMenuItem.Name = "checkStatusToolStripMenuItem";
            checkStatusToolStripMenuItem.Size = new Size(85, 17);
            checkStatusToolStripMenuItem.Text = "Check Status";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1214, 619);
            Controls.Add(submitPanel);
            Controls.Add(checkStatusPanel);
            Controls.Add(mainMenuStrip);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(702, 385);
            Name = "MainForm";
            Text = "CCapture Mock API Client";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            submitPanel.ResumeLayout(false);
            submitPanel.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            metadataPanel.ResumeLayout(false);
            tableLayout2.ResumeLayout(false);
            tableLayout2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).EndInit();
            checkStatusPanel.ResumeLayout(false);
            tableLayout3.ResumeLayout(false);
            tableLayout3.PerformLayout();
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            statusStrip3.ResumeLayout(false);
            statusStrip3.PerformLayout();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private ToolStripMenuItem checkStatusToolStripMenuItem;
        private Button btnBrowseFile;
        private DataGridView dataGridViewFields;
        private DataGridViewTextBoxColumn FieldName;
        private DataGridViewTextBoxColumn FieldValue;
        private Label lblFields;
        private DataGridView dataGridViewDocuments;
        private DataGridViewTextBoxColumn FilePath;
        private DataGridViewTextBoxColumn PageType;
        private Label lblDocuments;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel statusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip3;
        private ToolStripStatusLabel statusLabel3;
        private Button btnSubmitDocument;
        private Button btnRemoveFile;
    }
}