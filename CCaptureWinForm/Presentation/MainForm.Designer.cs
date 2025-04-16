namespace CCaptureWinForm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            statusStrip1 = new StatusStrip();
            statusLabel1 = new ToolStripStatusLabel();
            credentialsGroup = new GroupBox();
            btnGetToken = new Button();
            chkShowPassword = new CheckBox();
            txtAppPassword = new TextBox();
            lblAppPassword = new Label();
            txtAppLogin = new TextBox();
            lblAppLogin = new Label();
            txtAppName = new TextBox();
            lblAppName = new Label();
            tabPage2 = new TabPage();
            statusStrip2 = new StatusStrip();
            statusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            dataPanel = new Panel();
            btnSubmitDocument = new Button();
            btnRemoveFile = new Button();
            btnBrowseFile = new Button();
            dataGridViewFields = new DataGridView();
            FieldName = new DataGridViewTextBoxColumn();
            FieldValue = new DataGridViewTextBoxColumn();
            lblFields = new Label();
            dataGridViewDocuments = new DataGridView();
            FilePath = new DataGridViewTextBoxColumn();
            PageType = new DataGridViewTextBoxColumn();
            lblDocuments = new Label();
            metadataPanel = new Panel();
            tableLayout2 = new TableLayoutPanel();
            txtMessageID = new TextBox();
            lblMessageID = new Label();
            txtSessionID = new TextBox();
            lblSessionID = new Label();
            txtUserCode = new TextBox();
            lblUserCode = new Label();
            txtChannel = new TextBox();
            lblChannel = new Label();
            txtSourceSystem = new TextBox();
            lblSourceSystem = new Label();
            txtBatchClassName = new TextBox();
            lblBatchClassName = new Label();
            tabPage3 = new TabPage();
            tableLayout3 = new TableLayoutPanel();
            inputPanel = new Panel();
            txtStatusUserCode = new TextBox();
            lblStatusUserCode = new Label();
            txtStatusMessageID = new TextBox();
            lblStatusMessageID = new Label();
            txtStatusSessionID = new TextBox();
            lblStatusSessionID = new Label();
            txtStatusChannel = new TextBox();
            lblStatusChannel = new Label();
            txtStatusSourceSystem = new TextBox();
            lblStatusSourceSystem = new Label();
            txtStatusRequestGuid = new TextBox();
            lblStatusRequestGuid = new Label();
            buttonPanel = new Panel();
            btnCheckStatus = new Button();
            btnClearResults = new Button();
            progressBar = new ProgressBar();
            panelStatusViewer = new Panel();
            statusStrip3 = new StatusStrip();
            statusLabel3 = new ToolStripStatusLabel();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            statusStrip1.SuspendLayout();
            credentialsGroup.SuspendLayout();
            tabPage2.SuspendLayout();
            statusStrip2.SuspendLayout();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).BeginInit();
            metadataPanel.SuspendLayout();
            tableLayout2.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayout3.SuspendLayout();
            inputPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            statusStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(933, 519);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(statusStrip1);
            tabPage1.Controls.Add(credentialsGroup);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(10);
            tabPage1.Size = new Size(925, 489);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Authentication";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel1 });
            statusStrip1.Location = new Point(10, 457);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(905, 22);
            statusStrip1.TabIndex = 5;
            // 
            // statusLabel1
            // 
            statusLabel1.Name = "statusLabel1";
            statusLabel1.Size = new Size(0, 17);
            // 
            // credentialsGroup
            // 
            credentialsGroup.Controls.Add(btnGetToken);
            credentialsGroup.Controls.Add(chkShowPassword);
            credentialsGroup.Controls.Add(txtAppPassword);
            credentialsGroup.Controls.Add(lblAppPassword);
            credentialsGroup.Controls.Add(txtAppLogin);
            credentialsGroup.Controls.Add(lblAppLogin);
            credentialsGroup.Controls.Add(txtAppName);
            credentialsGroup.Controls.Add(lblAppName);
            credentialsGroup.Font = new Font("Segoe UI", 10F);
            credentialsGroup.Location = new Point(312, 46);
            credentialsGroup.Margin = new Padding(3, 2, 3, 2);
            credentialsGroup.Name = "credentialsGroup";
            credentialsGroup.Padding = new Padding(3, 2, 3, 2);
            credentialsGroup.Size = new Size(300, 250);
            credentialsGroup.TabIndex = 0;
            credentialsGroup.TabStop = false;
            credentialsGroup.Text = "Application Credentials";
            // 
            // btnGetToken
            // 
            btnGetToken.BackColor = Color.FromArgb(0, 120, 215);
            btnGetToken.FlatStyle = FlatStyle.Flat;
            btnGetToken.ForeColor = Color.White;
            btnGetToken.Location = new Point(10, 206);
            btnGetToken.Margin = new Padding(3, 2, 3, 2);
            btnGetToken.Name = "btnGetToken";
            btnGetToken.Size = new Size(260, 30);
            btnGetToken.TabIndex = 5;
            btnGetToken.Text = "LogIn";
            btnGetToken.UseVisualStyleBackColor = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(10, 180);
            chkShowPassword.Margin = new Padding(3, 2, 3, 2);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(123, 23);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Show Password";
            // 
            // txtAppPassword
            // 
            txtAppPassword.AccessibleName = "Application Password";
            txtAppPassword.Location = new Point(10, 150);
            txtAppPassword.Margin = new Padding(3, 2, 3, 2);
            txtAppPassword.Name = "txtAppPassword";
            txtAppPassword.Size = new Size(260, 25);
            txtAppPassword.TabIndex = 2;
            toolTip1.SetToolTip(txtAppPassword, "Enter the application password.");
            txtAppPassword.UseSystemPasswordChar = true;
            // 
            // lblAppPassword
            // 
            lblAppPassword.AutoSize = true;
            lblAppPassword.Location = new Point(10, 130);
            lblAppPassword.Name = "lblAppPassword";
            lblAppPassword.Size = new Size(142, 19);
            lblAppPassword.TabIndex = 0;
            lblAppPassword.Text = "Application Password:";
            // 
            // txtAppLogin
            // 
            txtAppLogin.AccessibleName = "Application Login";
            txtAppLogin.Location = new Point(10, 100);
            txtAppLogin.Margin = new Padding(3, 2, 3, 2);
            txtAppLogin.Name = "txtAppLogin";
            txtAppLogin.Size = new Size(260, 25);
            txtAppLogin.TabIndex = 1;
            toolTip1.SetToolTip(txtAppLogin, "Enter the application login ID.");
            // 
            // lblAppLogin
            // 
            lblAppLogin.AutoSize = true;
            lblAppLogin.Location = new Point(10, 80);
            lblAppLogin.Name = "lblAppLogin";
            lblAppLogin.Size = new Size(118, 19);
            lblAppLogin.TabIndex = 0;
            lblAppLogin.Text = "Application Login:";
            // 
            // txtAppName
            // 
            txtAppName.AccessibleName = "Application Name";
            txtAppName.Location = new Point(10, 50);
            txtAppName.Margin = new Padding(3, 2, 3, 2);
            txtAppName.Name = "txtAppName";
            txtAppName.Size = new Size(260, 25);
            txtAppName.TabIndex = 0;
            toolTip1.SetToolTip(txtAppName, "Enter the name of the application.");
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Location = new Point(10, 30);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(120, 19);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Application Name:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(statusStrip2);
            tabPage2.Controls.Add(dataPanel);
            tabPage2.Controls.Add(metadataPanel);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(925, 489);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Submit Document";
            // 
            // statusStrip2
            // 
            statusStrip2.ImageScalingSize = new Size(20, 20);
            statusStrip2.Items.AddRange(new ToolStripItem[] { statusLabel2, toolStripStatusLabel1 });
            statusStrip2.Location = new Point(0, 467);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Padding = new Padding(1, 0, 12, 0);
            statusStrip2.Size = new Size(925, 22);
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
            // dataPanel
            // 
            dataPanel.Controls.Add(btnSubmitDocument);
            dataPanel.Controls.Add(btnRemoveFile);
            dataPanel.Controls.Add(btnBrowseFile);
            dataPanel.Controls.Add(dataGridViewFields);
            dataPanel.Controls.Add(lblFields);
            dataPanel.Controls.Add(dataGridViewDocuments);
            dataPanel.Controls.Add(lblDocuments);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(0, 150);
            dataPanel.Margin = new Padding(3, 2, 3, 2);
            dataPanel.Name = "dataPanel";
            dataPanel.Size = new Size(925, 339);
            dataPanel.TabIndex = 10;
            // 
            // btnSubmitDocument
            // 
            btnSubmitDocument.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitDocument.BackColor = Color.FromArgb(40, 167, 69);
            btnSubmitDocument.FlatStyle = FlatStyle.Flat;
            btnSubmitDocument.ForeColor = Color.White;
            btnSubmitDocument.Location = new Point(732, 257);
            btnSubmitDocument.Name = "btnSubmitDocument";
            btnSubmitDocument.Size = new Size(135, 44);
            btnSubmitDocument.TabIndex = 10;
            btnSubmitDocument.Text = "Submit Documents";
            btnSubmitDocument.UseVisualStyleBackColor = false;
            // 
            // btnRemoveFile
            // 
            btnRemoveFile.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveFile.FlatStyle = FlatStyle.Flat;
            btnRemoveFile.ForeColor = Color.White;
            btnRemoveFile.Location = new Point(180, 260);
            btnRemoveFile.Margin = new Padding(3, 2, 3, 2);
            btnRemoveFile.Name = "btnRemoveFile";
            btnRemoveFile.Size = new Size(152, 30);
            btnRemoveFile.TabIndex = 9;
            btnRemoveFile.Text = "Remove Selected";
            btnRemoveFile.UseVisualStyleBackColor = false;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.BackColor = Color.FromArgb(0, 120, 215);
            btnBrowseFile.FlatStyle = FlatStyle.Flat;
            btnBrowseFile.ForeColor = Color.White;
            btnBrowseFile.Location = new Point(23, 260);
            btnBrowseFile.Margin = new Padding(3, 2, 3, 2);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(152, 30);
            btnBrowseFile.TabIndex = 8;
            btnBrowseFile.Text = "Add Files";
            btnBrowseFile.UseVisualStyleBackColor = false;
            // 
            // dataGridViewFields
            // 
            dataGridViewFields.Anchor = AnchorStyles.Top;
            dataGridViewFields.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFields.Columns.AddRange(new DataGridViewColumn[] { FieldName, FieldValue });
            dataGridViewFields.Location = new Point(516, 20);
            dataGridViewFields.Margin = new Padding(3, 2, 3, 2);
            dataGridViewFields.Name = "dataGridViewFields";
            dataGridViewFields.RowHeadersWidth = 51;
            dataGridViewFields.Size = new Size(400, 232);
            dataGridViewFields.TabIndex = 7;
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
            lblFields.AutoSize = true;
            lblFields.Location = new Point(517, 0);
            lblFields.Name = "lblFields";
            lblFields.Size = new Size(73, 19);
            lblFields.TabIndex = 0;
            lblFields.Text = "Field Data:";
            // 
            // dataGridViewDocuments
            // 
            dataGridViewDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocuments.Columns.AddRange(new DataGridViewColumn[] { FilePath, PageType });
            dataGridViewDocuments.Location = new Point(23, 20);
            dataGridViewDocuments.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDocuments.Name = "dataGridViewDocuments";
            dataGridViewDocuments.RowHeadersWidth = 51;
            dataGridViewDocuments.Size = new Size(400, 232);
            dataGridViewDocuments.TabIndex = 6;
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
            lblDocuments.AutoSize = true;
            lblDocuments.Location = new Point(23, 0);
            lblDocuments.Name = "lblDocuments";
            lblDocuments.Size = new Size(101, 19);
            lblDocuments.TabIndex = 0;
            lblDocuments.Text = "Document List:";
            // 
            // metadataPanel
            // 
            metadataPanel.Controls.Add(tableLayout2);
            metadataPanel.Dock = DockStyle.Top;
            metadataPanel.Location = new Point(0, 0);
            metadataPanel.Margin = new Padding(3, 2, 3, 2);
            metadataPanel.Name = "metadataPanel";
            metadataPanel.Size = new Size(925, 150);
            metadataPanel.TabIndex = 9;
            // 
            // tableLayout2
            // 
            tableLayout2.ColumnCount = 3;
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayout2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayout2.Controls.Add(txtMessageID, 2, 3);
            tableLayout2.Controls.Add(lblMessageID, 2, 2);
            tableLayout2.Controls.Add(txtSessionID, 1, 3);
            tableLayout2.Controls.Add(lblSessionID, 1, 2);
            tableLayout2.Controls.Add(txtUserCode, 0, 3);
            tableLayout2.Controls.Add(lblUserCode, 0, 2);
            tableLayout2.Controls.Add(txtChannel, 2, 1);
            tableLayout2.Controls.Add(lblChannel, 2, 0);
            tableLayout2.Controls.Add(txtSourceSystem, 1, 1);
            tableLayout2.Controls.Add(lblSourceSystem, 1, 0);
            tableLayout2.Controls.Add(txtBatchClassName, 0, 1);
            tableLayout2.Controls.Add(lblBatchClassName, 0, 0);
            tableLayout2.Dock = DockStyle.Fill;
            tableLayout2.Location = new Point(0, 0);
            tableLayout2.Margin = new Padding(3, 2, 3, 2);
            tableLayout2.Name = "tableLayout2";
            tableLayout2.RowCount = 4;
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayout2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayout2.Size = new Size(925, 150);
            tableLayout2.TabIndex = 0;
            // 
            // txtMessageID
            // 
            txtMessageID.AccessibleName = "Message ID";
            txtMessageID.Location = new Point(619, 113);
            txtMessageID.Margin = new Padding(3, 2, 3, 2);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(250, 25);
            txtMessageID.TabIndex = 5;
            toolTip2.SetToolTip(txtMessageID, "Enter the message ID.");
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Location = new Point(619, 74);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(84, 19);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // txtSessionID
            // 
            txtSessionID.AccessibleName = "Session ID";
            txtSessionID.Location = new Point(311, 113);
            txtSessionID.Margin = new Padding(3, 2, 3, 2);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.Size = new Size(250, 25);
            txtSessionID.TabIndex = 4;
            toolTip2.SetToolTip(txtSessionID, "Enter the session ID.");
            // 
            // lblSessionID
            // 
            lblSessionID.AutoSize = true;
            lblSessionID.Location = new Point(311, 74);
            lblSessionID.Name = "lblSessionID";
            lblSessionID.Size = new Size(75, 19);
            lblSessionID.TabIndex = 0;
            lblSessionID.Text = "Session ID:";
            // 
            // txtUserCode
            // 
            txtUserCode.AccessibleName = "User ID";
            txtUserCode.Location = new Point(3, 113);
            txtUserCode.Margin = new Padding(3, 2, 3, 2);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new Size(250, 25);
            txtUserCode.TabIndex = 3;
            toolTip2.SetToolTip(txtUserCode, "Enter the user ID.");
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Location = new Point(3, 74);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new Size(58, 19);
            lblUserCode.TabIndex = 0;
            lblUserCode.Text = "User ID:";
            // 
            // txtChannel
            // 
            txtChannel.AccessibleName = "Channel";
            txtChannel.Location = new Point(619, 39);
            txtChannel.Margin = new Padding(3, 2, 3, 2);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(250, 25);
            txtChannel.TabIndex = 2;
            toolTip2.SetToolTip(txtChannel, "Enter the channel name.");
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Location = new Point(619, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(62, 19);
            lblChannel.TabIndex = 0;
            lblChannel.Text = "Channel:";
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.AccessibleName = "Source System";
            txtSourceSystem.Location = new Point(311, 39);
            txtSourceSystem.Margin = new Padding(3, 2, 3, 2);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new Size(250, 25);
            txtSourceSystem.TabIndex = 1;
            toolTip2.SetToolTip(txtSourceSystem, "Enter the source system identifier.");
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Location = new Point(311, 0);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new Size(101, 19);
            lblSourceSystem.TabIndex = 0;
            lblSourceSystem.Text = "Source System:";
            // 
            // txtBatchClassName
            // 
            txtBatchClassName.AccessibleName = "Batch Category";
            txtBatchClassName.Location = new Point(3, 39);
            txtBatchClassName.Margin = new Padding(3, 2, 3, 2);
            txtBatchClassName.Name = "txtBatchClassName";
            txtBatchClassName.Size = new Size(250, 25);
            txtBatchClassName.TabIndex = 0;
            toolTip2.SetToolTip(txtBatchClassName, "Enter the batch category.");
            // 
            // lblBatchClassName
            // 
            lblBatchClassName.AutoSize = true;
            lblBatchClassName.Location = new Point(3, 0);
            lblBatchClassName.Name = "lblBatchClassName";
            lblBatchClassName.Size = new Size(121, 19);
            lblBatchClassName.TabIndex = 0;
            lblBatchClassName.Text = "Batch Class Name:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayout3);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(925, 489);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Check Status";
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
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayout3.Size = new Size(925, 489);
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
            inputPanel.Size = new Size(919, 108);
            inputPanel.TabIndex = 0;
            // 
            // txtStatusUserCode
            // 
            txtStatusUserCode.AccessibleName = "User ID";
            txtStatusUserCode.Location = new Point(619, 70);
            txtStatusUserCode.Margin = new Padding(3, 2, 3, 2);
            txtStatusUserCode.Name = "txtStatusUserCode";
            txtStatusUserCode.Size = new Size(250, 25);
            txtStatusUserCode.TabIndex = 5;
            toolTip3.SetToolTip(txtStatusUserCode, "Enter the user ID.");
            // 
            // lblStatusUserCode
            // 
            lblStatusUserCode.AutoSize = true;
            lblStatusUserCode.Location = new Point(619, 50);
            lblStatusUserCode.Name = "lblStatusUserCode";
            lblStatusUserCode.Size = new Size(58, 19);
            lblStatusUserCode.TabIndex = 0;
            lblStatusUserCode.Text = "User ID:";
            // 
            // txtStatusMessageID
            // 
            txtStatusMessageID.AccessibleName = "Message ID";
            txtStatusMessageID.Location = new Point(319, 70);
            txtStatusMessageID.Margin = new Padding(3, 2, 3, 2);
            txtStatusMessageID.Name = "txtStatusMessageID";
            txtStatusMessageID.Size = new Size(250, 25);
            txtStatusMessageID.TabIndex = 4;
            toolTip3.SetToolTip(txtStatusMessageID, "Enter the message ID.");
            // 
            // lblStatusMessageID
            // 
            lblStatusMessageID.AutoSize = true;
            lblStatusMessageID.Location = new Point(319, 50);
            lblStatusMessageID.Name = "lblStatusMessageID";
            lblStatusMessageID.Size = new Size(84, 19);
            lblStatusMessageID.TabIndex = 0;
            lblStatusMessageID.Text = "Message ID:";
            // 
            // txtStatusSessionID
            // 
            txtStatusSessionID.AccessibleName = "Session ID";
            txtStatusSessionID.Location = new Point(20, 70);
            txtStatusSessionID.Margin = new Padding(3, 2, 3, 2);
            txtStatusSessionID.Name = "txtStatusSessionID";
            txtStatusSessionID.Size = new Size(250, 25);
            txtStatusSessionID.TabIndex = 3;
            toolTip3.SetToolTip(txtStatusSessionID, "Enter the session ID.");
            // 
            // lblStatusSessionID
            // 
            lblStatusSessionID.AutoSize = true;
            lblStatusSessionID.Location = new Point(20, 50);
            lblStatusSessionID.Name = "lblStatusSessionID";
            lblStatusSessionID.Size = new Size(75, 19);
            lblStatusSessionID.TabIndex = 0;
            lblStatusSessionID.Text = "Session ID:";
            // 
            // txtStatusChannel
            // 
            txtStatusChannel.AccessibleName = "Channel";
            txtStatusChannel.Location = new Point(619, 25);
            txtStatusChannel.Margin = new Padding(3, 2, 3, 2);
            txtStatusChannel.Name = "txtStatusChannel";
            txtStatusChannel.Size = new Size(250, 25);
            txtStatusChannel.TabIndex = 2;
            toolTip3.SetToolTip(txtStatusChannel, "Enter the channel name.");
            // 
            // lblStatusChannel
            // 
            lblStatusChannel.AutoSize = true;
            lblStatusChannel.Location = new Point(619, 4);
            lblStatusChannel.Name = "lblStatusChannel";
            lblStatusChannel.Size = new Size(62, 19);
            lblStatusChannel.TabIndex = 0;
            lblStatusChannel.Text = "Channel:";
            // 
            // txtStatusSourceSystem
            // 
            txtStatusSourceSystem.AccessibleName = "Source System";
            txtStatusSourceSystem.Location = new Point(319, 25);
            txtStatusSourceSystem.Margin = new Padding(3, 2, 3, 2);
            txtStatusSourceSystem.Name = "txtStatusSourceSystem";
            txtStatusSourceSystem.Size = new Size(250, 25);
            txtStatusSourceSystem.TabIndex = 1;
            toolTip3.SetToolTip(txtStatusSourceSystem, "Enter the source system identifier.");
            // 
            // lblStatusSourceSystem
            // 
            lblStatusSourceSystem.AutoSize = true;
            lblStatusSourceSystem.Location = new Point(319, 4);
            lblStatusSourceSystem.Name = "lblStatusSourceSystem";
            lblStatusSourceSystem.Size = new Size(101, 19);
            lblStatusSourceSystem.TabIndex = 0;
            lblStatusSourceSystem.Text = "Source System:";
            // 
            // txtStatusRequestGuid
            // 
            txtStatusRequestGuid.AccessibleName = "Request ID";
            txtStatusRequestGuid.Location = new Point(20, 25);
            txtStatusRequestGuid.Margin = new Padding(3, 2, 3, 2);
            txtStatusRequestGuid.Name = "txtStatusRequestGuid";
            txtStatusRequestGuid.Size = new Size(250, 25);
            txtStatusRequestGuid.TabIndex = 0;
            toolTip3.SetToolTip(txtStatusRequestGuid, "Enter the request ID.");
            // 
            // lblStatusRequestGuid
            // 
            lblStatusRequestGuid.AutoSize = true;
            lblStatusRequestGuid.Location = new Point(20, 4);
            lblStatusRequestGuid.Name = "lblStatusRequestGuid";
            lblStatusRequestGuid.Size = new Size(79, 19);
            lblStatusRequestGuid.TabIndex = 0;
            lblStatusRequestGuid.Text = "Request ID:";
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(btnCheckStatus);
            buttonPanel.Controls.Add(btnClearResults);
            buttonPanel.Controls.Add(progressBar);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(3, 114);
            buttonPanel.Margin = new Padding(3, 2, 3, 2);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(919, 41);
            buttonPanel.TabIndex = 1;
            // 
            // btnCheckStatus
            // 
            btnCheckStatus.BackColor = Color.FromArgb(0, 120, 215);
            btnCheckStatus.FlatStyle = FlatStyle.Flat;
            btnCheckStatus.ForeColor = Color.White;
            btnCheckStatus.Location = new Point(20, 5);
            btnCheckStatus.Margin = new Padding(3, 2, 3, 2);
            btnCheckStatus.Name = "btnCheckStatus";
            btnCheckStatus.Size = new Size(230, 30);
            btnCheckStatus.TabIndex = 5;
            btnCheckStatus.Text = "Check Status";
            btnCheckStatus.UseVisualStyleBackColor = false;
            // 
            // btnClearResults
            // 
            btnClearResults.BackColor = Color.FromArgb(108, 117, 125);
            btnClearResults.FlatStyle = FlatStyle.Flat;
            btnClearResults.ForeColor = Color.White;
            btnClearResults.Location = new Point(256, 5);
            btnClearResults.Margin = new Padding(3, 2, 3, 2);
            btnClearResults.Name = "btnClearResults";
            btnClearResults.Size = new Size(230, 30);
            btnClearResults.TabIndex = 6;
            btnClearResults.Text = "Clear Results";
            btnClearResults.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(565, 12);
            progressBar.Margin = new Padding(3, 2, 3, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(286, 16);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 7;
            progressBar.Visible = false;
            // 
            // panelStatusViewer
            // 
            panelStatusViewer.BorderStyle = BorderStyle.FixedSingle;
            panelStatusViewer.Dock = DockStyle.Fill;
            panelStatusViewer.Location = new Point(3, 159);
            panelStatusViewer.Margin = new Padding(3, 2, 3, 2);
            panelStatusViewer.Name = "panelStatusViewer";
            panelStatusViewer.Size = new Size(919, 306);
            panelStatusViewer.TabIndex = 8;
            // 
            // statusStrip3
            // 
            statusStrip3.ImageScalingSize = new Size(20, 20);
            statusStrip3.Items.AddRange(new ToolStripItem[] { statusLabel3 });
            statusStrip3.Location = new Point(0, 467);
            statusStrip3.Name = "statusStrip3";
            statusStrip3.Padding = new Padding(1, 0, 12, 0);
            statusStrip3.Size = new Size(925, 22);
            statusStrip3.TabIndex = 9;
            // 
            // statusLabel3
            // 
            statusLabel3.Name = "statusLabel3";
            statusLabel3.Size = new Size(0, 17);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(933, 519);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(702, 385);
            Name = "MainForm";
            Text = "CCapture Mock API Client";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            credentialsGroup.ResumeLayout(false);
            credentialsGroup.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            dataPanel.ResumeLayout(false);
            dataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).EndInit();
            metadataPanel.ResumeLayout(false);
            tableLayout2.ResumeLayout(false);
            tableLayout2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tableLayout3.ResumeLayout(false);
            tableLayout3.PerformLayout();
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            statusStrip3.ResumeLayout(false);
            statusStrip3.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.GroupBox credentialsGroup;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.TextBox txtAppPassword;
        private System.Windows.Forms.Label lblAppPassword;
        private System.Windows.Forms.TextBox txtAppLogin;
        private System.Windows.Forms.Label lblAppLogin;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel2;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Button btnSubmitDocument;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.DataGridView dataGridViewFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldValue;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.DataGridView dataGridViewDocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageType;
        private System.Windows.Forms.Label lblDocuments;
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
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}