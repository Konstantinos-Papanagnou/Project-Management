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
    public partial class RegisterView : Form
    {
        private Administrator admin;
        public User User { get; private set; }
        private bool firstnameGood = false;
        private bool lastnameGood = false;
        private bool idcardGood = false;
        private bool passwordGood = false;
        private bool verifypasswordGood = false;
        private bool phonenumbersGood = false;
        public RegisterView(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
            ViewPasswordsCheckBox.CheckedChanged += ViewPasswordsCheckBox_CheckedChanged;
        }

        private void ViewPasswordsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewPasswordsCheckBox.Checked)
            {
                PasswordBox.PasswordChar = '\0';
                VerifyPasswordBox.PasswordChar = '\0';
            }
            else
            {
                PasswordBox.PasswordChar = '*';
                VerifyPasswordBox.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Focus Leave of all TextBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstNameBox_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            string tag = box.Tag.ToString();
            if(tag == "firstname")
            {
                if (!Sanitizer.CheckFirstName(box.Text))
                {
                    FirstNameError.Visible = true;
                    firstnameGood = false;
                }
                else
                {
                    FirstNameError.Visible = false;
                    firstnameGood = true;
                }
            }
            else if(tag == "lastname")
            {
                if (!Sanitizer.CheckLastName(box.Text))
                {
                    LastNameError.Visible = true;
                    lastnameGood = false;
                }
                else
                {
                    LastNameError.Visible = false;
                    lastnameGood = true;
                }
            }
            else if (tag == "idcard")
            {
                if (!Sanitizer.CheckIDCard(box.Text))
                {
                    IdCardError.Visible = true;
                    idcardGood = false;
                }
                else
                {
                    IdCardError.Visible = false;
                    idcardGood = true;
                }
            }
            else if (tag == "password")
            {
                if (!Sanitizer.CheckPassword(box.Text))
                {
                    PasswordError.Visible = true;
                    passwordGood = false;
                }
                else
                {
                    PasswordError.Visible = false;
                    passwordGood = true;
                }
            }
            else if (tag == "verifypassword")
            {
                if (box.Text != PasswordBox.Text)
                {
                    VerifyPasswordError.Visible = true;
                    verifypasswordGood = false;
                }
                else
                {
                    VerifyPasswordError.Visible = false;
                    verifypasswordGood = true;
                }
            }
            else if (tag == "phonenumbers")
            {
                phonenumbersGood = true;
                if (box.Text.Contains(','))
                {
                    string[] phones = box.Text.Replace(" ", "").Split(',');
                    foreach (var phone in phones)
                    {
                        if (!Sanitizer.CheckPhoneNumber(phone))
                        {
                            PhoneNumberError.Visible = true;
                            phonenumbersGood = false;
                        }
                    }
                    if (phonenumbersGood)
                    {
                        PhoneNumberError.Visible = false;
                    }
                }
                else
                {
                    if (!Sanitizer.CheckPhoneNumber(box.Text))
                    {
                        PhoneNumberError.Visible = true;
                        phonenumbersGood = false;
                    }
                    else
                    {
                        PhoneNumberError.Visible = false;
                        phonenumbersGood = true;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool AllGood = firstnameGood && lastnameGood && idcardGood && passwordGood && verifypasswordGood && phonenumbersGood;
            if (AllGood)
            {
                List<string> phones;
                if (PhoneNumberBox.Text.Contains(','))
                    phones = PhoneNumberBox.Text.Replace(" ", "").Split(',').ToList<string>();
                else phones = new List<string>() { PhoneNumberBox.Text };
                User = new User(FirstNameBox.Text, LastNameBox.Text, IdCardBox.Text, -1, admin.GenerateUsername(FirstNameBox.Text, LastNameBox.Text), PasswordBox.Text, RoleBox.SelectedIndex, phones);
                DialogResult = DialogResult.OK;
                admin.InsertUser(User);
                this.Close();
            }
        }
    }
}
