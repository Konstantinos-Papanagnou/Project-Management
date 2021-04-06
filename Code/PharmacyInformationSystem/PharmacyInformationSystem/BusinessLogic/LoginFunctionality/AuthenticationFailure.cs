using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic.LoginFunctionality
{
    /// <summary>
    /// Exception thrown when the authentication fails
    /// Contains a Message with the reason
    /// </summary>
    public class AuthenticationFailure : System.Exception
    {
        public AuthenticationFailure(string message): base(message) { }
    }
}
