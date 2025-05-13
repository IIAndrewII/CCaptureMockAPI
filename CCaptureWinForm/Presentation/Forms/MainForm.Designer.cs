namespace CCaptureWinForm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVerificationResponsesToolStripMenuItem;
        private System.Windows.Forms.ListView verificationResponseListView;

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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            submitDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewVerificationResponsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            verificationResponseListView = new System.Windows.Forms.ListView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1214, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                submitDocumentToolStripMenuItem,
                checkStatusToolStripMenuItem,
                viewVerificationResponsesToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // submitDocumentToolStripMenuItem
            // 
            submitDocumentToolStripMenuItem.Name = "submitDocumentToolStripMenuItem";
            submitDocumentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            submitDocumentToolStripMenuItem.Text = "Submit Document";
            // 
            // checkStatusToolStripMenuItem
            // 
            checkStatusToolStripMenuItem.Name = "checkStatusToolStripMenuItem";
            checkStatusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            checkStatusToolStripMenuItem.Text = "Check Status";
            // 
            // viewVerificationResponsesToolStripMenuItem
            // 
            viewVerificationResponsesToolStripMenuItem.Name = "viewVerificationResponsesToolStripMenuItem";
            viewVerificationResponsesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewVerificationResponsesToolStripMenuItem.Text = "View Verification Responses";
            // 
            // verificationResponseListView
            // 
            verificationResponseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                new System.Windows.Forms.ColumnHeader() { Text = "Batch Name", Width = 200 },
                new System.Windows.Forms.ColumnHeader() { Text = "Status", Width = 100 },
                new System.Windows.Forms.ColumnHeader() { Text = "Execution Date", Width = 150 },
                new System.Windows.Forms.ColumnHeader() { Text = "Error Message", Width = 300 }
            });
            verificationResponseListView.FullRowSelect = true;
            verificationResponseListView.GridLines = true;
            verificationResponseListView.Location = new System.Drawing.Point(0, 28);
            verificationResponseListView.Name = "verificationResponseListView";
            verificationResponseListView.Size = new System.Drawing.Size(1214, 591);
            verificationResponseListView.TabIndex = 1;
            verificationResponseListView.UseCompatibleStateImageBehavior = false;
            verificationResponseListView.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            ClientSize = new System.Drawing.Size(1214, 619);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimumSize = new System.Drawing.Size(702, 383);
            Name = "MainForm";
            Text = "CCapture Mock API Client";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}