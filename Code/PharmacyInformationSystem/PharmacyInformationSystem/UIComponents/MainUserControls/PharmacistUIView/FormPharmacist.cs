using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic = PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.UIComponents.MainUserControls
{
    public partial class FormPharmacist : Form
    {
        readonly IUpdatable<Logic::Pharmacist> Form;
        public Logic::Pharmacist Pharmacist;
        readonly Operation Op;
        public FormPharmacist(IUpdatable<Logic::Pharmacist> Form, Operation op, Logic::Pharmacist phar = null)
        {
            InitializeComponent();
            this.Form = Form;
            this.Op = op;
            this.Pharmacist = phar;

            AddBtn.NotifyDefault(true);
            if (op == Operation.Update)
            {
                AddBtn.Text = "Τροποποίηση";
                this.Text = "Τροποποίηση Φαρμακοποιού";
               
                if (phar == null) return;
                FirstNameBox.Text = phar.FirstName;
                LastNameBox.Text = phar.LastName;
                AFMBox.Text = phar.AFM;
                PhoneBox.Text = phar.Phone;

                TownBox.Text = phar.PATown;
                StreetBox.Text = phar.PAStreet;
                NumberBox.Text = phar.PANumber;
                PostalCodeBox.Text = phar.PAPostalCode;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Fill All the fields with correct values first!", "Can't Continue Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Op == Operation.Add)
            {
                Pharmacist = new Logic::Pharmacist(LastNameBox.Text, FirstNameBox.Text, AFMBox.Text, PhoneBox.Text, NumberBox.Text, StreetBox.Text, TownBox.Text, PostalCodeBox.Text, -1);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            Pharmacist = new Logic::Pharmacist(Pharmacist.PharmacistID, LastNameBox.Text, FirstNameBox.Text, AFMBox.Text, PhoneBox.Text, NumberBox.Text, StreetBox.Text, TownBox.Text, PostalCodeBox.Text, -1);
            Form.RefreshList(Pharmacist, Op);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (!Logic::Sanitizer.CheckFirstName(FirstNameBox.Text))
            {
                FirstNameError.Visible = true;
                return false;
            }
            else FirstNameError.Visible = false;
            if (!Logic::Sanitizer.CheckLastName(LastNameBox.Text))
            {
                LastNameError.Visible = true;
                return false;
            }
            else LastNameError.Visible = false;
            if (!Logic::Sanitizer.CheckAFM(AFMBox.Text))
            {
                AFMError.Visible = true;
                return false;
            }
            else AFMError.Visible = false;
            if (!Logic::Sanitizer.CheckPhoneNumber(PhoneBox.Text))
            {
                PhoneError.Visible = true;
                return false;
            }
            else PhoneError.Visible = false;
            if (!Logic::Sanitizer.CheckString(TownBox.Text))
            {
                TownError.Visible = true;
                return false;
            }
            else TownError.Visible = false;
            if (!Logic::Sanitizer.CheckPostalCode(PostalCodeBox.Text))
            {
                PostalCodeError.Visible = true;
                return false;
            }
            else PostalCodeError.Visible = false;
            if (!Logic::Sanitizer.CheckString(StreetBox.Text))
            {
                StreetError.Visible = true;
                return false;
            }
            else StreetError.Visible = false;

            return true;
        }
    }
}
