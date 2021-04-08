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
        /// <summary>
        /// Listens for Clicks on the Login Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Listens for Enter Presses on either TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                LoginButton_Click(sender, e);
        }
        /// <summary>
        /// Implementation of the Derived interface to get the login screen back.
        /// </summary>
        public void GetScreenBack()
        {
            this.ShowInTaskbar = true;
            this.Show();
            UsernameBox.Text = "";
            PasswordBox.Text = "";
            Handler.AttemptCount = 0;
            UsernamePanelError.Visible = false;
            PasswordPanelError.Visible = false;
        }

    }
}
