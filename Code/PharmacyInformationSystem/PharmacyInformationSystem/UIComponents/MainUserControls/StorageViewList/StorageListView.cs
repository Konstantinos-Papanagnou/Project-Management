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

namespace PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList
{
    public partial class StorageListView : UserControl
    {
        private readonly StoreKeeper User;
        public StorageListView(StoreKeeper User)
        {
            this.User = User;
            InitializeComponent();

            var meds = User.GetMedicines();
            foreach (var med in meds) {
                var lvi = new ListViewItem(med.MedName);
                lvi.SubItems.Add(med.MedCategory);
                lvi.SubItems.Add(med.MedManfactureComp);
                lvi.SubItems.Add(med.MedDueDate);
                lvi.SubItems.Add(med.MedMinStock.ToString());

            }
        }
    }
}
