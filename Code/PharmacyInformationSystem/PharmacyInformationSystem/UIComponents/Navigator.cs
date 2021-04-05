using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyInformationSystem.UIComponents
{
    public partial class Navigator : UserControl
    {
        public Navigator()
        {
            InitializeComponent();
        }

        private void Logout_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
        }

        private void Logout_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }
    }
}
