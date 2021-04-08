using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test1
{
    public partial class SideMenu : UserControl
    {
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
            customizeDesign();
            random = new Random();
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

        private void customizeDesign()
        {
            panelSubMenu.Visible = false;
            panelWarehouseSubMenu.Visible = false;
            panelMarketingSubMenu.Visible = false;
            panelUserListSubMenu.Visible = false;
            panelEmpty1SubMenu.Visible = false;
            panelUserSettingsSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true) panelSubMenu.Visible = false;
            if (panelWarehouseSubMenu.Visible == true) panelSubMenu.Visible = false;
            if (panelMarketingSubMenu.Visible == true) panelSubMenu.Visible = false;
            if (panelUserListSubMenu.Visible == true) panelSubMenu.Visible = false;
            if (panelEmpty1SubMenu.Visible == true) panelSubMenu.Visible = false;
            if (panelUserSettingsSubMenu.Visible == true) panelSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void onMouseEnter(object sender, EventArgs e)
        {
            //((Button)sender).Font = new System.Drawing.Font();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            //...show user settings?
        }

        private void WarehoureBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWarehouseSubMenu);
            ActivateButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void MartketingBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMarketingSubMenu);
            ActivateButton(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void UserlListBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUserListSubMenu);
            ActivateButton(sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void emptyBtn1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpty1SubMenu);
            ActivateButton(sender);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void UserSettingsBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUserSettingsSubMenu);
            ActivateButton(sender);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //...code
            hideSubMenu();
        }

        
    }
}
