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
            mainPanel = new System.Windows.Forms.Panel();
            tableLayout = new System.Windows.Forms.TableLayoutPanel();
            filterLayout = new System.Windows.Forms.TableLayoutPanel();
            lblStartDate = new System.Windows.Forms.Label();
            datePickerStart = new System.Windows.Forms.DateTimePicker();
            lblEndDate = new System.Windows.Forms.Label();
            datePickerEnd = new System.Windows.Forms.DateTimePicker();
            lblStatus = new System.Windows.Forms.Label();
            comboBoxStatus = new System.Windows.Forms.ComboBox();
            lblSourceSystem = new System.Windows.Forms.Label();
            txtSourceSystem = new System.Windows.Forms.TextBox();
            lblChannel = new System.Windows.Forms.Label();
            txtChannel = new System.Windows.Forms.TextBox();
            btnApplyFilters = new System.Windows.Forms.Button();
            treeButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            btnRefresh = new System.Windows.Forms.Button();
            btnExpandAll = new System.Windows.Forms.Button();
            btnCollapseAll = new System.Windows.Forms.Button();
            VerificationStatusTree = new System.Windows.Forms.TreeView();
            lblVerificationStatus = new System.Windows.Forms.Label();
            dataGridViewResponses = new System.Windows.Forms.DataGridView();
            lblVerificationResponses = new System.Windows.Forms.Label();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            mainPanel.SuspendLayout();
            tableLayout.SuspendLayout();
            filterLayout.SuspendLayout();
            treeButtonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResponses).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(tableLayout);
            mainPanel.Controls.Add(statusStrip);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(1200, 800);
            mainPanel.TabIndex = 0;
            // 
            // tableLayout
            // 
            tableLayout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayout.ColumnCount = 1;
            tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayout.Controls.Add(filterLayout, 0, 0);
            tableLayout.Controls.Add(lblVerificationResponses, 0, 1);
            tableLayout.Controls.Add(dataGridViewResponses, 0, 2);
            tableLayout.Controls.Add(lblVerificationStatus, 0, 3);
            tableLayout.Controls.Add(VerificationStatusTree, 0, 4);
            tableLayout.Controls.Add(treeButtonLayout, 0, 5);
            tableLayout.Location = new System.Drawing.Point(3, 12);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 6;
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            tableLayout.Size = new System.Drawing.Size(1193, 756);
            tableLayout.TabIndex = 0;
            // 
            // filterLayout
            // 
            filterLayout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            filterLayout.ColumnCount = 11;
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
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
            filterLayout.Location = new System.Drawing.Point(3, 3);
            filterLayout.Name = "filterLayout";
            filterLayout.RowCount = 1;
            filterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            filterLayout.Size = new System.Drawing.Size(1187, 72);
            filterLayout.TabIndex = 5;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblStartDate.Location = new System.Drawing.Point(3, 22);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new System.Drawing.Size(115, 28);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "Start Date:";
            // 
            // datePickerStart
            // 
            datePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            datePickerStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            datePickerStart.Location = new System.Drawing.Point(121, 18);
            datePickerStart.Name = "datePickerStart";
            datePickerStart.Size = new System.Drawing.Size(175, 34);
            datePickerStart.TabIndex = 1;
            // 
            // lblEndDate
            // 
            lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblEndDate.Location = new System.Drawing.Point(299, 22);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new System.Drawing.Size(56, 28);
            lblEndDate.TabIndex = 2;
            lblEndDate.Text = "End:";
            // 
            // datePickerEnd
            // 
            datePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            datePickerEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            datePickerEnd.Location = new System.Drawing.Point(361, 18);
            datePickerEnd.Name = "datePickerEnd";
            datePickerEnd.Size = new System.Drawing.Size(175, 34);
            datePickerEnd.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblStatus.Location = new System.Drawing.Point(539, 22);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(56, 28);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new System.Drawing.Point(601, 18);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new System.Drawing.Size(115, 36);
            comboBoxStatus.TabIndex = 5;
            // 
            // lblSourceSystem
            // 
            lblSourceSystem.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSourceSystem.AutoSize = true;
            lblSourceSystem.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSourceSystem.Location = new System.Drawing.Point(719, 22);
            lblSourceSystem.Name = "lblSourceSystem";
            lblSourceSystem.Size = new System.Drawing.Size(175, 28);
            lblSourceSystem.TabIndex = 6;
            lblSourceSystem.Text = "Source System:";
            // 
            // txtSourceSystem
            // 
            txtSourceSystem.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSourceSystem.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSourceSystem.Location = new System.Drawing.Point(897, 18);
            txtSourceSystem.Name = "txtSourceSystem";
            txtSourceSystem.Size = new System.Drawing.Size(115, 34);
            txtSourceSystem.TabIndex = 7;
            // 
            // lblChannel
            // 
            lblChannel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblChannel.AutoSize = true;
            lblChannel.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblChannel.Location = new System.Drawing.Point(1015, 22);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new System.Drawing.Size(115, 28);
            lblChannel.TabIndex = 8;
            lblChannel.Text = "Channel:";
            // 
            // txtChannel
            // 
            txtChannel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtChannel.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtChannel.Location = new System.Drawing.Point(1133, 18);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new System.Drawing.Size(115, 34);
            txtChannel.TabIndex = 9;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnApplyFilters.BackColor = System.Drawing.Color.ForestGreen;
            btnApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApplyFilters.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnApplyFilters.ForeColor = System.Drawing.Color.White;
            btnApplyFilters.Location = new System.Drawing.Point(1251, 3);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new System.Drawing.Size(115, 66);
            btnApplyFilters.TabIndex = 10;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            // 
            // treeButtonLayout
            // 
            treeButtonLayout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            treeButtonLayout.ColumnCount = 4;
            treeButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            treeButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            treeButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            treeButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            treeButtonLayout.Controls.Add(btnRefresh, 0, 0);
            treeButtonLayout.Controls.Add(btnExpandAll, 2, 0);
            treeButtonLayout.Controls.Add(btnCollapseAll, 3, 0);
            treeButtonLayout.Location = new System.Drawing.Point(3, 701);
            treeButtonLayout.Name = "treeButtonLayout";
            treeButtonLayout.RowCount = 1;
            treeButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            treeButtonLayout.Size = new System.Drawing.Size(1187, 52);
            treeButtonLayout.TabIndex = 4;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnRefresh.BackColor = System.Drawing.Color.ForestGreen;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(3, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(290, 46);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnExpandAll
            // 
            btnExpandAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnExpandAll.BackColor = System.Drawing.Color.RoyalBlue;
            btnExpandAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExpandAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnExpandAll.ForeColor = System.Drawing.Color.White;
            btnExpandAll.Location = new System.Drawing.Point(595, 3);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new System.Drawing.Size(290, 46);
            btnExpandAll.TabIndex = 0;
            btnExpandAll.Text = "Expand All";
            btnExpandAll.UseVisualStyleBackColor = false;
            // 
            // btnCollapseAll
            // 
            btnCollapseAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnCollapseAll.BackColor = System.Drawing.Color.RoyalBlue;
            btnCollapseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCollapseAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnCollapseAll.ForeColor = System.Drawing.Color.White;
            btnCollapseAll.Location = new System.Drawing.Point(891, 3);
            btnCollapseAll.Name = "btnCollapseAll";
            btnCollapseAll.Size = new System.Drawing.Size(293, 46);
            btnCollapseAll.TabIndex = 1;
            btnCollapseAll.Text = "Collapse All";
            btnCollapseAll.UseVisualStyleBackColor = false;
            // 
            // VerificationStatusTree
            // 
            VerificationStatusTree.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            VerificationStatusTree.Font = new System.Drawing.Font("Segoe UI", 12F);
            VerificationStatusTree.Location = new System.Drawing.Point(3, 416);
            VerificationStatusTree.Name = "VerificationStatusTree";
            VerificationStatusTree.Size = new System.Drawing.Size(1187, 279);
            VerificationStatusTree.TabIndex = 3;
            // 
            // lblVerificationStatus
            // 
            lblVerificationStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblVerificationStatus.AutoSize = true;
            lblVerificationStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblVerificationStatus.Location = new System.Drawing.Point(3, 385);
            lblVerificationStatus.Name = "lblVerificationStatus";
            lblVerificationStatus.Size = new System.Drawing.Size(172, 28);
            lblVerificationStatus.TabIndex = 2;
            lblVerificationStatus.Text = "Verification Status:";
            // 
            // dataGridViewResponses
            // 
            dataGridViewResponses.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewResponses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResponses.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewResponses.Location = new System.Drawing.Point(3, 105);
            dataGridViewResponses.Name = "dataGridViewResponses";
            dataGridViewResponses.RowHeadersWidth = 51;
            dataGridViewResponses.Size = new System.Drawing.Size(1187, 274);
            dataGridViewResponses.TabIndex = 1;
            // 
            // lblVerificationResponses
            // 
            lblVerificationResponses.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblVerificationResponses.AutoSize = true;
            lblVerificationResponses.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblVerificationResponses.Location = new System.Drawing.Point(3, 74);
            lblVerificationResponses.Name = "lblVerificationResponses";
            lblVerificationResponses.Size = new System.Drawing.Size(208, 28);
            lblVerificationResponses.TabIndex = 0;
            lblVerificationResponses.Text = "Check Status Requests:";
            // 
            // statusStrip
            // 
            statusStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel });
            statusStrip.Location = new System.Drawing.Point(0, 778);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(1200, 22);
            statusStrip.TabIndex = 1;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // ResponsesHistoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            ClientSize = new System.Drawing.Size(1200, 800);
            Controls.Add(mainPanel);
            Name = "ResponsesHistoryForm";
            Text = "Responses History";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            filterLayout.ResumeLayout(false);
            filterLayout.PerformLayout();
            treeButtonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResponses).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
        }
    }
}