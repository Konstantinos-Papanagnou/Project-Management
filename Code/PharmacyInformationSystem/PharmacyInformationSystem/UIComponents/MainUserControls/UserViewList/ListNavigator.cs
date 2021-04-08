using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyInformationSystem.UIComponents
{
    public partial class ListNavigator : UserControl
    {
        public Button AddNew { get { return ListAddBtn; } }
        public TextBox Search { get { return ListSearchBox; } }
        public ListNavigator()
        {
            InitializeComponent();
        }

    }
}
