using PharmacyInformationSystem.BusinessLogic;
using PharmacyInformationSystem.UIComponents.MainUserControls.UserViewList;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PharmacyInformationSystem.UIComponents.MainUserControls
{
    public partial class UsersList : UserControl, IUpdatable
    {
        private readonly Administrator Admin;
        private readonly List<UserListViewItem> Items;
        public UsersList(Administrator Admin)
        {
            InitializeComponent();
            this.Admin = Admin;
            Items = new List<UserListViewItem>();
            RefreshList();
            listNavigator1.AddNew.Click += AddNew_Click;
            listNavigator1.Search.KeyUp += Search_KeyUp; ;
        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            List.Controls.Clear();
            foreach (var item in Items)
            {
                if (item.User.FirstName.ToLower().Contains(listNavigator1.Search.Text.ToLower()) || item.User.LastName.ToLower().Contains(listNavigator1.Search.Text.ToLower()) || item.User.IdCard.ToLower().Contains(listNavigator1.Search.Text.ToLower()) || item.User.RoleID.ToString().Contains(listNavigator1.Search.Text) || PhoneCheck(item.User.PhoneNumbers, listNavigator1.Search.Text) || item.User.Username.ToLower().Contains(listNavigator1.Search.Text.ToLower()))
                {
                    List.Controls.Add(item);
                }
            }
        }

        private bool PhoneCheck(List<string> numbers, string pattern)
        {
            foreach (var number in numbers)
                if (number.Contains(pattern))
                    return true;
            return false;
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            RegisterView form = new RegisterView();
            if(form.ShowDialog() == DialogResult.OK)
            {
                User user = form.User;
                user.Username = Admin.GenerateUsername(user.FirstName, user.LastName);
                if (Admin.InsertUser(user))
                {
                    RefreshList();
                }else MessageBox.Show("Ωχ, κάτι πήγε στραβά!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshList()
        {
            List.Controls.Clear();
            Items.Clear();
            var Users = Admin.GetAllUsers();
            foreach (var User in Users)
            {
                UserListViewItem item = new UserListViewItem(this, User);
                Items.Add(item);
                List.Controls.Add(item);
            }
        }

        public void RefreshList(User user, Operation op)
        {
            int index = -1;
            for(int i = 0; i < Items.Count; i++)
            {
                if (Items[i].User.EmployeeID == user.EmployeeID)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1) return;
            List.Controls.Remove(Items[index]);
            Items.RemoveAt(index);
            if(op == Operation.Update)
            {
                if (Admin.ModifyUser(user))
                {
                    UserListViewItem item = new UserListViewItem(this, user);
                    Items.Add(item);
                    List.Controls.Add(item);
                }
                else MessageBox.Show("Ωχ, κάτι πήγε στραβά!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
            if (op == Operation.Remove)
            {
                if (!Admin.DeleteUser(user))
                {
                    MessageBox.Show("Ωχ, κάτι πήγε στραβά!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
