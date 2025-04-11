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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblTokenStatus = new Label();
            btnGetToken = new Button();
            txtAppPassword = new TextBox();
            label3 = new Label();
            txtAppLogin = new TextBox();
            label2 = new Label();
            txtAppName = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label18 = new Label();
            dataGridViewDocuments = new DataGridView();
            FilePath = new DataGridViewTextBoxColumn();
            PageType = new DataGridViewTextBoxColumn();
            label19 = new Label();
            dataGridViewFields = new DataGridView();
            FieldName = new DataGridViewTextBoxColumn();
            FieldValue = new DataGridViewTextBoxColumn();
            lblDocumentStatus = new Label();
            btnSubmitDocument = new Button();
            btnBrowseFile = new Button();
            txtUserCode = new TextBox();
            label7 = new Label();
            txtMessageID = new TextBox();
            label6 = new Label();
            txtSessionID = new TextBox();
            label5 = new Label();
            txtChannel = new TextBox();
            label4 = new Label();
            txtSourceSystem = new TextBox();
            label9 = new Label();
            txtBatchClassName = new TextBox();
            label11 = new Label();
            tabPage3 = new TabPage();
            lblReadStatus = new Label();
            txtStatusResult = new TextBox();
            btnCheckStatus = new Button();
            txtStatusRequestGuid = new TextBox();
            label12 = new Label();
            txtStatusUserCode = new TextBox();
            label13 = new Label();
            txtStatusMessageID = new TextBox();
            label14 = new Label();
            txtStatusSessionID = new TextBox();
            label15 = new Label();
            txtStatusChannel = new TextBox();
            label16 = new Label();
            txtStatusSourceSystem = new TextBox();
            label17 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(933, 519);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblTokenStatus);
            tabPage1.Controls.Add(btnGetToken);
            tabPage1.Controls.Add(txtAppPassword);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtAppLogin);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtAppName);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(925, 491);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Authentication";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTokenStatus
            // 
            lblTokenStatus.AutoSize = true;
            lblTokenStatus.Location = new Point(26, 185);
            lblTokenStatus.Margin = new Padding(4, 0, 4, 0);
            lblTokenStatus.Name = "lblTokenStatus";
            lblTokenStatus.Size = new Size(0, 15);
            lblTokenStatus.TabIndex = 7;
            // 
            // btnGetToken
            // 
            btnGetToken.Location = new Point(26, 138);
            btnGetToken.Margin = new Padding(4, 3, 4, 3);
            btnGetToken.Name = "btnGetToken";
            btnGetToken.Size = new Size(233, 27);
            btnGetToken.TabIndex = 6;
            btnGetToken.Text = "Login";
            btnGetToken.UseVisualStyleBackColor = true;
            btnGetToken.Click += btnGetToken_Click;
            // 
            // txtAppPassword
            // 
            txtAppPassword.Location = new Point(26, 108);
            txtAppPassword.Margin = new Padding(4, 3, 4, 3);
            txtAppPassword.Name = "txtAppPassword";
            txtAppPassword.PasswordChar = '*';
            txtAppPassword.Size = new Size(233, 23);
            txtAppPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 90);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "App Password:";
            // 
            // txtAppLogin
            // 
            txtAppLogin.Location = new Point(26, 63);
            txtAppLogin.Margin = new Padding(4, 3, 4, 3);
            txtAppLogin.Name = "txtAppLogin";
            txtAppLogin.Size = new Size(233, 23);
            txtAppLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "App Login:";
            // 
            // txtAppName
            // 
            txtAppName.Location = new Point(26, 18);
            txtAppName.Margin = new Padding(4, 3, 4, 3);
            txtAppName.Name = "txtAppName";
            txtAppName.Size = new Size(233, 23);
            txtAppName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "App Name:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(dataGridViewDocuments);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(dataGridViewFields);
            tabPage2.Controls.Add(lblDocumentStatus);
            tabPage2.Controls.Add(btnSubmitDocument);
            tabPage2.Controls.Add(btnBrowseFile);
            tabPage2.Controls.Add(txtUserCode);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtMessageID);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtSessionID);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtChannel);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtSourceSystem);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtBatchClassName);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(925, 491);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Submit Document";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 172);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(71, 15);
            label18.TabIndex = 23;
            label18.Text = "Documents:";
            // 
            // dataGridViewDocuments
            // 
            dataGridViewDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocuments.Columns.AddRange(new DataGridViewColumn[] { FilePath, PageType });
            dataGridViewDocuments.Location = new Point(22, 190);
            dataGridViewDocuments.Name = "dataGridViewDocuments";
            dataGridViewDocuments.Size = new Size(240, 150);
            dataGridViewDocuments.TabIndex = 22;
            // 
            // FilePath
            // 
            FilePath.HeaderText = "File Path";
            FilePath.Name = "FilePath";
            // 
            // PageType
            // 
            PageType.HeaderText = "Page Type";
            PageType.Name = "PageType";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(341, 172);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(40, 15);
            label19.TabIndex = 21;
            label19.Text = "Fields:";
            // 
            // dataGridViewFields
            // 
            dataGridViewFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFields.Columns.AddRange(new DataGridViewColumn[] { FieldName, FieldValue });
            dataGridViewFields.Location = new Point(345, 190);
            dataGridViewFields.Name = "dataGridViewFields";
            dataGridViewFields.Size = new Size(240, 150);
            dataGridViewFields.TabIndex = 20;
            dataGridViewFields.CellContentClick += dataGridViewFields_CellContentClick;
            // 
            // FieldName
            // 
            FieldName.HeaderText = "Field Name";
            FieldName.Name = "FieldName";
            // 
            // FieldValue
            // 
            FieldValue.HeaderText = "Field Value";
            FieldValue.Name = "FieldValue";
            // 
            // lblDocumentStatus
            // 
            lblDocumentStatus.AutoSize = true;
            lblDocumentStatus.Location = new Point(18, 439);
            lblDocumentStatus.Margin = new Padding(4, 0, 4, 0);
            lblDocumentStatus.Name = "lblDocumentStatus";
            lblDocumentStatus.Size = new Size(0, 15);
            lblDocumentStatus.TabIndex = 18;
            // 
            // btnSubmitDocument
            // 
            btnSubmitDocument.Location = new Point(191, 391);
            btnSubmitDocument.Margin = new Padding(4, 3, 4, 3);
            btnSubmitDocument.Name = "btnSubmitDocument";
            btnSubmitDocument.Size = new Size(233, 27);
            btnSubmitDocument.TabIndex = 17;
            btnSubmitDocument.Text = "Submit Document";
            btnSubmitDocument.UseVisualStyleBackColor = true;
            btnSubmitDocument.Click += btnSubmitDocument_Click;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Location = new Point(18, 357);
            btnBrowseFile.Margin = new Padding(4, 3, 4, 3);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(88, 27);
            btnBrowseFile.TabIndex = 16;
            btnBrowseFile.Text = "Add Files";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // txtUserCode
            // 
            txtUserCode.Location = new Point(345, 92);
            txtUserCode.Margin = new Padding(4, 3, 4, 3);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new Size(233, 23);
            txtUserCode.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 73);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 12;
            label7.Text = "User Code:";
            // 
            // txtMessageID
            // 
            txtMessageID.Location = new Point(22, 140);
            txtMessageID.Margin = new Padding(4, 3, 4, 3);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(233, 23);
            txtMessageID.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 121);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 10;
            label6.Text = "Message ID:";
            // 
            // txtSessionID
            // 
            txtSessionID.Location = new Point(345, 140);
            txtSessionID.Margin = new Padding(4, 3, 4, 3);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.Size = new Size(233, 23);
            txtSessionID.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 120);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Session ID:";
            // 
            // txtChannel
            // 
            txtChannel.Location = new Point(22, 92);
            txtChannel.Margin = new Padding(4, 3, 4, 3);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(233, 23);
            txtChannel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 74);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Channel:";
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.Location = new Point(22, 46);
            txtSourceSystem.Margin = new Padding(4, 3, 4, 3);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new Size(233, 23);
            txtSourceSystem.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 28);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 4;
            label9.Text = "Source System:";
            // 
            // txtBatchClassName
            // 
            txtBatchClassName.Location = new Point(345, 46);
            txtBatchClassName.Margin = new Padding(4, 3, 4, 3);
            txtBatchClassName.Name = "txtBatchClassName";
            txtBatchClassName.Size = new Size(233, 23);
            txtBatchClassName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(341, 28);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 0;
            label11.Text = "Batch Class Name:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblReadStatus);
            tabPage3.Controls.Add(txtStatusResult);
            tabPage3.Controls.Add(btnCheckStatus);
            tabPage3.Controls.Add(txtStatusRequestGuid);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(txtStatusUserCode);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(txtStatusMessageID);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(txtStatusSessionID);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(txtStatusChannel);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(txtStatusSourceSystem);
            tabPage3.Controls.Add(label17);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 3, 4, 3);
            tabPage3.Size = new Size(925, 491);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Check Status";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblReadStatus
            // 
            lblReadStatus.AutoSize = true;
            lblReadStatus.Location = new Point(22, 168);
            lblReadStatus.Margin = new Padding(4, 0, 4, 0);
            lblReadStatus.Name = "lblReadStatus";
            lblReadStatus.Size = new Size(0, 15);
            lblReadStatus.TabIndex = 20;
            // 
            // txtStatusResult
            // 
            txtStatusResult.Location = new Point(22, 195);
            txtStatusResult.Margin = new Padding(4, 3, 4, 3);
            txtStatusResult.Multiline = true;
            txtStatusResult.Name = "txtStatusResult";
            txtStatusResult.ScrollBars = ScrollBars.Both;
            txtStatusResult.Size = new Size(874, 265);
            txtStatusResult.TabIndex = 19;
            txtStatusResult.TextChanged += txtStatusResult_TextChanged;
            // 
            // btnCheckStatus
            // 
            btnCheckStatus.Location = new Point(22, 127);
            btnCheckStatus.Margin = new Padding(4, 3, 4, 3);
            btnCheckStatus.Name = "btnCheckStatus";
            btnCheckStatus.Size = new Size(233, 27);
            btnCheckStatus.TabIndex = 18;
            btnCheckStatus.Text = "Check Status";
            btnCheckStatus.UseVisualStyleBackColor = true;
            btnCheckStatus.Click += btnCheckStatus_Click;
            // 
            // txtStatusRequestGuid
            // 
            txtStatusRequestGuid.Location = new Point(22, 37);
            txtStatusRequestGuid.Margin = new Padding(4, 3, 4, 3);
            txtStatusRequestGuid.Name = "txtStatusRequestGuid";
            txtStatusRequestGuid.Size = new Size(233, 23);
            txtStatusRequestGuid.TabIndex = 17;
            txtStatusRequestGuid.TextChanged += txtStatusRequestGuid_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 19);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 16;
            label12.Text = "Request GUID:";
            // 
            // txtStatusUserCode
            // 
            txtStatusUserCode.Location = new Point(22, 81);
            txtStatusUserCode.Margin = new Padding(4, 3, 4, 3);
            txtStatusUserCode.Name = "txtStatusUserCode";
            txtStatusUserCode.Size = new Size(233, 23);
            txtStatusUserCode.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 63);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 14;
            label13.Text = "User Code:";
            // 
            // txtStatusMessageID
            // 
            txtStatusMessageID.Location = new Point(322, 37);
            txtStatusMessageID.Margin = new Padding(4, 3, 4, 3);
            txtStatusMessageID.Name = "txtStatusMessageID";
            txtStatusMessageID.Size = new Size(233, 23);
            txtStatusMessageID.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(322, 19);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(70, 15);
            label14.TabIndex = 12;
            label14.Text = "Message ID:";
            // 
            // txtStatusSessionID
            // 
            txtStatusSessionID.Location = new Point(583, 37);
            txtStatusSessionID.Margin = new Padding(4, 3, 4, 3);
            txtStatusSessionID.Name = "txtStatusSessionID";
            txtStatusSessionID.Size = new Size(233, 23);
            txtStatusSessionID.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(579, 19);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 10;
            label15.Text = "Session ID:";
            // 
            // txtStatusChannel
            // 
            txtStatusChannel.Location = new Point(583, 81);
            txtStatusChannel.Margin = new Padding(4, 3, 4, 3);
            txtStatusChannel.Name = "txtStatusChannel";
            txtStatusChannel.Size = new Size(233, 23);
            txtStatusChannel.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(580, 63);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(54, 15);
            label16.TabIndex = 8;
            label16.Text = "Channel:";
            // 
            // txtStatusSourceSystem
            // 
            txtStatusSourceSystem.Location = new Point(322, 81);
            txtStatusSourceSystem.Margin = new Padding(4, 3, 4, 3);
            txtStatusSourceSystem.Name = "txtStatusSourceSystem";
            txtStatusSourceSystem.Size = new Size(233, 23);
            txtStatusSourceSystem.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(319, 63);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(87, 15);
            label17.TabIndex = 6;
            label17.Text = "Source System:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "CCapture Mock API Client";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocuments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFields).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblTokenStatus;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.TextBox txtAppPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAppLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDocumentStatus;
        private System.Windows.Forms.Button btnSubmitDocument;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMessageID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSessionID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSourceSystem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBatchClassName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStatusResult;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.TextBox txtStatusRequestGuid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStatusUserCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStatusMessageID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStatusSessionID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStatusChannel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtStatusSourceSystem;
        private System.Windows.Forms.Label label17;
        private DataGridView dataGridViewFields;
        private DataGridViewTextBoxColumn FieldName;
        private DataGridViewTextBoxColumn FieldValue;
        private Label label19;
        private Label label18;
        private DataGridView dataGridViewDocuments;
        private DataGridViewTextBoxColumn FilePath;
        private DataGridViewTextBoxColumn PageType;
        private Label lblReadStatus;
    }
}