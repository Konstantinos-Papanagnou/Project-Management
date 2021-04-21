using PharmacyInformationSystem.BusinessLogic;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyInformationSystem.UIComponents.MainUserControls.StorageViewList
{
    public partial class StorageList : UserControl
    {
        private readonly StoreKeeper Keeper;
        private readonly Medicine Medicine;

        public StorageList(StoreKeeper Keeper)
        {
            this.Keeper = Keeper;
            InitializeComponent();
            fillList();
        }

        private void fillList()
        {
            
            
        }
    }
}
