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

namespace PharmacyInformationSystem.UIComponents
{
    public partial class MainScreen : Form
    {
        readonly User User;
        public MainScreen(User user)
        {
            InitializeComponent();
            User = user;
            SideMenu.ViewUserInfoBtn.Click += ViewUserInfoBtn_Click;
            if (User is Administrator)
            {
                SideMenu.SetAdminView();
                OperationsPanel.Controls.Add(new MainUserControls.UsersList((Administrator)User));
            }
            else if (User is MarketingTeam)
                SideMenu.SetMarketingView();
            else if (User is StoreKeeper)
                SideMenu.SetStoreKeeperView();
            else SideMenu.SetSellerView();
        }

        private void ViewUserInfoBtn_Click(object sender, EventArgs e)
        {
            MainUserControls.ViewUserData info = new MainUserControls.ViewUserData(User);
            info.ShowDialog();

        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
