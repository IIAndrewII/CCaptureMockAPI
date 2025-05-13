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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            submitDocumentToolStripMenuItem = new ToolStripMenuItem();
            checkStatusToolStripMenuItem = new ToolStripMenuItem();
            viewVerificationResponsesToolStripMenuItem = new ToolStripMenuItem();
            verificationResponseListView = new ListView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1387, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { submitDocumentToolStripMenuItem, checkStatusToolStripMenuItem, viewVerificationResponsesToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // submitDocumentToolStripMenuItem
            // 
            submitDocumentToolStripMenuItem.Name = "submitDocumentToolStripMenuItem";
            submitDocumentToolStripMenuItem.Size = new Size(224, 26);
            submitDocumentToolStripMenuItem.Text = "Submit Document";
            // 
            // checkStatusToolStripMenuItem
            // 
            checkStatusToolStripMenuItem.Name = "checkStatusToolStripMenuItem";
            checkStatusToolStripMenuItem.Size = new Size(224, 26);
            checkStatusToolStripMenuItem.Text = "Check Status";
            // 
            // viewVerificationResponsesToolStripMenuItem
            // 
            viewVerificationResponsesToolStripMenuItem.Name = "viewVerificationResponsesToolStripMenuItem";
            viewVerificationResponsesToolStripMenuItem.Size = new Size(224, 26);
            viewVerificationResponsesToolStripMenuItem.Text = "Responses History";
            // 
            // verificationResponseListView
            // 
            verificationResponseListView.FullRowSelect = true;
            verificationResponseListView.GridLines = true;
            verificationResponseListView.Location = new Point(0, 28);
            verificationResponseListView.Name = "verificationResponseListView";
            verificationResponseListView.Size = new Size(1214, 591);
            verificationResponseListView.TabIndex = 1;
            verificationResponseListView.UseCompatibleStateImageBehavior = false;
            verificationResponseListView.View = View.Details;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1387, 825);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 495);
            Name = "MainForm";
            Text = "CCapture Mock API Client";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}