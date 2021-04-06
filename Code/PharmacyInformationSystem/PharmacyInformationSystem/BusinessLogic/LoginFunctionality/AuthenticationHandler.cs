using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic.LoginFunctionality
{
    /// <summary>
    /// Wrapper class for the Authentication Management
    /// </summary>
    public class AuthenticationHandler
    {
        DatabaseHandler Database;
        public AuthenticationHandler()
        {
            Database = new DatabaseHandler();
        }
        /// <summary>
        /// Authenticates the User
        /// </summary>
        /// <param name="username">The username to authenticate against</param>
        /// <param name="password">The password to authenticate against</param>
        /// <returns>The user data of the authenticated user</returns>
        /// <exception cref="AuthenticationFailure">Throws AuthenticationFailure Exception if the authentication fails</exception>
        public User AuthenticateUser(string username, string password)
        {
            if (!Database.CredentialCheck(username, password))
                throw new AuthenticationFailure("Invalid Credentials");
            return Database.GetUserData(username);
        }
    }
}
