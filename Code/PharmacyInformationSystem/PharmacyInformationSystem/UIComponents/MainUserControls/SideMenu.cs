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
        public static class ThemeColor
        {
            public static List<string> ColorList = new List<string>() { "#7CFC00", "#7FFF00", "#32CD32", "#00FF00", "#228B22", "#008000", "#006400", "#ADFF2F", "#9ACD32", "#00FF7F", "#00FA9A", "#90EE90", "#98FB98", "#8FBC8F", "#3CB371", "#20B2AA", "#2E8B57", "#6B8E23" };
        }
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public SideMenu()
        {
            InitializeComponent();
            //customizeDesign();
            random = new Random();
        }

        public void SetAdminView()
        {
            panelSubMenu.Controls.Add(new MainUserControls.SideBarItem("Διαχείριση Χρηστών", "Λειτουργία 1", "Λειτουργία 2", "Λειτουργία 3", "Λειτουργία 4", Properties.Resources.icons8_group_24));
            
        }

        public void SetMarketingView()
        {
            panelSubMenu.Controls.Add(new MainUserControls.SideBarItem("Marketing", "Λειτουργία 1", "Λειτουργία 2", "Λειτουργία 3", "Λειτουργία 4", Properties.Resources.icons8_marketing_24));
        }

        public void SetStoreKeeperView()
        {
            panelSubMenu.Controls.Add(new MainUserControls.SideBarItem("Αποθήκη", "Λειτουργία 1", "Λειτουργία 2", "Λειτουργία 3", "Λειτουργία 4", Properties.Resources.icons8_warehouse_24));

        }

        public void SetSellerView()
        {
            panelSubMenu.Controls.Add(new MainUserControls.SideBarItem("Πωλητής", "Λειτουργία 1", "Λειτουργία 2", "Λειτουργία 3", "Λειτουργία 4", Properties.Resources.icons8_gear_24));

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (currentButton != (Button)btnSender)
            {
                DisableButton();
                Color color = SelectThemeColor();
                currentButton = (Button)btnSender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 43, 48);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

    }
}
