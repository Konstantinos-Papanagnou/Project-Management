using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic.SellerFunctionality
{
    public class SQLConstraintException : Exception
    {
        public SQLConstraintException(string Message) : base(Message) { }
    }
}
