using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic
{
	/// <summary>
	/// Wrapper class that handles application policy and Sanitization techniques
	/// </summary>
    public abstract class Sanitizer
    {
		/// <summary>
		/// Runs a check against the firstname
		/// </summary>
		/// <param name="firstName">The firstname to check</param>
		/// <returns>True if the supplied argument does not violate the application policy</returns>
		public static bool CheckFirstName(string firstName)
		{
			if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName) || firstName.Length < 2 || firstName.Length >= 30)
				return false;
			if (Regex.IsMatch(firstName, "[α-ωΑ-Ω]")) return true;
			return false;
		}
		/// <summary>
		/// Runs a check against the lastname
		/// </summary>
		/// <param name="lastName">The lastname to check</param>
		/// <returns>True if the supplied argument does not violate the application policy</returns>
		public static bool CheckLastName(string lastName)
		{
			if (string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName) || lastName.Length < 4 || lastName.Length >= 30)
				return false;
			if (Regex.IsMatch(lastName, "[α-ωΑ-Ω]")) return true;
			return false;
		}

		/// <summary>
		/// Runs a check against the IDCard
		/// </summary>
		/// <param name="IDCard">The IDCard to check</param>
		/// <returns>True if the supplied argument does not violate the application policy</returns>
		public static bool CheckIDCard(string IDCard)
		{
			//if (IDCard.Length != 8) return false;
			return Regex.IsMatch(IDCard, "^[Α-Ω]{2}\\d{6}$");
		}

		/// <summary>
		/// Runs a check against the employeeID
		/// </summary>
		/// <param name="employeeID">The employeeID to check</param>
		/// <returns>True if the supplied argument does not violate the application policy</returns>
		public static bool CheckEmployeeID(int employeeID)
		{
			return employeeID >= 0;
		}

		/// <summary>
		/// Runs a check against the password
		/// </summary>
		/// <param name="password">The password to check</param>
		/// <returns>True if the supplied argument does not violate the application policy</returns>
		public static bool CheckPassword(string password)
		{
			if (!Regex.IsMatch(password, ".{10,}")) return false;
			if (!Regex.IsMatch(password, ".*\\d+.*")) return false;
			if (!Regex.IsMatch(password, ".*[A-Z].*")) return false;
			return true;
		}

		/// <summary>
		/// Runs a check against the RoleID
		/// </summary>
		/// <param name="roleID">The roleID to check</param>
		/// <returns>True if the supplied argument does not violate the application policy</returns>
		public static bool CheckRoleID(int roleID)
		{
			return roleID > 0 && roleID < 4; //We do not allow other administrators
		}

		/// <summary>
		/// Runs a check against the phone number
		/// </summary>
		/// <param name="phoneNumber">The phone number to check</param>
		/// <returns>True if the supplied argument does not violate the application policy</returns>
		public static bool CheckPhoneNumber(string phoneNumber)
		{
			return Regex.IsMatch(phoneNumber, "^\\d{10}$");
		}

		/// <summary>
		/// Sanitizes the supplied argument for bad sql characters
		/// </summary>
		/// <param name="input">The input to check</param>
		/// <returns>The sanitized string</returns>
		public static string SanitizeInput(string input)
		{
			return input.Replace("'", "''");
		}
	}
}
