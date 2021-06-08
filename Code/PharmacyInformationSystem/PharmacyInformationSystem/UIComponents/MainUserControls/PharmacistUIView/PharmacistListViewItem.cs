using Logic = PharmacyInformationSystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmacyInformationSystem.UIComponents.MainUserControls.Pharmacist
{
    public partial class PharmacistListViewItem : UserControl
    {
        bool Expanded = false;
        public readonly Logic.Pharmacist User;
        private readonly IUpdatable<Logic.Pharmacist> UpdatableForm;
        /// <summary>
        /// Initialize the inteface with personalized settings.
        /// </summary>
        /// <param name="form">Requires a form contract to update the List</param>
        /// <param name="user">Requires user information to display</param>
        public PharmacistListViewItem(IUpdatable<Logic.Pharmacist> form, Logic.Pharmacist user)
        {
            InitializeComponent();
            this.UpdatableForm = form;
            this.User = user;
            SumInfoLbl.Text = user.FirstName + " " + user.LastName;
            NameLbl.Text = user.FirstName;
            LastNameLbl.Text = user.LastName;
            AFMLbl.Text = user.AFM;
            PhoneNumberLbl.Text = user.Phone;
            AdressLbl.Text = user.PATown + " " + user.PAStreet + " " + user.PANumber;
            if (user.PATown == "" && user.PAStreet == "" && user.PANumber == "")
            {
                DeleteBtn.Enabled = false; 
                SumInfoLbl.Text += " [Αρχείο]";
            }
            PostalCodeLbl.Text = user.PAPostalCode;
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
                this.Size = new Size(909, 275);
            else this.Size = new Size(909, 60);
        }

        /// <summary>
        /// Listens for a modification Request and it deletes the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
           new FormPharmacist(UpdatableForm, Operation.Update, User).ShowDialog();
        }
        /// <summary>
        /// Listens for a Delete Request and it Deletes the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(new DeletePharmacist().ShowDialog() == DialogResult.OK)
            {
                UpdatableForm.RefreshList(User, Operation.Remove);
                AdressLbl.Text = "";
                User.PATown = "";
                User.PAStreet = "";
                User.PANumber = "";
                User.PAPostalCode = "";
                PostalCodeLbl.Text = "";
                DeleteBtn.Enabled = false;
                SumInfoLbl.Text += " [Αρχείο]";
            }
        }
    }
}
