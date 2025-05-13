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
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TableLayoutPanel filterLayout;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker datePickerStart;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label lblSourceSystem;
        private System.Windows.Forms.TextBox txtSourceSystem;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.TextBox txtChannel;

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
            filterLayout = new TableLayoutPanel();
            lblStartDate = new Label();
            datePickerStart = new DateTimePicker();
            lblEndDate = new Label();
            datePickerEnd = new DateTimePicker();
            lblStatus = new Label();
            comboBoxStatus = new ComboBox();
            lblSourceSystem = new Label();
            txtSourceSystem = new TextBox();
            lblChannel = new Label();
            txtChannel = new TextBox();
            btnApplyFilters = new Button();
            lblVerificationResponses = new Label();
            dataGridViewResponses = new DataGridView();
            lblVerificationStatus = new Label();
            VerificationStatusTree = new TreeView();
            treeButtonLayout = new TableLayoutPanel();
            btnRefresh = new Button();
            btnExpandAll = new Button();
            btnCollapseAll = new Button();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            mainPanel.SuspendLayout();
            tableLayout.SuspendLayout();
            filterLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResponses).BeginInit();
            treeButtonLayout.SuspendLayout();
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
            tableLayout.Controls.Add(lblVerificationResponses, 0, 1);
            tableLayout.Controls.Add(dataGridViewResponses, 0, 2);
            tableLayout.Controls.Add(lblVerificationStatus, 0, 3);
            tableLayout.Controls.Add(VerificationStatusTree, 0, 4);
            tableLayout.Controls.Add(treeButtonLayout, 0, 5);
            tableLayout.Controls.Add(filterLayout, 0, 0);
            tableLayout.Location = new Point(3, 12);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 6;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayout.Size = new Size(1193, 756);
            tableLayout.TabIndex = 0;
            // 
            // filterLayout
            // 
            filterLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filterLayout.ColumnCount = 11;
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            filterLayout.Controls.Add(lblStartDate, 0, 0);
            filterLayout.Controls.Add(datePickerStart, 1, 0);
            filterLayout.Controls.Add(lblEndDate, 2, 0);
            filterLayout.Controls.Add(datePickerEnd, 3, 0);
            filterLayout.Controls.Add(lblStatus, 4, 0);
            filterLayout.Controls.Add(comboBoxStatus, 5, 0);
            filterLayout.Controls.Add(lblSourceSystem, 6, 0);
            filterLayout.Controls.Add(txtSourceSystem, 7, 0);
            filterLayout.Controls.Add(lblChannel, 8, 0);
            filterLayout.Controls.Add(txtChannel, 9, 0);
            filterLayout.Controls.Add(btnApplyFilters, 10, 0);
            filterLayout.Location = new Point(3, 3);
            filterLayout.Name = "filterLayout";
            filterLayout.RowCount = 1;
            filterLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            filterLayout.Size = new Size(1187, 69);
            filterLayout.TabIndex = 5;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 12F);
            lblStartDate.Location = new Point(3, 6);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(101, 56);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "Start Date:";
            // 
            // datePickerStart
            // 
            datePickerStart.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            datePickerStart.Font = new Font("Segoe UI", 12F);
            datePickerStart.Location = new Point(110, 17);
            datePickerStart.Name = "datePickerStart";
            datePickerStart.Size = new Size(155, 34);
            datePickerStart.TabIndex = 1;
            // 
            // lblEndDate
            // 
            lblEndDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 12F);
            lblEndDate.Location = new Point(271, 6);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(47, 56);
            lblEndDate.TabIndex = 2;
            lblEndDate.Text = "End:";
            // 
            // datePickerEnd
            // 
            datePickerEnd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            datePickerEnd.Font = new Font("Segoe UI", 12F);
            datePickerEnd.Location = new Point(324, 17);
            datePickerEnd.Name = "datePickerEnd";
            datePickerEnd.Size = new Size(155, 34);
            datePickerEnd.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(485, 6);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 56);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxStatus.Font = new Font("Segoe UI", 12F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(538, 16);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(101, 36);
            comboBoxStatus.TabIndex = 5;
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new Font("Segoe UI", 12F);
            lblSourceSystem.Location = new Point(645, 20);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new Size(155, 28);
            lblSourceSystem.TabIndex = 6;
            lblSourceSystem.Text = "Source System:";
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSourceSystem.Font = new Font("Segoe UI", 12F);
            txtSourceSystem.Location = new Point(806, 17);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new Size(47, 34);
            txtSourceSystem.TabIndex = 7;
            // 
            // lblChannel
            // 
            lblChannel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblChannel.AutoSize = true;
            lblChannel.Font = new Font("Segoe UI", 12F);
            lblChannel.Location = new Point(859, 20);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(101, 28);
            lblChannel.TabIndex = 8;
            lblChannel.Text = "Channel:";
            // 
            // txtChannel
            // 
            txtChannel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtChannel.Font = new Font("Segoe UI", 12F);
            txtChannel.Location = new Point(966, 17);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(101, 34);
            txtChannel.TabIndex = 9;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnApplyFilters.BackColor = Color.ForestGreen;
            btnApplyFilters.FlatStyle = FlatStyle.Flat;
            btnApplyFilters.Font = new Font("Segoe UI", 12F);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(1073, 3);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(111, 63);
            btnApplyFilters.TabIndex = 10;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            // 
            // lblVerificationResponses
            // 
            lblVerificationResponses.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblVerificationResponses.AutoSize = true;
            lblVerificationResponses.Font = new Font("Segoe UI", 12F);
            lblVerificationResponses.Location = new Point(3, 77);
            lblVerificationResponses.Name = "lblVerificationResponses";
            lblVerificationResponses.Size = new Size(208, 28);
            lblVerificationResponses.TabIndex = 0;
            lblVerificationResponses.Text = "Check Status Requests:";
            // 
            // dataGridViewResponses
            // 
            dataGridViewResponses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewResponses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResponses.Font = new Font("Segoe UI", 12F);
            dataGridViewResponses.Location = new Point(3, 108);
            dataGridViewResponses.Name = "dataGridViewResponses";
            dataGridViewResponses.RowHeadersWidth = 51;
            dataGridViewResponses.Size = new Size(1187, 281);
            dataGridViewResponses.TabIndex = 1;
            // 
            // lblVerificationStatus
            // 
            lblVerificationStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblVerificationStatus.AutoSize = true;
            lblVerificationStatus.Font = new Font("Segoe UI", 12F);
            lblVerificationStatus.Location = new Point(3, 394);
            lblVerificationStatus.Name = "lblVerificationStatus";
            lblVerificationStatus.Size = new Size(172, 28);
            lblVerificationStatus.TabIndex = 2;
            lblVerificationStatus.Text = "Verification Status:";
            // 
            // VerificationStatusTree
            // 
            VerificationStatusTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VerificationStatusTree.Font = new Font("Segoe UI", 12F);
            VerificationStatusTree.Location = new Point(3, 425);
            VerificationStatusTree.Name = "VerificationStatusTree";
            VerificationStatusTree.Size = new Size(1187, 281);
            VerificationStatusTree.TabIndex = 3;
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
            treeButtonLayout.Location = new Point(3, 712);
            treeButtonLayout.Name = "treeButtonLayout";
            treeButtonLayout.RowCount = 1;
            treeButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            treeButtonLayout.Size = new Size(1187, 41);
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
            btnRefresh.Size = new Size(290, 35);
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
            btnExpandAll.Size = new Size(290, 35);
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
            btnCollapseAll.Size = new Size(293, 35);
            btnCollapseAll.TabIndex = 1;
            btnCollapseAll.Text = "Collapse All";
            btnCollapseAll.UseVisualStyleBackColor = false;
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
            filterLayout.ResumeLayout(false);
            filterLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResponses).EndInit();
            treeButtonLayout.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
        }
    }
}