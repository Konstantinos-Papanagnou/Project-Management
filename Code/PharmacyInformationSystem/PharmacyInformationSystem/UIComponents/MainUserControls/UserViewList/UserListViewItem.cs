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

namespace PharmacyInformationSystem.UIComponents.MainUserControls.UserViewList
{
    public partial class UserListViewItem : UserControl
    {
        bool Expanded = false;
        readonly User User;
        public UserListViewItem(User user)
        {
            InitializeComponent();
            this.User = user;
            SumInfoLbl.Text = user.FirstName + " " + user.LastName;
            NameLbl.Text = user.FirstName;
            LastNameLbl.Text = user.LastName;
            IdCardLbl.Text = user.IdCard;
            UsernameLbl.Text = user.Username;
            switch (user.RoleID)
            {
                case 0:
                    RoleLbl.Text = "Διαχειριστής";
                    break;
                case 1:
                    RoleLbl.Text = "Αποθηκάριος";
                    break;
                case 2:
                    RoleLbl.Text = "Πωλητής";
                    break;
                default:
                    RoleLbl.Text = "Ομάδα Marketing";
                    break;
            }
            if (user.PhoneNumbers == null || user.PhoneNumbers.Count == 0) {
                PhoneNumbersLbl.Text = "Δεν βρέθηκαν τηλέφωνα για αυτόν τον Χρήστη";
                return;
            }
            foreach (var number in user.PhoneNumbers)
                PhoneNumbersLbl.Text += number + " ";
        }

        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            Expanded = !Expanded;
            if (Expanded)
                this.Size = new Size(909, 296);
            else this.Size = new Size(909, 69);
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            // New Register Form with the already created data inserted
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Call the delete method for the current user
        }
    }
}
