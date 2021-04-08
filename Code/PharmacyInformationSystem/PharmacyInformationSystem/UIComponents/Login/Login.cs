using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyInformationSystem.BusinessLogic.LoginFunctionality;
using PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.UIComponents.Login
{
    public partial class Login : Form, IShowable
    {
        readonly AuthenticationHandler Handler;
        public Login()
        {
            InitializeComponent();
            Handler = new AuthenticationHandler();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = Handler.AuthenticateUser(UsernameBox.Text, PasswordBox.Text);
                this.ShowInTaskbar = false;
                this.Hide();
                new MainScreen(this,user).ShowDialog();
            }
            catch (AuthenticationFailure ex) {
                UsernamePanelError.BackColor = Color.Red;
                PasswordPanelError.BackColor = Color.Red;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void OnEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                LoginButton_Click(sender, e);
        }

        public void GetScreenBack()
        {
            this.ShowInTaskbar = true;
            this.Show();
            UsernameBox.Text = "";
            PasswordBox.Text = "";
        }

    }
}
