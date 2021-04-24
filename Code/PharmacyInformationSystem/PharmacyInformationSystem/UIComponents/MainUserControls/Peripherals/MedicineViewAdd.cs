using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        readonly Operation Op;
        public MedicineViewAdd(IUpdatable<Medicine> Form, Operation op, Medicine med = null)
        {
            this.Op = op;
            this.Form = Form;
            this.Medicine = med;
            InitializeComponent();
            QualityBox.SelectedIndex = 0;
            TypeBox.SelectedIndex = 0;
            AddBtn.NotifyDefault(true);
            if (op == Operation.Update)
            {
                AddBtn.Text = "Τροποποίηση";
                this.Text = "Τροποποίηση Φαρμάκου";
                ManufacturerBox.Enabled = false;
                if (med == null) return;
                NameBox.Text = med.MedName;
                ManufacturerBox.Text = med.MedManfactureComp;
                CategoryBox.Text = med.MedCategory;
                DueDateBox.Value = DateTime.ParseExact(med.MedDueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                QualityBox.Text = MapValues(med.MedQuality);
                Stocks.Value = med.MedStockCount;
                MinimumStocks.Value = med.MedMinStock;
                TypeBox.Text = MapValues(med.MedType);
                AcquisitionCost.Value = decimal.Parse(med.MedAcquisitionValue.ToString());
                SellingCost.Value = decimal.Parse(med.MedSellingValue.ToString());
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) {
                MessageBox.Show("Fill All the fields with correct values first!", "Can't Continue Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if(Op == Operation.Add)
                Medicine = new Medicine(NameBox.Text, CategoryBox.Text, ManufacturerBox.Text, (int)Stocks.Value, (int)MinimumStocks.Value, DueDateBox.Value.ToString("dd/MM/yyyy"), (double)AcquisitionCost.Value, (double)SellingCost.Value, QualityBox.Text[0], TypeBox.Text[0]);
            else
                Medicine = new Medicine(Medicine.MedID, NameBox.Text, CategoryBox.Text, ManufacturerBox.Text, DueDateBox.Value.ToString("dd/MM/yyyy"), (int)Stocks.Value, (int)MinimumStocks.Value,  (double)AcquisitionCost.Value, (double)SellingCost.Value, QualityBox.Text[0], TypeBox.Text[0]);
            Form.RefreshList(Medicine, Op);
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
        private string MapValues(char value)
        {
            switch (value)
            {
                case 'Φ':
                    return "Φάρμακο";
                case 'Π':
                    return "Παραφαρμακευτικό";
                case 'Κ':
                    return "Κανονικό";
                default:
                    return "Γενόσημο";
            }
        }
    }

}
