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
    public partial class StorageListView : UserControl, IUpdatable<Medicine>
    {
        private readonly StoreKeeper User;
        private List<Medicine> Medicines;
        public StorageListView(StoreKeeper User)
        {
            this.User = User;
            InitializeComponent();

            var Medicines = User.GetMedicines();
            foreach (var med in Medicines) {
                var lvi = new ListViewItem(med.MedName);
                lvi.SubItems.Add(med.MedCategory);
                lvi.SubItems.Add(med.MedManfactureComp);
                lvi.SubItems.Add(med.MedDueDate);
                lvi.SubItems.Add(med.MedStockCount.ToString());
                lvi.SubItems.Add(med.MedMinStock.ToString());
                lvi.SubItems.Add(med.MedAcquisitionValue.ToString());
                lvi.SubItems.Add(med.MedSellingValue.ToString());
                lvi.SubItems.Add(med.MedQuality);
                lvi.SubItems.Add(med.MedType);
            }
        }

        public void RefreshList()
        {
            List.Items.Clear();
            foreach (var med in Medicines)
            {
                var lvi = new ListViewItem(med.MedName);
                lvi.SubItems.Add(med.MedCategory);
                lvi.SubItems.Add(med.MedManfactureComp);
                lvi.SubItems.Add(med.MedDueDate);
                lvi.SubItems.Add(med.MedStockCount.ToString());
                lvi.SubItems.Add(med.MedMinStock.ToString());
                lvi.SubItems.Add(med.MedAcquisitionValue.ToString());
                lvi.SubItems.Add(med.MedSellingValue.ToString());
                lvi.SubItems.Add(med.MedQuality);
                lvi.SubItems.Add(med.MedType);
            }
        }

        public void RefreshList(Medicine user, Operation op)
        {
            throw new NotImplementedException();
        }
    }
}
