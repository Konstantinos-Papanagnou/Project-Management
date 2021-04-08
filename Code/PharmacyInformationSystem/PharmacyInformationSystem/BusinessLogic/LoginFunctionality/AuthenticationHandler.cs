using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic.LoginFunctionality
{
    /// <summary>
    /// Wrapper class for the Authentication Management
    /// </summary>
    public class AuthenticationHandler
    {
        readonly DatabaseHandler Database;
        public int AttemptCount { get; set; }
        bool ThreadWorking = false;
        public AuthenticationHandler()
        {
            Database = new DatabaseHandler();
            AttemptCount = 0;
        }

        /// <summary>
        /// Blocks the user from authenticating for 30 seconds.
        /// </summary>
        private void Block(object o)
        {
            Thread.Sleep(30 * 1000);
            AttemptCount = 0;
            ThreadWorking = false;
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
            if (AttemptCount >= 3)
            {
                if (!ThreadWorking)
                    ThreadPool.QueueUserWorkItem(Block);
                ThreadWorking = true;
                throw new AuthenticationFailure("You have been blocked due to 3 failed attempts in a row. Please try again in 30 seconds");
            }
            AttemptCount++;
            if (!Database.CredentialCheck(username, password))
                throw new AuthenticationFailure("Invalid Credentials");
            return Database.GetUserData(username);
        }
    }
}
