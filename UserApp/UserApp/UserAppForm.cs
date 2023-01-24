using System;
using System.Windows.Forms;

namespace UserApp
{
    public partial class UserAppForm : Form
    {
        public bool IsUserLoggedIn { get; set; } = false;
        public string BtnLoginText
        {
            set { btnLogin.Text = value; }
        }

        public UserAppForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsUserLoggedIn)
            {
                IsUserLoggedIn = false;
                btnLogin.Text = "Login";
                lblWelcomeMsg.Visible= false;
            }
            else
            {
                LoginForm loginForm = new LoginForm(this);
                loginForm.Show();
            }
        }

        public void CloseLoginForm(LoginForm loginForm)
        {
            IsUserLoggedIn = true;
            lblWelcomeMsg.Visible = true;
            loginForm.Close();
        }
    }
}
