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
        private System.Windows.Forms.ComboBox cboBatchClassName;
        private System.Windows.Forms.Label lblBatchClassName;
        private System.Windows.Forms.ComboBox cboGroups;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.Panel checkStatusPanel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage submitTab;
        private System.Windows.Forms.TabPage checkStatusTab;

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
            cboBatchClassName = new ComboBox();
            txtUserCode = new TextBox();
            txtMessageID = new TextBox();
            txtSessionID = new TextBox();
            cboGroups = new ComboBox();
            btnRemoveGroup = new Button();
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
            lblInteractionDate = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAddGroup = new Button();
            lblDocuments = new Label();
            dataGridViewDocuments = new DataGridView();
            FilePath = new DataGridViewTextBoxColumn();
            PageType = new DataGridViewTextBoxColumn();
            dataGridViewFields = new DataGridView();
            FieldName = new DataGridViewTextBoxColumn();
            FieldValue = new DataGridViewTextBoxColumn();
            lblFields = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnBrowseFile = new Button();
            btnRemoveFile = new Button();
            btnSubmitDocument = new Button();
            checkStatusPanel = new Panel();
            tableLayout3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtStatusUserCode = new TextBox();
            txtStatusMessageID = new TextBox();
            lblStatusUserCode = new Label();
            txtStatusSessionID = new TextBox();
            lblStatusMessageID = new Label();
            lblStatusChannel = new Label();
            lblStatusSessionID = new Label();
            txtStatusChannel = new TextBox();
            txtStatusSourceSystem = new TextBox();
            lblStatusSourceSystem = new Label();
            lblStatusRequestGuid = new Label();
            txtStatusRequestGuid = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            buttonPanel = new Panel();
            btnCheckStatus = new Button();
            btnClearResults = new Button();
            progressBar = new ProgressBar();
            panelStatusViewer = new Panel();
            tabControl = new TabControl();
            submitTab = new TabPage();
            checkStatusTab = new TabPage();
            miniToolStrip = new StatusStrip();
            statusLabel3 = new ToolStripStatusLabel();
            statusStrip3 = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            submitPanel.SuspendLayout();
            statusStrip2.SuspendLayout();
            metadataPanel.SuspendLayout();
            tableLayout2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            checkStatusPanel.SuspendLayout();
            tableLayout3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            buttonPanel.SuspendLayout();
            tabControl.SuspendLayout();
            submitTab.SuspendLayout();
            checkStatusTab.SuspendLayout();
            statusStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // txtChannel
            // 
            txtChannel.AccessibleName = "Channel";
            txtChannel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtChannel.Font = new Font("Segoe UI", 12F);
            txtChannel.Location = new Point(915, 32);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(405, 34);
            txtChannel.TabIndex = 2;
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.AccessibleName = "Source System";
            txtSourceSystem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSourceSystem.Font = new Font("Segoe UI", 12F);
            txtSourceSystem.Location = new Point(459, 32);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new Size(405, 34);
            txtSourceSystem.TabIndex = 1;
            // 
            // cboBatchClassName
            // 
            cboBatchClassName.AccessibleName = "Batch Category";
            cboBatchClassName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboBatchClassName.Font = new Font("Segoe UI", 12F);
            cboBatchClassName.FormattingEnabled = true;
            cboBatchClassName.Location = new Point(3, 31);
            cboBatchClassName.Name = "cboBatchClassName";
            cboBatchClassName.Size = new Size(405, 36);
            cboBatchClassName.TabIndex = 0;
            // 
            // txtUserCode
            // 
            txtUserCode.AccessibleName = "User ID";
            txtUserCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUserCode.Font = new Font("Segoe UI", 12F);
            txtUserCode.Location = new Point(3, 101);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new Size(405, 34);
            txtUserCode.TabIndex = 3;
            // 
            // txtMessageID
            // 
            txtMessageID.AccessibleName = "Message ID";
            txtMessageID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMessageID.Font = new Font("Segoe UI", 12F);
            txtMessageID.Location = new Point(915, 101);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(405, 34);
            txtMessageID.TabIndex = 5;
            // 
            // txtSessionID
            // 
            txtSessionID.AccessibleName = "Session ID";
            txtSessionID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSessionID.Font = new Font("Segoe UI", 12F);
            txtSessionID.Location = new Point(459, 101);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.Size = new Size(405, 34);
            txtSessionID.TabIndex = 4;
            // 
            // cboGroups
            // 
            cboGroups.AccessibleName = "Document Group";
            cboGroups.Anchor = AnchorStyles.Left;
            cboGroups.Font = new Font("Segoe UI", 12F);
            cboGroups.FormattingEnabled = true;
            cboGroups.Location = new Point(3, 35);
            cboGroups.Name = "cboGroups";
            cboGroups.Size = new Size(168, 36);
            cboGroups.TabIndex = 10;
            // 
            // btnRemoveGroup
            // 
            btnRemoveGroup.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveGroup.FlatStyle = FlatStyle.Flat;
            btnRemoveGroup.Font = new Font("Segoe UI", 12F);
            btnRemoveGroup.ForeColor = Color.White;
            btnRemoveGroup.Location = new Point(196, 32);
            btnRemoveGroup.Name = "btnRemoveGroup";
            btnRemoveGroup.Size = new Size(163, 41);
            btnRemoveGroup.TabIndex = 12;
            btnRemoveGroup.Text = "Remove Group";
            btnRemoveGroup.UseVisualStyleBackColor = false;
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
            submitPanel.Location = new Point(3, 4);
            submitPanel.Name = "submitPanel";
            submitPanel.Size = new Size(1373, 781);
            submitPanel.TabIndex = 1;
            // 
            // statusStrip2
            // 
            statusStrip2.Font = new Font("Segoe UI", 10F);
            statusStrip2.ImageScalingSize = new Size(20, 20);
            statusStrip2.Items.AddRange(new ToolStripItem[] { statusLabel2, toolStripStatusLabel1 });
            statusStrip2.Location = new Point(0, 759);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Padding = new Padding(1, 0, 11, 0);
            statusStrip2.Size = new Size(1373, 22);
            statusStrip2.TabIndex = 11;
            // 
            // statusLabel2
            // 
            statusLabel2.Name = "statusLabel2";
            statusLabel2.Size = new Size(0, 16);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 16);
            // 
            // metadataPanel
            // 
            metadataPanel.Controls.Add(tableLayout2);
            metadataPanel.Dock = DockStyle.Top;
            metadataPanel.Location = new Point(0, 0);
            metadataPanel.Margin = new Padding(14, 11, 14, 3);
            metadataPanel.Name = "metadataPanel";
            metadataPanel.Size = new Size(1373, 812);
            metadataPanel.TabIndex = 9;
            // 
            // tableLayout2
            // 
            tableLayout2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayout2.ColumnCount = 6;
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0030022F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.33033323F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0030022F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.33033323F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0030022F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.33033323F));
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
            tableLayout2.Controls.Add(lblInteractionDate, 0, 5);
            tableLayout2.Controls.Add(textBox1, 0, 6);
            tableLayout2.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayout2.Controls.Add(dataGridViewDocuments, 0, 8);
            tableLayout2.Controls.Add(dataGridViewFields, 4, 8);
            tableLayout2.Controls.Add(lblFields, 4, 7);
            tableLayout2.Controls.Add(tableLayoutPanel3, 2, 8);
            tableLayout2.Controls.Add(btnSubmitDocument, 4, 10);
            tableLayout2.Location = new Point(0, 0);
            tableLayout2.Name = "tableLayout2";
            tableLayout2.RowCount = 12;
            tableLayout2.RowStyles.Add(new RowStyle());
            tableLayout2.RowStyles.Add(new RowStyle());
            tableLayout2.RowStyles.Add(new RowStyle());
            tableLayout2.RowStyles.Add(new RowStyle());
            tableLayout2.RowStyles.Add(new RowStyle());
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 39.9425278F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 44.54023F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7166166F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout2.Size = new Size(1370, 756);
            tableLayout2.TabIndex = 0;
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Font = new Font("Segoe UI", 12F);
            lblChannel.Location = new Point(915, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(86, 28);
            lblChannel.TabIndex = 0;
            lblChannel.Text = "Channel:";
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new Font("Segoe UI", 12F);
            lblSourceSystem.Location = new Point(459, 0);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new Size(143, 28);
            lblSourceSystem.TabIndex = 0;
            lblSourceSystem.Text = "Source System:";
            // 
            // lblBatchClassName
            // 
            lblBatchClassName.AutoSize = true;
            lblBatchClassName.Font = new Font("Segoe UI", 12F);
            lblBatchClassName.Location = new Point(3, 0);
            lblBatchClassName.Name = "lblBatchClassName";
            lblBatchClassName.Size = new Size(149, 28);
            lblBatchClassName.TabIndex = 0;
            lblBatchClassName.Text = "Batch Category:";
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new Font("Segoe UI", 12F);
            lblUserCode.Location = new Point(3, 70);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new Size(79, 28);
            lblUserCode.TabIndex = 0;
            lblUserCode.Text = "User ID:";
            // 
            // lblSessionID
            // 
            lblSessionID.AutoSize = true;
            lblSessionID.Font = new Font("Segoe UI", 12F);
            lblSessionID.Location = new Point(459, 70);
            lblSessionID.Name = "lblSessionID";
            lblSessionID.Size = new Size(105, 28);
            lblSessionID.TabIndex = 0;
            lblSessionID.Text = "Session ID:";
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Font = new Font("Segoe UI", 12F);
            lblMessageID.Location = new Point(915, 70);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(116, 28);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // lblInteractionDate
            // 
            lblInteractionDate.AutoSize = true;
            lblInteractionDate.Font = new Font("Segoe UI", 12F);
            lblInteractionDate.Location = new Point(3, 138);
            lblInteractionDate.Name = "lblInteractionDate";
            lblInteractionDate.Size = new Size(206, 28);
            lblInteractionDate.TabIndex = 19;
            lblInteractionDate.Text = "Interaction Date-Time:";
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "Message ID";
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(3, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 34);
            textBox1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 193F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(cboGroups, 0, 1);
            tableLayoutPanel2.Controls.Add(btnAddGroup, 0, 2);
            tableLayoutPanel2.Controls.Add(btnRemoveGroup, 1, 1);
            tableLayoutPanel2.Controls.Add(lblDocuments, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 288);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5772362F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 39.8374F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35.3383446F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(405, 123);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // btnAddGroup
            // 
            btnAddGroup.BackColor = Color.FromArgb(0, 120, 215);
            btnAddGroup.FlatStyle = FlatStyle.Flat;
            btnAddGroup.Font = new Font("Segoe UI", 12F);
            btnAddGroup.ForeColor = Color.White;
            btnAddGroup.Location = new Point(3, 81);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(186, 39);
            btnAddGroup.TabIndex = 20;
            btnAddGroup.Text = "Add New Group";
            btnAddGroup.UseVisualStyleBackColor = false;
            // 
            // lblDocuments
            // 
            lblDocuments.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDocuments.AutoSize = true;
            lblDocuments.Font = new Font("Segoe UI", 12F);
            lblDocuments.Location = new Point(3, 1);
            lblDocuments.Name = "lblDocuments";
            lblDocuments.Size = new Size(168, 28);
            lblDocuments.TabIndex = 12;
            lblDocuments.Text = "Document Group:";
            // 
            // dataGridViewDocuments
            // 
            dataGridViewDocuments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocuments.Columns.AddRange(new DataGridViewColumn[] { FilePath, PageType });
            dataGridViewDocuments.Font = new Font("Segoe UI", 12F);
            dataGridViewDocuments.Location = new Point(3, 417);
            dataGridViewDocuments.Name = "dataGridViewDocuments";
            dataGridViewDocuments.RowHeadersWidth = 51;
            dataGridViewDocuments.Size = new Size(405, 190);
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
            // dataGridViewFields
            // 
            dataGridViewFields.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFields.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFields.Columns.AddRange(new DataGridViewColumn[] { FieldName, FieldValue });
            dataGridViewFields.Font = new Font("Segoe UI", 12F);
            dataGridViewFields.Location = new Point(915, 417);
            dataGridViewFields.Name = "dataGridViewFields";
            dataGridViewFields.RowHeadersWidth = 51;
            dataGridViewFields.Size = new Size(405, 190);
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
            lblFields.Location = new Point(915, 386);
            lblFields.Name = "lblFields";
            lblFields.Size = new Size(104, 28);
            lblFields.TabIndex = 11;
            lblFields.Text = "Field Data:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnBrowseFile, 0, 0);
            tableLayoutPanel3.Controls.Add(btnRemoveFile, 0, 1);
            tableLayoutPanel3.Location = new Point(459, 517);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(183, 90);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBrowseFile.BackColor = Color.FromArgb(0, 120, 215);
            btnBrowseFile.FlatStyle = FlatStyle.Flat;
            btnBrowseFile.Font = new Font("Segoe UI", 12F);
            btnBrowseFile.ForeColor = Color.White;
            btnBrowseFile.Location = new Point(3, 3);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(176, 39);
            btnBrowseFile.TabIndex = 15;
            btnBrowseFile.Text = "Add Files";
            btnBrowseFile.UseVisualStyleBackColor = false;
            // 
            // btnRemoveFile
            // 
            btnRemoveFile.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveFile.FlatStyle = FlatStyle.Flat;
            btnRemoveFile.Font = new Font("Segoe UI", 12F);
            btnRemoveFile.ForeColor = Color.White;
            btnRemoveFile.Location = new Point(3, 48);
            btnRemoveFile.Name = "btnRemoveFile";
            btnRemoveFile.Size = new Size(176, 39);
            btnRemoveFile.TabIndex = 16;
            btnRemoveFile.Text = "Remove File";
            btnRemoveFile.UseVisualStyleBackColor = false;
            // 
            // btnSubmitDocument
            // 
            btnSubmitDocument.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitDocument.BackColor = Color.FromArgb(40, 167, 69);
            btnSubmitDocument.FlatStyle = FlatStyle.Flat;
            btnSubmitDocument.Font = new Font("Segoe UI", 12F);
            btnSubmitDocument.ForeColor = Color.White;
            btnSubmitDocument.Location = new Point(1047, 645);
            btnSubmitDocument.Name = "btnSubmitDocument";
            btnSubmitDocument.Size = new Size(273, 50);
            btnSubmitDocument.TabIndex = 17;
            btnSubmitDocument.Text = "Submit Documents";
            btnSubmitDocument.UseVisualStyleBackColor = false;
            // 
            // checkStatusPanel
            // 
            checkStatusPanel.Controls.Add(tableLayout3);
            checkStatusPanel.Dock = DockStyle.Fill;
            checkStatusPanel.Font = new Font("Segoe UI", 12F);
            checkStatusPanel.Location = new Point(3, 4);
            checkStatusPanel.Name = "checkStatusPanel";
            checkStatusPanel.Size = new Size(1373, 781);
            checkStatusPanel.TabIndex = 2;
            // 
            // tableLayout3
            // 
            tableLayout3.ColumnCount = 1;
            tableLayout3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout3.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayout3.Controls.Add(buttonPanel, 0, 1);
            tableLayout3.Controls.Add(panelStatusViewer, 0, 2);
            tableLayout3.Dock = DockStyle.Fill;
            tableLayout3.Location = new Point(0, 0);
            tableLayout3.Name = "tableLayout3";
            tableLayout3.RowCount = 4;
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 226F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayout3.Size = new Size(1373, 781);
            tableLayout3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0015659F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.330174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.00157F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.330174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.00157F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.334944F));
            tableLayoutPanel1.Controls.Add(txtStatusUserCode, 4, 3);
            tableLayoutPanel1.Controls.Add(txtStatusMessageID, 2, 3);
            tableLayoutPanel1.Controls.Add(lblStatusUserCode, 4, 2);
            tableLayoutPanel1.Controls.Add(txtStatusSessionID, 0, 3);
            tableLayoutPanel1.Controls.Add(lblStatusMessageID, 2, 2);
            tableLayoutPanel1.Controls.Add(lblStatusChannel, 4, 0);
            tableLayoutPanel1.Controls.Add(lblStatusSessionID, 0, 2);
            tableLayoutPanel1.Controls.Add(txtStatusChannel, 4, 1);
            tableLayoutPanel1.Controls.Add(txtStatusSourceSystem, 2, 1);
            tableLayoutPanel1.Controls.Add(lblStatusSourceSystem, 2, 0);
            tableLayoutPanel1.Controls.Add(lblStatusRequestGuid, 0, 0);
            tableLayoutPanel1.Controls.Add(txtStatusRequestGuid, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 5);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1367, 220);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // txtStatusUserCode
            // 
            txtStatusUserCode.AccessibleName = "User ID";
            txtStatusUserCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStatusUserCode.Font = new Font("Segoe UI", 12F);
            txtStatusUserCode.Location = new Point(913, 99);
            txtStatusUserCode.Name = "txtStatusUserCode";
            txtStatusUserCode.Size = new Size(404, 34);
            txtStatusUserCode.TabIndex = 5;
            // 
            // txtStatusMessageID
            // 
            txtStatusMessageID.AccessibleName = "Message ID";
            txtStatusMessageID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStatusMessageID.Font = new Font("Segoe UI", 12F);
            txtStatusMessageID.Location = new Point(458, 99);
            txtStatusMessageID.Name = "txtStatusMessageID";
            txtStatusMessageID.Size = new Size(404, 34);
            txtStatusMessageID.TabIndex = 4;
            // 
            // lblStatusUserCode
            // 
            lblStatusUserCode.AutoSize = true;
            lblStatusUserCode.Font = new Font("Segoe UI", 12F);
            lblStatusUserCode.Location = new Point(913, 68);
            lblStatusUserCode.Name = "lblStatusUserCode";
            lblStatusUserCode.Size = new Size(79, 28);
            lblStatusUserCode.TabIndex = 0;
            lblStatusUserCode.Text = "User ID:";
            // 
            // txtStatusSessionID
            // 
            txtStatusSessionID.AccessibleName = "Session ID";
            txtStatusSessionID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStatusSessionID.Font = new Font("Segoe UI", 12F);
            txtStatusSessionID.Location = new Point(3, 99);
            txtStatusSessionID.Name = "txtStatusSessionID";
            txtStatusSessionID.Size = new Size(404, 34);
            txtStatusSessionID.TabIndex = 3;
            // 
            // lblStatusMessageID
            // 
            lblStatusMessageID.AutoSize = true;
            lblStatusMessageID.Font = new Font("Segoe UI", 12F);
            lblStatusMessageID.Location = new Point(458, 68);
            lblStatusMessageID.Name = "lblStatusMessageID";
            lblStatusMessageID.Size = new Size(116, 28);
            lblStatusMessageID.TabIndex = 0;
            lblStatusMessageID.Text = "Message ID:";
            // 
            // lblStatusChannel
            // 
            lblStatusChannel.AutoSize = true;
            lblStatusChannel.Font = new Font("Segoe UI", 12F);
            lblStatusChannel.Location = new Point(913, 0);
            lblStatusChannel.Name = "lblStatusChannel";
            lblStatusChannel.Size = new Size(86, 28);
            lblStatusChannel.TabIndex = 0;
            lblStatusChannel.Text = "Channel:";
            // 
            // lblStatusSessionID
            // 
            lblStatusSessionID.AutoSize = true;
            lblStatusSessionID.Font = new Font("Segoe UI", 12F);
            lblStatusSessionID.Location = new Point(3, 68);
            lblStatusSessionID.Name = "lblStatusSessionID";
            lblStatusSessionID.Size = new Size(105, 28);
            lblStatusSessionID.TabIndex = 0;
            lblStatusSessionID.Text = "Session ID:";
            // 
            // txtStatusChannel
            // 
            txtStatusChannel.AccessibleName = "Channel";
            txtStatusChannel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStatusChannel.Font = new Font("Segoe UI", 12F);
            txtStatusChannel.Location = new Point(913, 31);
            txtStatusChannel.Name = "txtStatusChannel";
            txtStatusChannel.Size = new Size(404, 34);
            txtStatusChannel.TabIndex = 2;
            // 
            // txtStatusSourceSystem
            // 
            txtStatusSourceSystem.AccessibleName = "Source System";
            txtStatusSourceSystem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStatusSourceSystem.Font = new Font("Segoe UI", 12F);
            txtStatusSourceSystem.Location = new Point(458, 31);
            txtStatusSourceSystem.Name = "txtStatusSourceSystem";
            txtStatusSourceSystem.Size = new Size(404, 34);
            txtStatusSourceSystem.TabIndex = 1;
            // 
            // lblStatusSourceSystem
            // 
            lblStatusSourceSystem.AutoSize = true;
            lblStatusSourceSystem.Font = new Font("Segoe UI", 12F);
            lblStatusSourceSystem.Location = new Point(458, 0);
            lblStatusSourceSystem.Name = "lblStatusSourceSystem";
            lblStatusSourceSystem.Size = new Size(143, 28);
            lblStatusSourceSystem.TabIndex = 0;
            lblStatusSourceSystem.Text = "Source System:";
            // 
            // lblStatusRequestGuid
            // 
            lblStatusRequestGuid.AutoSize = true;
            lblStatusRequestGuid.Font = new Font("Segoe UI", 12F);
            lblStatusRequestGuid.Location = new Point(3, 0);
            lblStatusRequestGuid.Name = "lblStatusRequestGuid";
            lblStatusRequestGuid.Size = new Size(109, 28);
            lblStatusRequestGuid.TabIndex = 0;
            lblStatusRequestGuid.Text = "Request ID:";
            // 
            // txtStatusRequestGuid
            // 
            txtStatusRequestGuid.AccessibleName = "Request ID";
            txtStatusRequestGuid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStatusRequestGuid.Font = new Font("Segoe UI", 12F);
            txtStatusRequestGuid.Location = new Point(3, 31);
            txtStatusRequestGuid.Name = "txtStatusRequestGuid";
            txtStatusRequestGuid.Size = new Size(404, 34);
            txtStatusRequestGuid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 136);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 19;
            label1.Text = "Interaction Date-Time:";
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "User ID";
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(3, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 34);
            textBox2.TabIndex = 20;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(btnCheckStatus);
            buttonPanel.Controls.Add(btnClearResults);
            buttonPanel.Controls.Add(progressBar);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(3, 229);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(1367, 82);
            buttonPanel.TabIndex = 1;
            // 
            // btnCheckStatus
            // 
            btnCheckStatus.BackColor = Color.FromArgb(0, 120, 215);
            btnCheckStatus.FlatStyle = FlatStyle.Flat;
            btnCheckStatus.Font = new Font("Segoe UI", 12F);
            btnCheckStatus.ForeColor = Color.White;
            btnCheckStatus.Location = new Point(21, 12);
            btnCheckStatus.Name = "btnCheckStatus";
            btnCheckStatus.Size = new Size(230, 47);
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
            btnClearResults.Location = new Point(256, 12);
            btnClearResults.Name = "btnClearResults";
            btnClearResults.Size = new Size(230, 47);
            btnClearResults.TabIndex = 6;
            btnClearResults.Text = "Clear Results";
            btnClearResults.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(565, 26);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(286, 20);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 7;
            progressBar.Visible = false;
            // 
            // panelStatusViewer
            // 
            panelStatusViewer.BorderStyle = BorderStyle.FixedSingle;
            panelStatusViewer.Dock = DockStyle.Fill;
            panelStatusViewer.Location = new Point(3, 317);
            panelStatusViewer.Name = "panelStatusViewer";
            panelStatusViewer.Size = new Size(1367, 432);
            panelStatusViewer.TabIndex = 8;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(submitTab);
            tabControl.Controls.Add(checkStatusTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1387, 825);
            tabControl.TabIndex = 0;
            // 
            // submitTab
            // 
            submitTab.Controls.Add(submitPanel);
            submitTab.Location = new Point(4, 32);
            submitTab.Margin = new Padding(3, 4, 3, 4);
            submitTab.Name = "submitTab";
            submitTab.Padding = new Padding(3, 4, 3, 4);
            submitTab.Size = new Size(1379, 789);
            submitTab.TabIndex = 0;
            submitTab.Text = "Submit Document";
            submitTab.UseVisualStyleBackColor = true;
            // 
            // checkStatusTab
            // 
            checkStatusTab.Controls.Add(checkStatusPanel);
            checkStatusTab.Location = new Point(4, 32);
            checkStatusTab.Margin = new Padding(3, 4, 3, 4);
            checkStatusTab.Name = "checkStatusTab";
            checkStatusTab.Padding = new Padding(3, 4, 3, 4);
            checkStatusTab.Size = new Size(1379, 789);
            checkStatusTab.TabIndex = 1;
            checkStatusTab.Text = "Check Status";
            checkStatusTab.UseVisualStyleBackColor = true;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.Font = new Font("Segoe UI", 10F);
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(1375, 23);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Padding = new Padding(1, 0, 11, 0);
            miniToolStrip.Size = new Size(1373, 22);
            miniToolStrip.TabIndex = 9;
            // 
            // statusLabel3
            // 
            statusLabel3.Name = "statusLabel3";
            statusLabel3.Size = new Size(0, 16);
            // 
            // statusStrip3
            // 
            statusStrip3.Font = new Font("Segoe UI", 10F);
            statusStrip3.ImageScalingSize = new Size(20, 20);
            statusStrip3.Items.AddRange(new ToolStripItem[] { statusLabel3 });
            statusStrip3.Location = new Point(0, 759);
            statusStrip3.Name = "statusStrip3";
            statusStrip3.Padding = new Padding(1, 0, 11, 0);
            statusStrip3.Size = new Size(1373, 22);
            statusStrip3.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1387, 825);
            Controls.Add(tabControl);
            MinimumSize = new Size(800, 498);
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            checkStatusPanel.ResumeLayout(false);
            tableLayout3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonPanel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            submitTab.ResumeLayout(false);
            checkStatusTab.ResumeLayout(false);
            statusStrip3.ResumeLayout(false);
            statusStrip3.PerformLayout();
            ResumeLayout(false);
        }
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
        private Button btnSubmitDocument;
        private Button btnRemoveFile;
        private Label lblInteractionDate;
        private Button btnBrowseFile;
        private TextBox textBox1;
        private TableLayoutPanel tableLayout3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtStatusUserCode;
        private TextBox txtStatusMessageID;
        private Label lblStatusUserCode;
        private TextBox txtStatusSessionID;
        private Label lblStatusMessageID;
        private Label lblStatusChannel;
        private Label lblStatusSessionID;
        private TextBox txtStatusChannel;
        private TextBox txtStatusSourceSystem;
        private Label lblStatusSourceSystem;
        private Label lblStatusRequestGuid;
        private TextBox txtStatusRequestGuid;
        private Label label1;
        private TextBox textBox2;
        private Panel buttonPanel;
        private Button btnCheckStatus;
        private Button btnClearResults;
        private ProgressBar progressBar;
        private Panel panelStatusViewer;
        private StatusStrip miniToolStrip;
        private ToolStripStatusLabel statusLabel3;
        private StatusStrip statusStrip3;
        private Button btnAddGroup;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
    }
}