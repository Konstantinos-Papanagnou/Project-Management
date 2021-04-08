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
    public partial class UsersList : UserControl
    {
        Administrator admin;
        public UsersList(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
            RefreshList();
            listNavigator1.AddNew.Click += AddNew_Click;

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            RegisterView form = new RegisterView(admin);
            if(form.ShowDialog() == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void RefreshList()
        {
            List.Controls.Clear();

            var Users = admin.GetAllUsers();
            foreach (var User in Users)
            {
                UserViewList.UserListViewItem item = new UserViewList.UserListViewItem(User);
                List.Controls.Add(item);
            }
        }
    }
}
