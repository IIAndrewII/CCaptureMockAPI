namespace CCaptureWinForm
{
    partial class ResponsesHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label lblVerificationResponses;
        private System.Windows.Forms.DataGridView dataGridViewResponses;
        private System.Windows.Forms.Label lblVerificationStatus;
        private System.Windows.Forms.TreeView VerificationStatusTree;
        private System.Windows.Forms.TableLayoutPanel treeButtonLayout;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnCollapseAll;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;

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
            mainPanel = new Panel();
            tableLayout = new TableLayoutPanel();
            treeButtonLayout = new TableLayoutPanel();
            btnRefresh = new Button();
            btnExpandAll = new Button();
            btnCollapseAll = new Button();
            VerificationStatusTree = new TreeView();
            lblVerificationStatus = new Label();
            dataGridViewResponses = new DataGridView();
            lblVerificationResponses = new Label();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            mainPanel.SuspendLayout();
            tableLayout.SuspendLayout();
            treeButtonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResponses).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(tableLayout);
            mainPanel.Controls.Add(statusStrip);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Font = new Font("Segoe UI", 12F);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1200, 800);
            mainPanel.TabIndex = 0;
            // 
            // tableLayout
            // 
            tableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayout.ColumnCount = 1;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout.Controls.Add(treeButtonLayout, 0, 4);
            tableLayout.Controls.Add(VerificationStatusTree, 0, 3);
            tableLayout.Controls.Add(lblVerificationStatus, 0, 2);
            tableLayout.Controls.Add(dataGridViewResponses, 0, 1);
            tableLayout.Controls.Add(lblVerificationResponses, 0, 0);
            tableLayout.Location = new Point(3, 12);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 5;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4.094555F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 42.2119064F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4.094555F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 42.2119064F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.387083F));
            tableLayout.Size = new Size(1193, 756);
            tableLayout.TabIndex = 0;
            // 
            // treeButtonLayout
            // 
            treeButtonLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            treeButtonLayout.ColumnCount = 4;
            treeButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            treeButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            treeButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            treeButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            treeButtonLayout.Controls.Add(btnRefresh, 0, 0);
            treeButtonLayout.Controls.Add(btnExpandAll, 2, 0);
            treeButtonLayout.Controls.Add(btnCollapseAll, 3, 0);
            treeButtonLayout.Location = new Point(3, 701);
            treeButtonLayout.Name = "treeButtonLayout";
            treeButtonLayout.RowCount = 1;
            treeButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            treeButtonLayout.Size = new Size(1187, 52);
            treeButtonLayout.TabIndex = 4;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRefresh.BackColor = Color.ForestGreen;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(3, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(290, 46);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnExpandAll
            // 
            btnExpandAll.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnExpandAll.BackColor = Color.RoyalBlue;
            btnExpandAll.FlatStyle = FlatStyle.Flat;
            btnExpandAll.Font = new Font("Segoe UI", 12F);
            btnExpandAll.ForeColor = Color.White;
            btnExpandAll.Location = new Point(595, 3);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new Size(290, 46);
            btnExpandAll.TabIndex = 0;
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
            btnCollapseAll.Location = new Point(891, 3);
            btnCollapseAll.Name = "btnCollapseAll";
            btnCollapseAll.Size = new Size(293, 46);
            btnCollapseAll.TabIndex = 1;
            btnCollapseAll.Text = "Collapse All";
            btnCollapseAll.UseVisualStyleBackColor = false;
            // 
            // VerificationStatusTree
            // 
            VerificationStatusTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VerificationStatusTree.Font = new Font("Segoe UI", 12F);
            VerificationStatusTree.Location = new Point(3, 382);
            VerificationStatusTree.Name = "VerificationStatusTree";
            VerificationStatusTree.Size = new Size(1187, 313);
            VerificationStatusTree.TabIndex = 3;
            // 
            // lblVerificationStatus
            // 
            lblVerificationStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblVerificationStatus.AutoSize = true;
            lblVerificationStatus.Font = new Font("Segoe UI", 12F);
            lblVerificationStatus.Location = new Point(3, 351);
            lblVerificationStatus.Name = "lblVerificationStatus";
            lblVerificationStatus.Size = new Size(172, 28);
            lblVerificationStatus.TabIndex = 2;
            lblVerificationStatus.Text = "Verification Status:";
            // 
            // dataGridViewResponses
            // 
            dataGridViewResponses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewResponses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResponses.Font = new Font("Segoe UI", 12F);
            dataGridViewResponses.Location = new Point(3, 33);
            dataGridViewResponses.Name = "dataGridViewResponses";
            dataGridViewResponses.RowHeadersWidth = 51;
            dataGridViewResponses.Size = new Size(1187, 313);
            dataGridViewResponses.TabIndex = 1;
            // 
            // lblVerificationResponses
            // 
            lblVerificationResponses.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblVerificationResponses.AutoSize = true;
            lblVerificationResponses.Font = new Font("Segoe UI", 12F);
            lblVerificationResponses.Location = new Point(3, 2);
            lblVerificationResponses.Name = "lblVerificationResponses";
            lblVerificationResponses.Size = new Size(208, 28);
            lblVerificationResponses.TabIndex = 0;
            lblVerificationResponses.Text = "Check Status Requests:";
            // 
            // statusStrip
            // 
            statusStrip.Font = new Font("Segoe UI", 10F);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 778);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1200, 22);
            statusStrip.TabIndex = 1;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 16);
            // 
            // ResponsesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1200, 800);
            Controls.Add(mainPanel);
            Name = "ResponsesHistoryForm";
            Text = "Responses History";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            treeButtonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResponses).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
        }
        private Button btnRefresh;
    }
}