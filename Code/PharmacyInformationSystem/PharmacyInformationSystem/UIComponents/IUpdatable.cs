using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.UIComponents
{
    public enum Operation
    {
        Remove,
        Update
    }
    public interface IUpdatable<T>
    {
        void RefreshList();
        void RefreshList(T user, Operation op);
    }
}
