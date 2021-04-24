using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic
{
    public abstract partial class Sanitizer
    {
		/// <summary>
		/// Checks if the string supplied is within the policy
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool CheckString(string input)
		{
			if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input) || input.Length < 2 || input.Length >= 30)
				return false;
			if (Regex.IsMatch(input, "[α-ωΑ-Ωa-zA-Z0-9]")) return true;
			return false;
		}
	}
}
