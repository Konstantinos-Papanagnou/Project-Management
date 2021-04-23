using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyInformationSystem.BusinessLogic;
using PharmacyInformationSystem.UIComponents.Login;

namespace PharmacyInformationSystem.UIComponents
{
    public partial class MainScreen : Form
    {
        readonly User User;
        readonly IShowable Login;
        bool logout = false;
        /// <summary>
        /// Initializes the view based on the user's access rights
        /// </summary>
        /// <param name="login">Get the IShowable interface to switch with during logouts</param>
        /// <param name="user">Get the user accessing the application and grant him his rights</param>
        public MainScreen(IShowable login, User user)
        {
            Login = login;
            InitializeComponent();
            User = user;
            SideMenu.ViewUserInfoBtn.Click += ViewUserInfoBtn_Click;
            SideMenu.Logout.Click += Logout_Click;

            if (User is Administrator administrator)
            {
                SideMenu.SetAdminView();
                OperationsPanel.Controls.Add(new MainUserControls.UsersList(administrator));
            }
            else if (User is MarketingTeam)
                SideMenu.SetMarketingView();
            else if (User is StoreKeeper keeper)
            {
                var View = new MainUserControls.StorageViewList.StorageListView(keeper);
                SideMenu.SetStoreKeeperView(View);
                OperationsPanel.Controls.Add(View);
            }
            else SideMenu.SetSellerView();
        }
        /// <summary>
        /// Listens for the logout button from the sidebar view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logout_Click(object sender, EventArgs e)
        {
            Login.GetScreenBack();
            logout = true;
            this.Close();
        }
        /// <summary>
        /// Listens for the ViewUserInfo button from the sidebar view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewUserInfoBtn_Click(object sender, EventArgs e)
        {
            MainUserControls.ViewUserData info = new MainUserControls.ViewUserData(User);
            info.ShowDialog();

        }
        /// <summary>
        /// Stop the FormClosing event and handle it differently
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!logout)
                Application.Exit();
        }

    }
}
