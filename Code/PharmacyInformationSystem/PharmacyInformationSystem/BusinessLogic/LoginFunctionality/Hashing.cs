using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PharmacyInformationSystem.BusinessLogic.LoginFunctionality
{
    /// <summary>
    /// Wrapper class for the hashing functionality
    /// </summary>
    public abstract class Hashing
    {
        /// <summary>
        /// Computes the hash of the supplied password with SHA256 algorithm
        /// </summary>
        /// <param name="password">The password to hash</param>
        /// <returns>The SHA256 hash of the supplied password</returns>
        public static string ComputeHash(string password)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
