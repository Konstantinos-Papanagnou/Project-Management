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

namespace PharmacyInformationSystem.UIComponents.MainUserControls.Pharmacist
{
    public partial class TablePharmacist : UserControl, IUpdatable<Logic.Pharmacist>
    {
        private readonly List<PharmacistListViewItem> Items;
        private readonly Logic.Seller Seller;
        public TablePharmacist(Logic.Seller Seller)
        {
            InitializeComponent();
            this.Seller = Seller;
            Items = new List<PharmacistListViewItem>();
            RefreshList();
            navigatorPharmacist1.AddNew.Click += AddNew_Click;
            navigatorPharmacist1.Search.KeyUp += Search_KeyUp;
        }

        /// <summary>
        /// Calls the Register user on Add Mode to get user information and add it to the database
        /// and refreshes the ui list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNew_Click(object sender, EventArgs e)
        {
            FormPharmacist form = new FormPharmacist(this, Operation.Add);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var ph = Seller.AddPharmacist(form.Pharmacist);
                    if (ph != null)
                    {
                        RefreshList();
                    }
                    else MessageBox.Show("Ωχ, κάτι πήγε στραβά!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Logic.SellerFunctionality.SQLConstraintException e1) { MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        /// <summary>
        /// KeyUp provides real time search and isolation of the matching results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            List.Controls.Clear();
            foreach (var item in Items)
            {
                if (item.User.FirstName.ToLower().Contains(navigatorPharmacist1.Search.Text.ToLower()) || item.User.LastName.ToLower().Contains(navigatorPharmacist1.Search.Text.ToLower()) || item.User.AFM.ToLower().Contains(navigatorPharmacist1.Search.Text.ToLower()) || item.User.PATown.ToString().Contains(navigatorPharmacist1.Search.Text) || item.User.Phone.Contains(navigatorPharmacist1.Search.Text) || item.User.PAStreet.ToLower().Contains(navigatorPharmacist1.Search.Text.ToLower()) || item.User.PANumber.ToLower().Contains(navigatorPharmacist1.Search.Text.ToLower()) || item.User.PAPostalCode.ToLower().Contains(navigatorPharmacist1.Search.Text.ToLower()))
                {
                    List.Controls.Add(item);
                }
            }
        }

        public void RefreshList()
        {
            List.Controls.Clear();
            Items.Clear();
            var Users = Seller.GetPharmacists();
            foreach (var User in Users)
            {
                PharmacistListViewItem item = new PharmacistListViewItem(this, User);
                Items.Add(item);
                List.Controls.Add(item);
            }
        }

        public void RefreshList(Logic.Pharmacist user, Operation op)
        {
            int index = -1;
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].User.PharmacistID == user.PharmacistID)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1) return;
            if (op == Operation.Update)
            {
                try
                {
                    if (Seller.ModifyPharmacist(user))
                    {
                        PharmacistListViewItem item = new PharmacistListViewItem(this, user);
                        Items.Add(item);
                        List.Controls.Add(item);
                        List.Controls.Remove(Items[index]);
                        Items.RemoveAt(index);
                    }
                    else { MessageBox.Show("Ωχ, κάτι πήγε στραβά!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                } catch (Logic.SellerFunctionality.SQLConstraintException e) { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            if (op == Operation.Remove)
            {
                if (!Seller.RemovePharmacist(user.PharmacistID))
                {
                    MessageBox.Show("Ωχ, κάτι πήγε στραβά!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
