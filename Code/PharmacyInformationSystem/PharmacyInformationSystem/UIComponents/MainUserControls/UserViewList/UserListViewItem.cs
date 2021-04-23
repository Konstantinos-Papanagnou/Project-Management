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
        public readonly User User;
        private readonly IUpdatable<User> UpdatableForm;
        /// <summary>
        /// Initialize the inteface with personalized settings.
        /// </summary>
        /// <param name="form">Requires a form contract to update the List</param>
        /// <param name="user">Requires user information to display</param>
        public UserListViewItem(IUpdatable<User> form, User user)
        {
            InitializeComponent();
            this.UpdatableForm = form;
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
                    DeleteBtn.Enabled = false;
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

        /// <summary>
        /// Listens for expand requests to expand the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            Expanded = !Expanded;
            if (Expanded)
                this.Size = new Size(909, 296);
            else this.Size = new Size(909, 69);
        }

        /// <summary>
        /// Listens for a modification Request and it deletes the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            RegisterView editForm = new RegisterView(User);
            if(editForm.ShowDialog() == DialogResult.OK)
            {
                User userdata = editForm.User;
                UpdatableForm.RefreshList(userdata, Operation.Update);           
            }
        }
        /// <summary>
        /// Listens for a Delete Request and it Deletes the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Είστε σίγουρος πως θέλετε να διαγράψετε τον χρήστη: " + User.FirstName + "; \nΑυτή η διαδικασία είναι μη αναστρέψιμη!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdatableForm.RefreshList(User, Operation.Remove);
            }
        }
    }
}
