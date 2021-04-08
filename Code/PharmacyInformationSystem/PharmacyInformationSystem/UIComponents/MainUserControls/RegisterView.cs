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
        public User User { get; private set; }
        private bool firstnameGood = false;
        private bool lastnameGood = false;
        private bool idcardGood = false;
        private bool passwordGood = false;
        private bool verifypasswordGood = false;
        private bool phonenumbersGood = false;
        private bool AdminBypass = false;

        private bool EditMode = false;
        /// <summary>
        /// Call this Constructor if you want to insert user information
        /// </summary>
        public RegisterView()
        {
            InitializeComponent();
            ViewPasswordsCheckBox.CheckedChanged += ViewPasswordsCheckBox_CheckedChanged;
        }

        /// <summary>
        /// Call this Constructor if you want to modify user information
        /// </summary>
        /// <param name="User"></param>
        public RegisterView(User User)
        {
            InitializeComponent();
            this.User = User;
            FirstNameBox.Text = User.FirstName;
            LastNameBox.Text = User.LastName;
            IdCardBox.Text = User.IdCard;
            if (User.RoleID == 0) { RoleBox.Enabled = false; AdminBypass = true; }
            
            RoleBox.SelectedIndex = User.RoleID -1;
            foreach (var item in User.PhoneNumbers)
                PhoneNumberBox.Text += item + ", ";
            if(PhoneNumberBox.Text.Length > 0) PhoneNumberBox.Text.Remove(PhoneNumberBox.Text.Length - 2);
            firstnameGood = true;
            lastnameGood = true;
            idcardGood = true;
            passwordGood = true;
            verifypasswordGood = true;
            phonenumbersGood = true;
            EditMode = true;
            this.Text = "Update User Information";
            ViewPasswordsCheckBox.CheckedChanged += ViewPasswordsCheckBox_CheckedChanged;
        }

        /// <summary>
        /// Listens for the check changed event and switches on off the password cover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (string.IsNullOrWhiteSpace(PasswordBox.Text) && EditMode)
                {
                    passwordGood = true;
                    verifypasswordGood = true;
                    return;
                }
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

        /// <summary>
        /// Returns the modifications to the calling class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bool AllGood = firstnameGood && lastnameGood && idcardGood && passwordGood && verifypasswordGood && phonenumbersGood;
            if (AllGood)
            {
                List<string> phones;
                if (PhoneNumberBox.Text.Contains(','))
                    phones = PhoneNumberBox.Text.Replace(" ", "").Split(',').ToList<string>();
                else phones = new List<string>() { PhoneNumberBox.Text };
                if (!EditMode)
                    User = new User(FirstNameBox.Text, LastNameBox.Text, IdCardBox.Text, -1, null, PasswordBox.Text, RoleBox.SelectedIndex + 1, phones);
                else User = new User(FirstNameBox.Text, LastNameBox.Text, IdCardBox.Text, User.EmployeeID, User.Username, PasswordBox.Text, AdminBypass ? User.RoleID : RoleBox.SelectedIndex + 1 , phones);
                DialogResult = DialogResult.OK;
                this.Close();
            }else
                MessageBox.Show("Fill All the fields with correct values first!", "Can't Continue Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
