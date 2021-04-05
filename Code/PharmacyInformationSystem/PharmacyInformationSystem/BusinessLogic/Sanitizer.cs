using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic
{
    public abstract class Sanitizer
    {

		/* Returns true if the firstname is not null or empty or whitespace, or has a length of at least 2 characters and is not longer than 30 characters. */
		public static bool CheckFirstName(string firstName)
		{
			if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName) || firstName.Length < 2 || firstName.Length >= 30)
				return false;
			return true;
		}

		/* Returns true if the surname is not null or empty or whitespace, or has a length of at least 4 characters and is not longer than 30 characters*/
		public static bool CheckLastName(string lastName)
		{
			if (string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName) || lastName.Length < 4 || lastName.Length >= 30)
				return false;
			return true;
		}

		/* Returns true if the id card matches a regex of 2 characters followed by 6 numbers */
		public static bool CheckIDCard(string IDCard)
		{
			//if (IDCard.Length != 8) return false;
			return Regex.IsMatch(IDCard, "^[A-Z]{2}\\d{6}$");
		}

		/* returns true if the employeeID is valid (>0) */
		public static bool CheckEmployeeID(int employeeID)
		{
			return employeeID >= 0;
		}

		/* Returns true if the password is at least 10 characters long, contains at least one digit and has at least one Uppercase character */
		/* Basically it enforces password policy*/
		public static bool CheckPassword(string password)
		{
			if (!Regex.IsMatch(password, ".{10,}")) return false;
			if (!Regex.IsMatch(password, ".*\\d+.*")) return false;
			if (!Regex.IsMatch(password, ".*[A-Z].*")) return false;
			return true;
		}

		/* Returns true if the number specified is within a range of 0-3*/
		public static bool CheckRoleID(int roleID)
		{
			return roleID >= 0 && roleID < 4;
		}

		/* Returns true if the phone number matches a regex with 10 digits */
		public static bool CheckPhoneNumber(string phoneNumber)
		{
			return Regex.IsMatch(phoneNumber, "^\\d{10}$");
		}

		/* Remove all the ' symbols from the input to avoid sql injections */
		public static string SanitizeInput(string input)
		{
			return input.Replace("'", "''");
		}
	}
}
