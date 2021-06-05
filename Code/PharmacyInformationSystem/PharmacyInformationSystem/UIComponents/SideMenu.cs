using PharmacyInformationSystem.UIComponents.MainUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.UIComponents
{
    public partial class SideMenu : UserControl
    {
        /// <summary>
        /// Get the View User Info to grab events
        /// </summary>
        public Button ViewUserInfoBtn { get { return UserBtn; } }
        /// <summary>
        /// Use the SideBarItem object to grab its events or childrens
        /// </summary>
        public SideBarItem Bar { get; private set; }
        /// <summary>
        /// Use the logout button to grab it's logout event
        /// </summary>
        public Button Logout { get { return logOut; } }
        /// <summary>
        /// Initializes the object
        /// </summary>
        public SideMenu()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Configures to the Admin view
        /// </summary>
        public void SetAdminView()
        {
            Bar = new MainUserControls.SideBarItem("Διαχείριση Χρηστών", "Λίστα Χρηστών", "", "", "", Properties.Resources.icons8_group_24);
            panelSubMenu.Controls.Add(Bar);
        }
        /// <summary>
        /// Configures to the marketing view
        /// </summary>
        public void SetMarketingView()
        {
            Bar = new MainUserControls.SideBarItem("Marketing", "Κέρδος Φαρμάκου", "Κέρδος Εταιρίας", "", "", Properties.Resources.icons8_marketing_24);
            panelSubMenu.Controls.Add(Bar);
        }
        /// <summary>
        /// Configures to the Storekeeper's view
        /// </summary>
        public void SetStoreKeeperView(IUpdatable<Medicine> Form)
        {
            Bar = new MainUserControls.SideBarItem("Αποθήκη", "Προσθήκη", "", "", "", Properties.Resources.icons8_warehouse_24);
            Bar.Slave1.Click += (object sender, EventArgs e)=>
            { 
                MedicineViewAdd medicineViewAdd = new MedicineViewAdd(Form, Operation.Add);
                medicineViewAdd.ShowDialog();
            };
            panelSubMenu.Controls.Add(Bar);
            
        }

        /// <summary>
        /// Configures to the Seller's View
        /// </summary>
        public void SetSellerView()
        {
            Bar = new MainUserControls.SideBarItem("Πωλητής", "Πελατολόγιο", "Παραγγελίες", "", "", Properties.Resources.icons8_gear_24);
            panelSubMenu.Controls.Add(Bar);
        }

    }
}
