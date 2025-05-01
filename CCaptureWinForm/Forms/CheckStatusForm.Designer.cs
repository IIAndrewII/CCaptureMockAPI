namespace CCaptureWinForm
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
            statusStrip3 = new StatusStrip();
            statusLabel3 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            errorProvider = new ErrorProvider(components);
            checkStatusPanel.SuspendLayout();
            metadataTableLayout.SuspendLayout();
            tableLayout3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
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
            checkStatusPanel.Size = new Size(1200, 583);
            checkStatusPanel.TabIndex = 0;
            // 
            // metadataTableLayout
            // 
            metadataTableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            metadataTableLayout.ColumnCount = 6;
            metadataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0029984F));
            metadataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.33033276F));
            metadataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0029984F));
            metadataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.33033276F));
            metadataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0029984F));
            metadataTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.33033276F));
            metadataTableLayout.Controls.Add(txtSourceSystem, 0, 1);
            metadataTableLayout.Controls.Add(lblSourceSystem, 0, 0);
            metadataTableLayout.Controls.Add(txtChannel, 2, 1);
            metadataTableLayout.Controls.Add(lblChannel, 2, 0);
            metadataTableLayout.Controls.Add(txtSessionID, 4, 1);
            metadataTableLayout.Controls.Add(lblSessionID, 4, 0);
            metadataTableLayout.Controls.Add(txtMessageID, 0, 3);
            metadataTableLayout.Controls.Add(lblMessageID, 0, 2);
            metadataTableLayout.Controls.Add(txtUserCode, 2, 3);
            metadataTableLayout.Controls.Add(lblUserCode, 2, 2);
            metadataTableLayout.Controls.Add(lblApiUrl, 4, 2);
            metadataTableLayout.Controls.Add(lblInteractionDate, 0, 4);
            metadataTableLayout.Controls.Add(txtApiUrl, 4, 3);
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
            metadataTableLayout.Size = new Size(1176, 215);
            metadataTableLayout.TabIndex = 2;
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.Font = new Font("Segoe UI", 12F);
            txtSourceSystem.Location = new Point(3, 33);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new Size(346, 29);
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
            txtChannel.Font = new Font("Segoe UI", 12F);
            txtChannel.Location = new Point(394, 33);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(346, 29);
            txtChannel.TabIndex = 1;
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Font = new Font("Segoe UI", 12F);
            lblChannel.Location = new Point(394, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(70, 21);
            lblChannel.TabIndex = 0;
            lblChannel.Text = "Channel:";
            // 
            // txtSessionID
            // 
            txtSessionID.Font = new Font("Segoe UI", 12F);
            txtSessionID.Location = new Point(785, 33);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.Size = new Size(346, 29);
            txtSessionID.TabIndex = 2;
            // 
            // lblSessionID
            // 
            lblSessionID.AutoSize = true;
            lblSessionID.Font = new Font("Segoe UI", 12F);
            lblSessionID.Location = new Point(785, 0);
            lblSessionID.Name = "lblSessionID";
            lblSessionID.Size = new Size(85, 21);
            lblSessionID.TabIndex = 0;
            lblSessionID.Text = "Session ID:";
            // 
            // txtMessageID
            // 
            txtMessageID.Font = new Font("Segoe UI", 12F);
            txtMessageID.Location = new Point(3, 103);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new Size(346, 29);
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
            txtUserCode.Font = new Font("Segoe UI", 12F);
            txtUserCode.Location = new Point(394, 103);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new Size(346, 29);
            txtUserCode.TabIndex = 4;
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new Font("Segoe UI", 12F);
            lblUserCode.Location = new Point(394, 70);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new Size(64, 21);
            lblUserCode.TabIndex = 0;
            lblUserCode.Text = "User ID:";
            // 
            // lblApiUrl
            // 
            lblApiUrl.AutoSize = true;
            lblApiUrl.Font = new Font("Segoe UI", 12F);
            lblApiUrl.Location = new Point(785, 70);
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
            txtApiUrl.Font = new Font("Segoe UI", 12F);
            txtApiUrl.Location = new Point(785, 103);
            txtApiUrl.Name = "txtApiUrl";
            txtApiUrl.Size = new Size(346, 29);
            txtApiUrl.TabIndex = 6;
            // 
            // pickerInteractionDateTime
            // 
            pickerInteractionDateTime.CustomFormat = "ddd, dd MMM yyyy hh:mm tt";
            pickerInteractionDateTime.Font = new Font("Segoe UI", 12F);
            pickerInteractionDateTime.Format = DateTimePickerFormat.Custom;
            pickerInteractionDateTime.Location = new Point(3, 173);
            pickerInteractionDateTime.Name = "pickerInteractionDateTime";
            pickerInteractionDateTime.Size = new Size(346, 29);
            pickerInteractionDateTime.TabIndex = 5;
            // 
            // tableLayout3
            // 
            tableLayout3.ColumnCount = 2;
            tableLayout3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayout3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayout3.Controls.Add(lblVerificationStatus, 1, 0);
            tableLayout3.Controls.Add(VerificationStatusTree, 1, 1);
            tableLayout3.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayout3.Controls.Add(dataGridViewRequests, 0, 1);
            tableLayout3.Controls.Add(lblRequestGuid, 0, 0);
            tableLayout3.Controls.Add(btnCheckStatus, 0, 2);
            tableLayout3.Location = new Point(12, 233);
            tableLayout3.Name = "tableLayout3";
            tableLayout3.RowCount = 4;
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayout3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayout3.Size = new Size(1176, 325);
            tableLayout3.TabIndex = 0;
            // 
            // lblVerificationStatus
            // 
            lblVerificationStatus.AutoSize = true;
            lblVerificationStatus.Font = new Font("Segoe UI", 12F);
            lblVerificationStatus.Location = new Point(355, 0);
            lblVerificationStatus.Name = "lblVerificationStatus";
            lblVerificationStatus.Size = new Size(137, 21);
            lblVerificationStatus.TabIndex = 2;
            lblVerificationStatus.Text = "Verification Status:";
            // 
            // VerificationStatusTree
            // 
            VerificationStatusTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VerificationStatusTree.Font = new Font("Segoe UI", 12F);
            VerificationStatusTree.Location = new Point(355, 33);
            VerificationStatusTree.Name = "VerificationStatusTree";
            VerificationStatusTree.Size = new Size(818, 211);
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
            tableLayoutPanel4.Location = new Point(827, 250);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(346, 40);
            tableLayoutPanel4.TabIndex = 27;
            // 
            // btnExpandAll
            // 
            btnExpandAll.BackColor = Color.RoyalBlue;
            btnExpandAll.FlatStyle = FlatStyle.Flat;
            btnExpandAll.Font = new Font("Segoe UI", 12F);
            btnExpandAll.ForeColor = Color.White;
            btnExpandAll.Location = new Point(3, 3);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new Size(167, 32);
            btnExpandAll.TabIndex = 4;
            btnExpandAll.Text = "Expand All";
            btnExpandAll.UseVisualStyleBackColor = false;
            // 
            // btnCollapseAll
            // 
            btnCollapseAll.BackColor = Color.RoyalBlue;
            btnCollapseAll.FlatStyle = FlatStyle.Flat;
            btnCollapseAll.Font = new Font("Segoe UI", 12F);
            btnCollapseAll.ForeColor = Color.White;
            btnCollapseAll.Location = new Point(176, 3);
            btnCollapseAll.Name = "btnCollapseAll";
            btnCollapseAll.Size = new Size(167, 31);
            btnCollapseAll.TabIndex = 5;
            btnCollapseAll.Text = "Collapse All";
            btnCollapseAll.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Font = new Font("Segoe UI", 12F);
            dataGridViewRequests.Location = new Point(3, 33);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.RowHeadersWidth = 51;
            dataGridViewRequests.Size = new Size(346, 211);
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
            btnCheckStatus.BackColor = Color.RoyalBlue;
            btnCheckStatus.FlatStyle = FlatStyle.Flat;
            btnCheckStatus.Font = new Font("Segoe UI", 12F);
            btnCheckStatus.ForeColor = Color.White;
            btnCheckStatus.Location = new Point(3, 250);
            btnCheckStatus.Name = "btnCheckStatus";
            btnCheckStatus.Size = new Size(346, 40);
            btnCheckStatus.TabIndex = 4;
            btnCheckStatus.Text = "Check Status";
            btnCheckStatus.UseVisualStyleBackColor = false;
            // 
            // statusStrip3
            // 
            statusStrip3.Font = new Font("Segoe UI", 10F);
            statusStrip3.Items.AddRange(new ToolStripItem[] { statusLabel3, toolStripProgressBar1 });
            statusStrip3.Location = new Point(0, 561);
            statusStrip3.Name = "statusStrip3";
            statusStrip3.Size = new Size(1200, 22);
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
            // CheckStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1200, 583);
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
            statusStrip3.ResumeLayout(false);
            statusStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }
        private TextBox txtApiUrl;
        private Label lblApiUrl;
    }
}