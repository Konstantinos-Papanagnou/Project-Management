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

namespace PharmacyInformationSystem.UIComponents.MainUserControls
{
    public partial class MedicineViewAdd : Form
    {
        readonly IUpdatable<Medicine> Form;
        public Medicine Medicine;
        public MedicineViewAdd(IUpdatable<Medicine> Form)
        {
            this.Form = Form;
            InitializeComponent();
            QualityBox.SelectedIndex = 0;
            TypeBox.SelectedIndex = 0;
            AddBtn.NotifyDefault(true);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) {
                MessageBox.Show("Fill All the fields with correct values first!", "Can't Continue Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }


            Medicine = new Medicine(NameBox.Text, CategoryBox.Text, ManufacturerBox.Text, (int)Stocks.Value, (int)MinimumStocks.Value, DueDateBox.Value.ToShortDateString(), (double)AcquisitionCost.Value, (double)SellingCost.Value, QualityBox.Text[0], TypeBox.Text[0]);
            Form.RefreshList(Medicine, Operation.Update);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (!Sanitizer.CheckString(NameBox.Text))
            {
                NameError.Visible = true;
                return false;
            }
            else NameError.Visible = false;
            if (!Sanitizer.CheckString(CategoryBox.Text))
            {
                CategoryError.Visible = true;
                return false;
            }
            else CategoryError.Visible = false;
            if (!Sanitizer.CheckString(ManufacturerBox.Text))
            {
                ManufacturerError.Visible = true;
                return false;
            }
            else ManufacturerError.Visible = false;

            return true;
        }
    }
}
