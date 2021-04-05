using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UsernameBox_Validating(object sender, CancelEventArgs e)
        {
            if (UsernameBox.Text == string.Empty) 
            {
                
            }
        }

    }
}
