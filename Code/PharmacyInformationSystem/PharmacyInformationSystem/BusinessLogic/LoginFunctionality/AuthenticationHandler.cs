using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic.LoginFunctionality
{
    public class AuthenticationHandler
    {
        DatabaseHandler Database;
        public AuthenticationHandler()
        {
            Database = new DatabaseHandler();
        }

        public User AuthenticateUser(string username, string password)
        {
            if (!Database.CredentialCheck(username, password))
                throw new AuthenticationFailure("Invalid Credentials");
            return Database.GetUserData(username);
        }
    }
}
