using PharmacyInformationSystem.UIComponents.MainUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyInformationSystem.UIComponents
{
    public partial class SideMenu : UserControl
    {
        public Button ViewUserInfoBtn { get { return UserBtn; } }
        public SideBarItem Bar { get; private set; }
        public Button Logout { get { return logOut; } }

        public SideMenu()
        {
            InitializeComponent();
            
        }

        public void SetAdminView()
        {
            Bar = new MainUserControls.SideBarItem("Διαχείριση Χρηστών", "Λίστα Χρηστών", "", "", "", Properties.Resources.icons8_group_24);
            panelSubMenu.Controls.Add(Bar);
        }

        public void SetMarketingView()
        {
            Bar = new MainUserControls.SideBarItem("Marketing", "Λειτουργία 1", "Λειτουργία 2", "Λειτουργία 3", "Λειτουργία 4", Properties.Resources.icons8_marketing_24);
            panelSubMenu.Controls.Add(Bar);
        }

        public void SetStoreKeeperView()
        {
            Bar = new MainUserControls.SideBarItem("Αποθήκη", "Λειτουργία 1", "Λειτουργία 2", "Λειτουργία 3", "Λειτουργία 4", Properties.Resources.icons8_warehouse_24);
            panelSubMenu.Controls.Add(Bar);
        }

        public void SetSellerView()
        {
            Bar = new MainUserControls.SideBarItem("Πωλητής", "Λειτουργία 1", "Λειτουργία 2", "Λειτουργία 3", "Λειτουργία 4", Properties.Resources.icons8_gear_24);
            panelSubMenu.Controls.Add(Bar);
        }

    }
}
