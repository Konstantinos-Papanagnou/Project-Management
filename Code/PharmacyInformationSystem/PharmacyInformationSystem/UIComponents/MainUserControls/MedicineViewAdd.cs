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
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {


            Form.RefreshList();
            DialogResult = DialogResult.OK;   
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
            if (!Sanitizer.CheckString(ManifacturerBox.Text))
            {
                ManifacturerError.Visible = true;
                return false;
            }
            else ManifacturerError.Visible = false;

            

            return true;
        }
    }
}
