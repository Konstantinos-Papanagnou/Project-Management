using PharmacyInformationSystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList
{
    public partial class StorageTableView : UserControl
    {
        public StorageTableView(Medicine medicine)
        {
            InitializeComponent();
            //ListView.ColumnHeaderCollection StorageListView;
            List<Medicine> medicines = new List<Medicine>();

            medicines.Add(new Medicine());
        }

        public void fillList()
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void εξαγωγήToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void επεξεργασίαToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
