using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyInformationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You clicked me !", "My Title", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Fine");
            }
            else MessageBox.Show("Fuck off");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I said don't click me!");
        }
    }
}
