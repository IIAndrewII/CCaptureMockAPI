namespace CCaptureWinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAppName = new TextBox();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnGetToken = new Button();
            SuspendLayout();
            // 
            // txtAppName
            // 
            txtAppName.Location = new Point(168, 9);
            txtAppName.Margin = new Padding(3, 2, 3, 2);
            txtAppName.Name = "txtAppName";
            txtAppName.Size = new Size(271, 33);
            txtAppName.TabIndex = 0;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(168, 57);
            txtLogin.Margin = new Padding(3, 2, 3, 2);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(271, 33);
            txtLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(168, 113);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(271, 33);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnGetToken
            // 
            btnGetToken.Location = new Point(291, 184);
            btnGetToken.Margin = new Padding(3, 2, 3, 2);
            btnGetToken.Name = "btnGetToken";
            btnGetToken.Size = new Size(90, 34);
            btnGetToken.TabIndex = 3;
            btnGetToken.Text = "Log in";
            btnGetToken.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 244);
            Controls.Add(btnGetToken);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtAppName);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "MainForm";
            Text = "CCapture";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAppName;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnGetToken;
    }
}
