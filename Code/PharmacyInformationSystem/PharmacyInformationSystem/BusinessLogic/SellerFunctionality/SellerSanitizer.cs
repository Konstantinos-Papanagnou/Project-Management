using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.BusinessLogic
{
    /// <summary>
    /// Wrapper class that handles application policy and Sanitization techniques
    /// </summary>
    public abstract partial class Sanitizer
    {
        public static bool CheckAFM(string input)
        {
            return Regex.IsMatch(input, "^\\d{9}$");
        }

        public static bool CheckPostalCode(string input)
        {
            return Regex.IsMatch(input, "^\\d{5}$");
        }
    }
}
