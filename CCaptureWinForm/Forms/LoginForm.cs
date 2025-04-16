using CCaptureWinForm.Presentation.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CCaptureWinForm
{
    public partial class LoginForm : Form
    {
        private readonly MainViewModel _viewModel;
        private readonly ErrorProvider _errorProvider;
        private TextBox txtAppName;
        private TextBox txtAppLogin;
        private TextBox txtAppPassword;
        private CheckBox chkShowPassword;
        private Button btnGetToken;
        private Button btnCancel;
        private Label statusLabel;

        public LoginForm(MainViewModel viewModel)
        {
            _viewModel = viewModel;
            _errorProvider = new ErrorProvider(this) { BlinkStyle = ErrorBlinkStyle.NeverBlink };
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Text = "Login";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(400, 300);
            BackColor = Color.FromArgb(245, 245, 245);

            var panel = new Panel
            {
                Location = new Point(20, 20),
                Size = new Size(360, 260)
            };
            Controls.Add(panel);

            var lblAppName = new Label
            {
                Text = "Application Name:",
                Location = new Point(10, 20),
                Size = new Size(100, 20)
            };
            panel.Controls.Add(lblAppName);

            txtAppName = new TextBox
            {
                Location = new Point(120, 20),
                Size = new Size(200, 20)
            };
            panel.Controls.Add(txtAppName);

            var lblAppLogin = new Label
            {
                Text = "Application Login:",
                Location = new Point(10, 50),
                Size = new Size(100, 20)
            };
            panel.Controls.Add(lblAppLogin);

            txtAppLogin = new TextBox
            {
                Location = new Point(120, 50),
                Size = new Size(200, 20)
            };
            panel.Controls.Add(txtAppLogin);

            var lblAppPassword = new Label
            {
                Text = "Password:",
                Location = new Point(10, 80),
                Size = new Size(100, 20)
            };
            panel.Controls.Add(lblAppPassword);

            txtAppPassword = new TextBox
            {
                Location = new Point(120, 80),
                Size = new Size(200, 20),
                UseSystemPasswordChar = true
            };
            panel.Controls.Add(txtAppPassword);

            chkShowPassword = new CheckBox
            {
                Text = "Show Password",
                Location = new Point(120, 110),
                Size = new Size(100, 20)
            };
            chkShowPassword.CheckedChanged += (s, e) => txtAppPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            panel.Controls.Add(chkShowPassword);

            statusLabel = new Label
            {
                Location = new Point(10, 140),
                Size = new Size(300, 40),
                ForeColor = SystemColors.ControlText
            };
            panel.Controls.Add(statusLabel);

            btnGetToken = new Button
            {
                Text = "Login",
                Location = new Point(120, 190),
                Size = new Size(80, 30)
            };
            btnGetToken.Click += btnGetToken_Click;
            panel.Controls.Add(btnGetToken);

            btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(210, 190),
                Size = new Size(80, 30)
            };
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
            panel.Controls.Add(btnCancel);
        }

        private async void btnGetToken_Click(object sender, EventArgs e)
        {
            try
            {
                _errorProvider.Clear();
                statusLabel.Text = string.Empty;

                if (string.IsNullOrWhiteSpace(txtAppName.Text))
                    _errorProvider.SetError(txtAppName, "Please enter the application name.");
                if (string.IsNullOrWhiteSpace(txtAppLogin.Text))
                    _errorProvider.SetError(txtAppLogin, "Please enter the application login.");
                if (string.IsNullOrWhiteSpace(txtAppPassword.Text))
                    _errorProvider.SetError(txtAppPassword, "Please enter the application password.");

                if (_errorProvider.GetError(txtAppName) != "" ||
                    _errorProvider.GetError(txtAppLogin) != "" ||
                    _errorProvider.GetError(txtAppPassword) != "")
                {
                    statusLabel.Text = "Please fill in all required fields.";
                    statusLabel.ForeColor = Color.Red;
                    return;
                }

                btnGetToken.Enabled = false;
                statusLabel.Text = "Logging in...";
                statusLabel.ForeColor = Color.Blue;

                var token = await _viewModel.GetAuthTokenAsync(
                    txtAppName.Text,
                    txtAppLogin.Text,
                    txtAppPassword.Text);

                statusLabel.Text = "You're logged in!";
                statusLabel.ForeColor = Color.Green;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message.ToLower().Contains("unauthorized") || ex.Message.Contains("401")
                    ? "Login failed. Please check your credentials and try again."
                    : "Something went wrong. Please try again.";
                statusLabel.ForeColor = Color.Red;
            }
            finally
            {
                btnGetToken.Enabled = true;
            }
        }
    }
}