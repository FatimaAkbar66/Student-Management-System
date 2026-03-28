using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (user == "" || pass == "")
            {
                lblError.Text = "⚠️ Please enter username and password!";
                return;
            }

            if (user == "admin" && pass == "1234")
            {
                MessageBox.Show("✅ Login Successful! Dashboard coming soon.");
            }
            else
            {
                lblError.Text = "❌ Wrong username or password!";
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}