using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.UIComponents.MainUserControls.UserViewList
{
    public enum Operation
    {
        Remove,
        Update
    }
    public interface IUpdatable
    {
        void RefreshList();
        void RefreshList(User user, Operation op);
    }
}
