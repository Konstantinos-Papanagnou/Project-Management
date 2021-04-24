using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyInformationSystem.UIComponents.MainUserControls
{
    public partial class SideBarItem : UserControl
    {
        /// <summary>
        /// Use this Master Object to grab the events
        /// </summary>
        public Button Master { get { return MasterMenu; } }
        /// <summary>
        /// Use this slave Object to grab the events
        /// </summary>
        public Button Slave1 { get { return SubOperation1; } }
        /// <summary>
        /// Use this slave Object to grab the events
        /// </summary>
        public Button Slave2 { get { return SubOperation2; } }
        /// <summary>
        /// Use this slave Object to grab the events
        /// </summary>
        public Button Slave3 { get { return SubOperation3; } }
        /// <summary>
        /// Use this slave Object to grab the events
        /// </summary>
        public Button Slave4 { get { return SubOperation4; } }
        /// <summary>
        /// Initializes the inteface with the specified input
        /// </summary>
        /// <param name="Title">The Master button (Usually does nothing unless configured to do)</param>
        /// <param name="BtnName1">The first slave (Empty string will make it invisible)</param>
        /// <param name="BtnName2">The second slave (Empty string will make it invisible)</param>
        /// <param name="BtnName3">The third slave (Empty string will make it invisible)</param>
        /// <param name="BtnName4">The fourth slave (Empty string will make it invisible)</param>
        /// <param name="iconResource">The icon to display alongside the Master Button</param>
        public SideBarItem(string Title, string BtnName1, string BtnName2, string BtnName3, string BtnName4, Bitmap iconResource)
        {
            InitializeComponent();
            MasterMenu.Text = Title;
            MasterMenu.Image = iconResource;
            if (string.IsNullOrEmpty(BtnName1))
                SubOperation1.Visible = false;
            if (string.IsNullOrEmpty(BtnName2))
                SubOperation2.Visible = false;
            if (string.IsNullOrEmpty(BtnName3))
                SubOperation3.Visible = false;
            if (string.IsNullOrEmpty(BtnName4))
                SubOperation4.Visible = false;
            SubOperation1.Text = BtnName1;
            SubOperation2.Text = BtnName2;
            SubOperation3.Text = BtnName3;
            SubOperation4.Text = BtnName4;
            SubOperation1.BackColor = Color.YellowGreen;
        }
        /// <summary>
        /// Method that Marks Selected a specific button object of the slave category
        /// </summary>
        /// <param name="sender">The slave control to mark selected</param>
        public void MarkSelected(object sender)
        {
            foreach(var button in Controls)
                if(button is Button slave)
                    if(slave.Tag.ToString() != "Master")
                        slave.BackColor = Color.FromArgb(68, 71, 74);
            ((Button)sender).BackColor = Color.YellowGreen;
        }
    }
}
