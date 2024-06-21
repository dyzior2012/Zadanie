using System;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class LoginForm : Form
    {
        public bool IsAuthenticated { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "123")
            {
                IsAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Błędna nazwa użytkownika lub hasło.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsAuthenticated = false;
            this.Close();
        }
    }
}
