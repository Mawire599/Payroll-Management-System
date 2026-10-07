using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagementSystem
{
    public partial class frmLogin : Form
    {

        private bool passwordVisible = false;

        private int failedLoginAttempts = 0;
        private const int MaxLoginAttempts = 5;
        private bool loginLocked = false;

        public frmLogin()
        {
            InitializeComponent();

            RoundButton(btnLogin);
            RoundButton(btnExit);
        }

        private void RoundButton(Button btn)
        {
            GraphicsPath path = new GraphicsPath();

            int radius = 20;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.RememberMe)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                chkRememberMe.Checked = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginLocked)
            {
                MessageBox.Show(
                    "Login is temporarily locked because of too many failed attempts.",
                    "Login Locked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Missing Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Missing Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            if (user == "Admin" && pass == "HR123")
            {
                // Reset failed attempts after successful login
                failedLoginAttempts = 0;

                if (chkRememberMe.Checked)
                {
                    Properties.Settings.Default.Username = user;
                    Properties.Settings.Default.RememberMe = true;
                }
                else
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.RememberMe = false;
                }

                Properties.Settings.Default.Save();

                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();

                this.Hide();
            }
            else
            {
                failedLoginAttempts++;

                int attemptsRemaining = MaxLoginAttempts - failedLoginAttempts;

                txtPassword.Clear();
                txtPassword.Focus();

                if (failedLoginAttempts >= MaxLoginAttempts)
                {
                    loginLocked = true;

                    btnLogin.Enabled = false;
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    chkRememberMe.Enabled = false;

                    MessageBox.Show(
                        "Too many failed login attempts.\n\n" +
                        "The login screen has been temporarily locked.\n" +
                        "Please restart the application before trying again.",
                        "Login Locked",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(
                        "Invalid username or password.\n\n" +
                        "Attempts remaining: " + attemptsRemaining,
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {

            passwordVisible = !passwordVisible;

            txtPassword.UseSystemPasswordChar = !passwordVisible;

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Please contact the System Administrator to reset your password.",
               "Forgot Password",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {

            btnLogin.BackColor = Color.DarkGreen;
            btnLogin.ForeColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {

            btnLogin.BackColor = Color.Green;
            btnLogin.ForeColor = Color.White;

        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {

            btnExit.BackColor = Color.DarkGreen;
            btnExit.ForeColor = Color.White;
            btnExit.Cursor = Cursors.Hand;

        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {

            btnExit.BackColor = Color.Green;
            btnExit.ForeColor = Color.White;

        }
    }
}
    

