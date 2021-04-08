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
        User User;
        public UserListViewItem(User user)
        {
            InitializeComponent();
            this.User = user;
            
        }

        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            Expanded = !Expanded;
            if (Expanded)
                this.Size = new Size(909, 316);
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
