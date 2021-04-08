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
        public Button Master { get { return MasterMenu; } }
        public Button Slave1 { get { return SubOperation1; } }
        public Button Slave2 { get { return SubOperation2; } }
        public Button Slave3 { get { return SubOperation3; } }
        public Button Slave4 { get { return SubOperation4; } }
        public SideBarItem(string Title, string BtnName1, string BtnName2, string BtnName3, string BtnName4, Bitmap iconResource)
        {
            InitializeComponent();
            MasterMenu.Text = Title;
            MasterMenu.Image = iconResource;
            SubOperation1.Text = BtnName1;
            SubOperation2.Text = BtnName2;
            SubOperation3.Text = BtnName3;
            SubOperation4.Text = BtnName4;
        }
    }
}
