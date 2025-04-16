namespace CCaptureWinForm
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.TextBox txtAppLogin;
        private System.Windows.Forms.TextBox txtAppPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;

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
            this.components = new System.ComponentModel.Container();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.txtAppLogin = new System.Windows.Forms.TextBox();
            this.txtAppPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            var panel = new System.Windows.Forms.Panel();
            var lblAppName = new System.Windows.Forms.Label();
            var lblAppLogin = new System.Windows.Forms.Label();
            var lblAppPassword = new System.Windows.Forms.Label();

            // ErrorProvider
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;

            // Form settings
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";

            // Panel
            panel.Location = new System.Drawing.Point(20, 20);
            panel.Size = new System.Drawing.Size(360, 260);
            panel.Controls.Add(this.txtAppName);
            panel.Controls.Add(this.txtAppLogin);
            panel.Controls.Add(this.txtAppPassword);
            panel.Controls.Add(this.chkShowPassword);
            panel.Controls.Add(this.btnGetToken);
            panel.Controls.Add(this.btnCancel);
            panel.Controls.Add(this.statusLabel);
            panel.Controls.Add(lblAppName);
            panel.Controls.Add(lblAppLogin);
            panel.Controls.Add(lblAppPassword);

            // Labels
            lblAppName.Text = "Application Name:";
            lblAppName.Location = new System.Drawing.Point(10, 20);
            lblAppName.Size = new System.Drawing.Size(100, 20);

            lblAppLogin.Text = "Application Login:";
            lblAppLogin.Location = new System.Drawing.Point(10, 50);
            lblAppLogin.Size = new System.Drawing.Size(100, 20);

            lblAppPassword.Text = "Password:";
            lblAppPassword.Location = new System.Drawing.Point(10, 80);
            lblAppPassword.Size = new System.Drawing.Size(100, 20);

            // TextBoxes
            this.txtAppName.Location = new System.Drawing.Point(120, 20);
            this.txtAppName.Size = new System.Drawing.Size(200, 20);

            this.txtAppLogin.Location = new System.Drawing.Point(120, 50);
            this.txtAppLogin.Size = new System.Drawing.Size(200, 20);

            this.txtAppPassword.Location = new System.Drawing.Point(120, 80);
            this.txtAppPassword.Size = new System.Drawing.Size(200, 20);
            this.txtAppPassword.UseSystemPasswordChar = true;

            // CheckBox
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.Location = new System.Drawing.Point(120, 110);
            this.chkShowPassword.Size = new System.Drawing.Size(100, 20);
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            // Status Label
            this.statusLabel.Location = new System.Drawing.Point(10, 140);
            this.statusLabel.Size = new System.Drawing.Size(300, 40);
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ControlText;

            // Buttons
            this.btnGetToken.Text = "Login";
            this.btnGetToken.Location = new System.Drawing.Point(120, 190);
            this.btnGetToken.Size = new System.Drawing.Size(80, 30);
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(210, 190);
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add panel to form
            this.Controls.Add(panel);

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
        }
    }
}