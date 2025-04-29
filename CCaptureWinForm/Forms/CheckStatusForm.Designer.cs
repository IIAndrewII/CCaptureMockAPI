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
            checkStatusPanel = new System.Windows.Forms.Panel();
            metadataTableLayout = new System.Windows.Forms.TableLayoutPanel();
            txtSourceSystem = new System.Windows.Forms.TextBox();
            lblSourceSystem = new System.Windows.Forms.Label();
            txtChannel = new System.Windows.Forms.TextBox();
            lblChannel = new System.Windows.Forms.Label();
            txtSessionID = new System.Windows.Forms.TextBox();
            lblSessionID = new System.Windows.Forms.Label();
            txtMessageID = new System.Windows.Forms.TextBox();
            lblMessageID = new System.Windows.Forms.Label();
            txtUserCode = new System.Windows.Forms.TextBox();
            lblUserCode = new System.Windows.Forms.Label();
            pickerInteractionDateTime = new System.Windows.Forms.DateTimePicker();
            lblInteractionDate = new System.Windows.Forms.Label();
            tableLayout3 = new System.Windows.Forms.TableLayoutPanel();
            lblVerificationStatus = new System.Windows.Forms.Label();
            VerificationStatusTree = new System.Windows.Forms.TreeView();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnExpandAll = new System.Windows.Forms.Button();
            btnCollapseAll = new System.Windows.Forms.Button();
            dataGridViewRequests = new System.Windows.Forms.DataGridView();
            lblRequestGuid = new System.Windows.Forms.Label();
            btnCheckStatus = new System.Windows.Forms.Button();
            statusStrip3 = new System.Windows.Forms.StatusStrip();
            statusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            checkStatusPanel.SuspendLayout();
            metadataTableLayout.SuspendLayout();
            tableLayout3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewRequests)).BeginInit();
            statusStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider)).BeginInit();
            SuspendLayout();
            // 
            // checkStatusPanel
            // 
            checkStatusPanel.Controls.Add(metadataTableLayout);
            checkStatusPanel.Controls.Add(tableLayout3);
            checkStatusPanel.Controls.Add(statusStrip3);
            checkStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            checkStatusPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            checkStatusPanel.Location = new System.Drawing.Point(0, 0);
            checkStatusPanel.Name = "checkStatusPanel";
            checkStatusPanel.Size = new System.Drawing.Size(1200, 583);
            checkStatusPanel.TabIndex = 0;
            // 
            // metadataTableLayout
            // 
            metadataTableLayout.ColumnCount = 6;
            metadataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            metadataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.33F));
            metadataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            metadataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.33F));
            metadataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            metadataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.33F));
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
            metadataTableLayout.Controls.Add(pickerInteractionDateTime, 4, 3);
            metadataTableLayout.Controls.Add(lblInteractionDate, 4, 2);
            metadataTableLayout.Location = new System.Drawing.Point(12, 12);
            metadataTableLayout.Name = "metadataTableLayout";
            metadataTableLayout.RowCount = 4;
            metadataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            metadataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            metadataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            metadataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            metadataTableLayout.Size = new System.Drawing.Size(1176, 140);
            metadataTableLayout.TabIndex = 2;
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSourceSystem.Location = new System.Drawing.Point(3, 33);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new System.Drawing.Size(346, 29);
            txtSourceSystem.TabIndex = 0;
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSourceSystem.Location = new System.Drawing.Point(3, 0);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new System.Drawing.Size(116, 21);
            lblSourceSystem.TabIndex = 0;
            lblSourceSystem.Text = "Source System:";
            // 
            // txtChannel
            // 
            txtChannel.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtChannel.Location = new System.Drawing.Point(394, 33);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new System.Drawing.Size(346, 29);
            txtChannel.TabIndex = 1;
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblChannel.Location = new System.Drawing.Point(394, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new System.Drawing.Size(70, 21);
            lblChannel.TabIndex = 0;
            lblChannel.Text = "Channel:";
            // 
            // txtSessionID
            // 
            txtSessionID.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSessionID.Location = new System.Drawing.Point(785, 33);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.Size = new System.Drawing.Size(346, 29);
            txtSessionID.TabIndex = 2;
            // 
            // lblSessionID
            // 
            lblSessionID.AutoSize = true;
            lblSessionID.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSessionID.Location = new System.Drawing.Point(785, 0);
            lblSessionID.Name = "lblSessionID";
            lblSessionID.Size = new System.Drawing.Size(85, 21);
            lblSessionID.TabIndex = 0;
            lblSessionID.Text = "Session ID:";
            // 
            // txtMessageID
            // 
            txtMessageID.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtMessageID.Location = new System.Drawing.Point(3, 103);
            txtMessageID.Name = "txtMessageID";
            txtMessageID.Size = new System.Drawing.Size(346, 29);
            txtMessageID.TabIndex = 3;
            // 
            // lblMessageID
            // 
            lblMessageID.AutoSize = true;
            lblMessageID.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblMessageID.Location = new System.Drawing.Point(3, 70);
            lblMessageID.Name = "lblMessageID";
            lblMessageID.Size = new System.Drawing.Size(93, 21);
            lblMessageID.TabIndex = 0;
            lblMessageID.Text = "Message ID:";
            // 
            // txtUserCode
            // 
            txtUserCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtUserCode.Location = new System.Drawing.Point(394, 103);
            txtUserCode.Name = "txtUserCode";
            txtUserCode.Size = new System.Drawing.Size(346, 29);
            txtUserCode.TabIndex = 4;
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblUserCode.Location = new System.Drawing.Point(394, 70);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new System.Drawing.Size(64, 21);
            lblUserCode.TabIndex = 0;
            lblUserCode.Text = "User ID:";
            // 
            // pickerInteractionDateTime
            // 
            pickerInteractionDateTime.CustomFormat = "ddd, dd MMM yyyy hh:mm tt";
            pickerInteractionDateTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            pickerInteractionDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            pickerInteractionDateTime.Location = new System.Drawing.Point(785, 103);
            pickerInteractionDateTime.Name = "pickerInteractionDateTime";
            pickerInteractionDateTime.Size = new System.Drawing.Size(346, 29);
            pickerInteractionDateTime.TabIndex = 5;
            // 
            // lblInteractionDate
            // 
            lblInteractionDate.AutoSize = true;
            lblInteractionDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblInteractionDate.Location = new System.Drawing.Point(785, 70);
            lblInteractionDate.Name = "lblInteractionDate";
            lblInteractionDate.Size = new System.Drawing.Size(161, 21);
            lblInteractionDate.TabIndex = 0;
            lblInteractionDate.Text = "Interaction Date Time:";
            // 
            // tableLayout3
            // 
            tableLayout3.ColumnCount = 2;
            tableLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tableLayout3.Controls.Add(lblVerificationStatus, 1, 0);
            tableLayout3.Controls.Add(VerificationStatusTree, 1, 1);
            tableLayout3.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayout3.Controls.Add(dataGridViewRequests, 0, 1);
            tableLayout3.Controls.Add(lblRequestGuid, 0, 0);
            tableLayout3.Controls.Add(btnCheckStatus, 0, 2);
            tableLayout3.Location = new System.Drawing.Point(12, 160);
            tableLayout3.Name = "tableLayout3";
            tableLayout3.RowCount = 4;
            tableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayout3.Size = new System.Drawing.Size(1176, 439);
            tableLayout3.TabIndex = 0;
            // 
            // lblVerificationStatus
            // 
            lblVerificationStatus.AutoSize = true;
            lblVerificationStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblVerificationStatus.Location = new System.Drawing.Point(355, 0);
            lblVerificationStatus.Name = "lblVerificationStatus";
            lblVerificationStatus.Size = new System.Drawing.Size(137, 21);
            lblVerificationStatus.TabIndex = 2;
            lblVerificationStatus.Text = "Verification Status:";
            // 
            // VerificationStatusTree
            // 
            VerificationStatusTree.Font = new System.Drawing.Font("Segoe UI", 12F);
            VerificationStatusTree.Location = new System.Drawing.Point(355, 33);
            VerificationStatusTree.Name = "VerificationStatusTree";
            VerificationStatusTree.Size = new System.Drawing.Size(818, 303);
            VerificationStatusTree.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnExpandAll, 0, 0);
            tableLayoutPanel4.Controls.Add(btnCollapseAll, 1, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(827, 342);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(346, 44);
            tableLayoutPanel4.TabIndex = 27;
            // 
            // btnExpandAll
            // 
            btnExpandAll.BackColor = System.Drawing.Color.RoyalBlue;
            btnExpandAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExpandAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnExpandAll.ForeColor = System.Drawing.Color.White;
            btnExpandAll.Location = new System.Drawing.Point(3, 3);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new System.Drawing.Size(167, 32);
            btnExpandAll.TabIndex = 4;
            btnExpandAll.Text = "Expand All";
            btnExpandAll.UseVisualStyleBackColor = false;
            // 
            // btnCollapseAll
            // 
            btnCollapseAll.BackColor = System.Drawing.Color.RoyalBlue;
            btnCollapseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCollapseAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnCollapseAll.ForeColor = System.Drawing.Color.White;
            btnCollapseAll.Location = new System.Drawing.Point(176, 3);
            btnCollapseAll.Name = "btnCollapseAll";
            btnCollapseAll.Size = new System.Drawing.Size(167, 31);
            btnCollapseAll.TabIndex = 5;
            btnCollapseAll.Text = "Collapse All";
            btnCollapseAll.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewRequests.Location = new System.Drawing.Point(3, 33);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.RowHeadersWidth = 51;
            dataGridViewRequests.Size = new System.Drawing.Size(346, 303);
            dataGridViewRequests.TabIndex = 1;
            // 
            // lblRequestGuid
            // 
            lblRequestGuid.AutoSize = true;
            lblRequestGuid.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblRequestGuid.Location = new System.Drawing.Point(3, 0);
            lblRequestGuid.Name = "lblRequestGuid";
            lblRequestGuid.Size = new System.Drawing.Size(113, 21);
            lblRequestGuid.TabIndex = 0;
            lblRequestGuid.Text = "Request Guids:";
            // 
            // btnCheckStatus
            // 
            btnCheckStatus.BackColor = System.Drawing.Color.RoyalBlue;
            btnCheckStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheckStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnCheckStatus.ForeColor = System.Drawing.Color.White;
            btnCheckStatus.Location = new System.Drawing.Point(3, 342);
            btnCheckStatus.Name = "btnCheckStatus";
            btnCheckStatus.Size = new System.Drawing.Size(346, 44);
            btnCheckStatus.TabIndex = 4;
            btnCheckStatus.Text = "Check Status";
            btnCheckStatus.UseVisualStyleBackColor = false;
            // 
            // statusStrip3
            // 
            statusStrip3.Font = new System.Drawing.Font("Segoe UI", 10F);
            statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel3, toolStripProgressBar1 });
            statusStrip3.Location = new System.Drawing.Point(0, 561);
            statusStrip3.Name = "statusStrip3";
            statusStrip3.Size = new System.Drawing.Size(1200, 22);
            statusStrip3.TabIndex = 1;
            // 
            // statusLabel3
            // 
            statusLabel3.Name = "statusLabel3";
            statusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            toolStripProgressBar1.Visible = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // CheckStatusForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            ClientSize = new System.Drawing.Size(1200, 583);
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
            ((System.ComponentModel.ISupportInitialize)(dataGridViewRequests)).EndInit();
            statusStrip3.ResumeLayout(false);
            statusStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider)).EndInit();
            ResumeLayout(false);
        }
    }
}