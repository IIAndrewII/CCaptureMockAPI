﻿namespace CCaptureWinForm
{
    partial class CheckStatusForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel checkStatusPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout3;
        private System.Windows.Forms.Label lblVerificationStatus;
        private System.Windows.Forms.TreeView VerificationStatusTree;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnCollapseAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Label lblRequestGuid;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TableLayoutPanel metadataTableLayout;
        private System.Windows.Forms.TextBox txtSourceSystem;
        private System.Windows.Forms.Label lblSourceSystem;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.TextBox txtSessionID;
        private System.Windows.Forms.Label lblSessionID;
        private System.Windows.Forms.TextBox txtMessageID;
        private System.Windows.Forms.Label lblMessageID;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker pickerInteractionDateTime;
        private System.Windows.Forms.Label lblInteractionDate;
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
            checkStatusPanel = new Panel();
            metadataTableLayout = new TableLayoutPanel();
            txtSourceSystem = new TextBox();
            lblSourceSystem = new Label();
            txtChannel = new TextBox();
            lblChannel = new Label();
            txtSessionID = new TextBox();
            lblSessionID = new Label();
            txtMessageID = new TextBox();
            lblMessageID = new Label();
            txtUserCode = new TextBox();
            lblUserCode = new Label();
            lblApiUrl = new Label();
            lblInteractionDate = new Label();
            txtApiUrl = new TextBox();
            pickerInteractionDateTime = new DateTimePicker();
            tableLayout3 = new TableLayoutPanel();
            lblVerificationStatus = new Label();
            VerificationStatusTree = new TreeView();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnExpandAll = new Button();
            btnCollapseAll = new Button();
            dataGridViewRequests = new DataGridView();
            lblRequestGuid = new Label();
            btnCheckStatus = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnUncheckAll = new Button();
            btnCheckAll = new Button();
            statusStrip3 = new StatusStrip();
            statusLabel3 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            errorProvider = new ErrorProvider(components);
            Select = new DataGridViewCheckBoxColumn();
            RequestGuid = new DataGridViewTextBoxColumn();
            Details = new DataGridViewButtonColumn();
            checkStatusPanel.SuspendLayout();
            metadataTableLayout.SuspendLayout();
            tableLayout3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            statusStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // checkStatusPanel
            // 
            checkStatusPanel.Controls.Add(metadataTableLayout);
            checkStatusPanel.Controls.Add(tableLayout3);
            checkStatusPanel.Controls.Add(statusStrip3);
            checkStatusPanel.Dock = DockStyle.Fill;
            checkStatusPanel.Font = new Font("Segoe UI", 12F);
            checkStatusPanel.Location = new Point(0, 0);
            checkStatusPanel.Name = "checkStatusPanel";
            checkStatusPanel.Size = new Size(1280, 720);
            checkStatusPanel.TabIndex = 0;
            // 
            // metadataTableLayout
            // 
            metadataTableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            metadataTableLayout.ColumnCount = 3;
            metadataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            metadataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            metadataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            metadataTableLayout.Controls.Add(txtSourceSystem, 0, 1);
            metadataTableLayout.Controls.Add(lblSourceSystem, 0, 0);
            metadataTableLayout.Controls.Add(txtChannel, 1, 1);
            metadataTableLayout.Controls.Add(lblChannel, 1, 0);
            metadataTableLayout.Controls.Add(txtSessionID, 2, 1);
            metadataTableLayout.Controls.Add(lblSessionID, 2, 0);
            metadataTableLayout.Controls.Add(txtMessageID, 0, 3);
            metadataTableLayout.Controls.Add(lblMessageID, 0, 2);
            metadataTableLayout.Controls.Add(txtUserCode, 1, 3);
            metadataTableLayout.Controls.Add(lblUserCode, 1, 2);
            metadataTableLayout.Controls.Add(lblApiUrl, 2, 2);
            metadataTableLayout.Controls.Add(lblInteractionDate, 0, 4);
            metadataTableLayout.Controls.Add(txtApiUrl, 2, 3);
            metadataTableLayout.Controls.Add(pickerInteractionDateTime, 0, 5);
            metadataTableLayout.Location = new Point(12, 12);
            metadataTableLayout.Name = "metadataTableLayout";
            metadataTableLayout.RowCount = 6;
            metadataTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            metadataTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            metadataTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            metadataTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            metadataTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            metadataTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            metadataTableLayout.Size = new Size(1256, 210);
            metadataTableLayout.TabIndex = 2;
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSourceSystem.Font = new Font("Segoe UI", 12F);
            txtSourceSystem.Location = new Point(3, 35);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new Size(412, 29);
            txtSourceSystem.TabIndex = 0;
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new Font("Segoe UI", 12F);
            lblSourceSystem.Location = new Point(3, 0);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new Size(116, 21);
            lblSourceSystem.TabIndex = 0;
            lblSourceSystem.Text = "Source System:";
            // 
            // txtChannel
            // 
            txtChannel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtChannel.Font = new Font("Segoe UI", 12F);
            txtChannel.Location = new Point(421, 35);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(412, 29);
            txtChannel.TabIndex = 1;
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Font = new Font("Segoe UI", 12F);
            lblChannel.Location = new Point(421, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(70, 21);
            lblChannel.TabIndex = 0;
            lblChannel.Text = "Channel:";
            // 
            // txtSessionID
            // 
            txtSessionID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSessionID.Font = new Font("Segoe UI", 12F);
            txtSessionID.Location = new Point(839, 35);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.Size = new Size(414, 29);
            txtSessionID.TabIndex = 2;
            // 
            // lblSessionID
            // 
            lblSessionID.AutoSize = true;
            lblSessionID.Font = new Font("Segoe UI", 12F);
            lblSessionID.Location = new Point(839, 0);
            lblSessionID.Name = "lblSessionID";
            lblSessionID.Size = new Size(85, 21);
            lblSessionID.TabIndex = 0;
            lblSessionID.Text = "Session ID:";
            // 
            // txtMessageID
            // 
            txtMessageID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMessageID.Font = new Font("Segoe UI", 12F);
            txtMessageID.Location = new Point(3, 105);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(412, 29);
            txtMessageID.TabIndex = 3;
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Font = new Font("Segoe UI", 12F);
            lblMessageID.Location = new Point(3, 70);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new Size(93, 21);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // txtUserCode
            // 
            txtUserCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUserCode.Font = new Font("Segoe UI", 12F);
            txtUserCode.Location = new Point(421, 105);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new Size(412, 29);
            txtUserCode.TabIndex = 4;
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new Font("Segoe UI", 12F);
            lblUserCode.Location = new Point(421, 70);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new Size(64, 21);
            lblUserCode.TabIndex = 0;
            lblUserCode.Text = "User ID:";
            // 
            // lblApiUrl
            // 
            lblApiUrl.AutoSize = true;
            lblApiUrl.Font = new Font("Segoe UI", 12F);
            lblApiUrl.Location = new Point(839, 70);
            lblApiUrl.Name = "lblApiUrl";
            lblApiUrl.Size = new Size(69, 21);
            lblApiUrl.TabIndex = 7;
            lblApiUrl.Text = "API URL:";
            // 
            // lblInteractionDate
            // 
            lblInteractionDate.AutoSize = true;
            lblInteractionDate.Font = new Font("Segoe UI", 12F);
            lblInteractionDate.Location = new Point(3, 140);
            lblInteractionDate.Name = "lblInteractionDate";
            lblInteractionDate.Size = new Size(161, 21);
            lblInteractionDate.TabIndex = 0;
            lblInteractionDate.Text = "Interaction Date Time:";
            // 
            // txtApiUrl
            // 
            txtApiUrl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApiUrl.Font = new Font("Segoe UI", 12F);
            txtApiUrl.Location = new Point(839, 105);
            txtApiUrl.Name = "txtApiUrl";
            txtApiUrl.Size = new Size(414, 29);
            txtApiUrl.TabIndex = 6;
            // 
            // pickerInteractionDateTime
            // 
            pickerInteractionDateTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pickerInteractionDateTime.CustomFormat = "ddd, dd MMM yyyy hh:mm tt";
            pickerInteractionDateTime.Font = new Font("Segoe UI", 12F);
            pickerInteractionDateTime.Format = DateTimePickerFormat.Custom;
            pickerInteractionDateTime.Location = new Point(3, 175);
            pickerInteractionDateTime.Name = "pickerInteractionDateTime";
            pickerInteractionDateTime.Size = new Size(412, 29);
            pickerInteractionDateTime.TabIndex = 5;
            // 
            // tableLayout3
            // 
            tableLayout3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayout3.ColumnCount = 2;
            tableLayout3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5796165F));
            tableLayout3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.4203835F));
            tableLayout3.Controls.Add(lblVerificationStatus, 1, 0);
            tableLayout3.Controls.Add(VerificationStatusTree, 1, 1);
            tableLayout3.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayout3.Controls.Add(dataGridViewRequests, 0, 1);
            tableLayout3.Controls.Add(lblRequestGuid, 0, 0);
            tableLayout3.Controls.Add(btnCheckStatus, 0, 3);
            tableLayout3.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayout3.Location = new Point(12, 228);
            tableLayout3.Name = "tableLayout3";
            tableLayout3.RowCount = 5;
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayout3.Size = new Size(1256, 470);
            tableLayout3.TabIndex = 0;
            // 
            // lblVerificationStatus
            // 
            lblVerificationStatus.AutoSize = true;
            lblVerificationStatus.Font = new Font("Segoe UI", 12F);
            lblVerificationStatus.Location = new Point(475, 0);
            lblVerificationStatus.Name = "lblVerificationStatus";
            lblVerificationStatus.Size = new Size(137, 21);
            lblVerificationStatus.TabIndex = 2;
            lblVerificationStatus.Text = "Verification Status:";
            // 
            // VerificationStatusTree
            // 
            VerificationStatusTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VerificationStatusTree.Font = new Font("Segoe UI", 12F);
            VerificationStatusTree.Location = new Point(475, 33);
            VerificationStatusTree.Name = "VerificationStatusTree";
            VerificationStatusTree.Size = new Size(778, 296);
            VerificationStatusTree.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnExpandAll, 0, 0);
            tableLayoutPanel4.Controls.Add(btnCollapseAll, 1, 0);
            tableLayoutPanel4.Location = new Point(730, 335);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(523, 40);
            tableLayoutPanel4.TabIndex = 27;
            // 
            // btnExpandAll
            // 
            btnExpandAll.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnExpandAll.BackColor = Color.RoyalBlue;
            btnExpandAll.FlatStyle = FlatStyle.Flat;
            btnExpandAll.Font = new Font("Segoe UI", 12F);
            btnExpandAll.ForeColor = Color.White;
            btnExpandAll.Location = new Point(3, 3);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new Size(255, 34);
            btnExpandAll.TabIndex = 4;
            btnExpandAll.Text = "Expand All";
            btnExpandAll.UseVisualStyleBackColor = false;
            // 
            // btnCollapseAll
            // 
            btnCollapseAll.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCollapseAll.BackColor = Color.RoyalBlue;
            btnCollapseAll.FlatStyle = FlatStyle.Flat;
            btnCollapseAll.Font = new Font("Segoe UI", 12F);
            btnCollapseAll.ForeColor = Color.White;
            btnCollapseAll.Location = new Point(264, 3);
            btnCollapseAll.Name = "btnCollapseAll";
            btnCollapseAll.Size = new Size(256, 34);
            btnCollapseAll.TabIndex = 5;
            btnCollapseAll.Text = "Collapse All";
            btnCollapseAll.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Columns.AddRange(new DataGridViewColumn[] { Select, RequestGuid, Details });
            dataGridViewRequests.Font = new Font("Segoe UI", 12F);
            dataGridViewRequests.Location = new Point(3, 33);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.RowHeadersWidth = 51;
            dataGridViewRequests.Size = new Size(466, 296);
            dataGridViewRequests.TabIndex = 1;
            // 
            // lblRequestGuid
            // 
            lblRequestGuid.AutoSize = true;
            lblRequestGuid.Font = new Font("Segoe UI", 12F);
            lblRequestGuid.Location = new Point(3, 0);
            lblRequestGuid.Name = "lblRequestGuid";
            lblRequestGuid.Size = new Size(113, 21);
            lblRequestGuid.TabIndex = 0;
            lblRequestGuid.Text = "Request Guids:";
            // 
            // btnCheckStatus
            // 
            btnCheckStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCheckStatus.BackColor = Color.RoyalBlue;
            btnCheckStatus.FlatStyle = FlatStyle.Flat;
            btnCheckStatus.Font = new Font("Segoe UI", 12F);
            btnCheckStatus.ForeColor = Color.White;
            btnCheckStatus.Location = new Point(3, 381);
            btnCheckStatus.Name = "btnCheckStatus";
            btnCheckStatus.Size = new Size(466, 40);
            btnCheckStatus.TabIndex = 4;
            btnCheckStatus.Text = "Check Status";
            btnCheckStatus.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnUncheckAll, 1, 0);
            tableLayoutPanel1.Controls.Add(btnCheckAll, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 335);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(466, 40);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // btnUncheckAll
            // 
            btnUncheckAll.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUncheckAll.BackColor = Color.RoyalBlue;
            btnUncheckAll.FlatStyle = FlatStyle.Flat;
            btnUncheckAll.Font = new Font("Segoe UI", 12F);
            btnUncheckAll.ForeColor = Color.White;
            btnUncheckAll.Location = new Point(236, 3);
            btnUncheckAll.Name = "btnUncheckAll";
            btnUncheckAll.Size = new Size(227, 34);
            btnUncheckAll.TabIndex = 7;
            btnUncheckAll.Text = "Uncheck All";
            btnUncheckAll.UseVisualStyleBackColor = false;
            // 
            // btnCheckAll
            // 
            btnCheckAll.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCheckAll.BackColor = Color.RoyalBlue;
            btnCheckAll.FlatStyle = FlatStyle.Flat;
            btnCheckAll.Font = new Font("Segoe UI", 12F);
            btnCheckAll.ForeColor = Color.White;
            btnCheckAll.Location = new Point(3, 3);
            btnCheckAll.Name = "btnCheckAll";
            btnCheckAll.Size = new Size(227, 34);
            btnCheckAll.TabIndex = 6;
            btnCheckAll.Text = "Check All";
            btnCheckAll.UseVisualStyleBackColor = false;
            // 
            // statusStrip3
            // 
            statusStrip3.Font = new Font("Segoe UI", 10F);
            statusStrip3.Items.AddRange(new ToolStripItem[] { statusLabel3, toolStripProgressBar1 });
            statusStrip3.Location = new Point(0, 698);
            statusStrip3.Name = "statusStrip3";
            statusStrip3.Size = new Size(1280, 22);
            statusStrip3.TabIndex = 1;
            // 
            // statusLabel3
            // 
            statusLabel3.Name = "statusLabel3";
            statusLabel3.Size = new Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            toolStripProgressBar1.Visible = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // Select
            // 
            Select.FillWeight = 39.17466F;
            Select.HeaderText = "Select";
            Select.Name = "Select";
            // 
            // RequestGuid
            // 
            RequestGuid.FillWeight = 215.140076F;
            RequestGuid.HeaderText = "Request Guid";
            RequestGuid.Name = "RequestGuid";
            // 
            // Details
            // 
            Details.DataPropertyName = "Details";
            Details.FillWeight = 45.6852837F;
            Details.HeaderText = "Details";
            Details.Name = "Details";
            Details.Text = "View Details";
            Details.UseColumnTextForButtonValue = true;
            // 
            // CheckStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1280, 720);
            Controls.Add(checkStatusPanel);
            Name = "CheckStatusForm";
            Text = "Check Status";
            checkStatusPanel.ResumeLayout(false);
            checkStatusPanel.PerformLayout();
            metadataTableLayout.ResumeLayout(false);
            metadataTableLayout.PerformLayout();
            tableLayout3.ResumeLayout(false);
            tableLayout3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            statusStrip3.ResumeLayout(false);
            statusStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn RequestGuid;
        private DataGridViewButtonColumn Details;
    }
}