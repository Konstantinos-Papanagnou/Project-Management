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

namespace PharmacyInformationSystem.UIComponents.MainUserControls
{
    public partial class ViewUserData : Form
    {
        /// <summary>
        /// Configures the screen to the user information provided
        /// </summary>
        /// <param name="User">User information to display</param>
        public ViewUserData(User User)
        {
            InitializeComponent();
            FirstNameLbl.Text += User.FirstName;
            LastNameLbl.Text += User.LastName;
            IDCardLbl.Text += User.IdCard;
            UsernameLbl.Text += User.Username;
            switch (User.RoleID)
            {
                case 0:
                    RoleLbl.Text += "Διαχειριστής";
                    break;
                case 1:
                    RoleLbl.Text += "Αποθηκάριος";
                    break;
                case 2:
                    RoleLbl.Text += "Πωλητής";
                    break;
                default:
                    RoleLbl.Text += "Ομάδα Marketing";
                    break;
            }
            if (User.RoleID == 2)
                SalaryLbl.Text = "Μισθός (%): ";
            SalaryLbl.Text += User.Salary.ToString();
            if (User.PhoneNumbers == null || User.PhoneNumbers.Count == 0)
            {
                PhoneNumbers.Text = "Δεν βρέθηκαν τηλέφωνα για αυτόν τον χρήστη.";
                return;
            }
            foreach(var phone in User.PhoneNumbers)
            {
                PhoneNumbers.Text += phone + ", ";
            }
            PhoneNumbers.Text = PhoneNumbers.Text.Remove(PhoneNumbers.Text.Length - 2);
        }
        /// <summary>
        /// Listens for exiting events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
