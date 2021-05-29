using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyInformationSystem.UIComponents.MainUserControls.Pharmacist
{
    public partial class NavigatorPharmacist : UserControl
    {
        public Button AddNew { get { return AddBtn; } }
        public TextBox Search { get { return SearchBox; } }

        public NavigatorPharmacist()
        {
            InitializeComponent();
        }
    }
}
