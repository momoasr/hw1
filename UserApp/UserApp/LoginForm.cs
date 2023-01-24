using System;
using System.Windows.Forms;

namespace UserApp
{
    public partial class LoginForm : Form
    {
        private UserAppForm appForm;
        public LoginForm(Form appForm)
        {
            InitializeComponent();
            this.appForm = appForm as UserAppForm;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbUsername.Text = string.Empty;
            tbPassword.Text= string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var helper = new LoginHelper();

            if (helper.ValidateCredentials(tbUsername.Text, tbPassword.Text))
            {
                helper.LogAttemptToFile(tbUsername.Text, true);
                appForm.BtnLoginText = "Logout";                
                appForm.CloseLoginForm(this);
            }
            else
            {
                helper.LogAttemptToFile(tbUsername.Text, false);
                lblError.Visible = true;
                lblError.Text = "Username and/or password failed.";
            }
        }
    }
}
