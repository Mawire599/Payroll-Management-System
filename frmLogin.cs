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
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Missing Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
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
                if (chkRememberMe.Checked)
                {
                    Properties.Settings.Default.Username = txtUsername.Text;
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
                MessageBox.Show("Invalid username or password", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    

