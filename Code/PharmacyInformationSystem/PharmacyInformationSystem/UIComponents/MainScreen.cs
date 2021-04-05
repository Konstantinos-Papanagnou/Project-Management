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

namespace PharmacyInformationSystem
{
    public partial class MainScreen : Form
    {
        User User;
        public MainScreen(User user)
        {
            InitializeComponent();
            User = user;
            panel1.Controls.Add(new UIComponents.Navigator());
        }

    }
}
