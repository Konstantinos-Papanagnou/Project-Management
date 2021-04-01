package businessLogic.loginFunctionality;

public abstract class Sanitizer {

	/* Returns true if the firstname is not null or empty or whitespace, or has a length of at least 2 characters and is not longer than 30 characters. */
	public static boolean checkFirstName(String firstName) {
		if (firstName.equals("") || firstName == null || firstName.replaceAll(" ","").equals("") || firstName.length() < 2 || firstName.length() >= 30)
			return false;
		return true;
	}
	
	/* Returns true if the surname is not null or empty or whitespace, or has a length of at least 4 characters and is not longer than 30 characters*/
	public static boolean checkLastName(String lastName) {
		if (lastName.equals("") || lastName == null || lastName.replaceAll(" ","").equals("") || lastName.length() < 4 || lastName.length() >= 30)
			return false;
		return true;
	}
	
	/* Returns true if the id card matches a regex of 2 characters followed by 6 numbers */
	public static boolean checkIDCard(String IDCard) {
		if(IDCard.length() != 8) return false;
		return IDCard.matches("[A-Z]{2}\\d{6}");
	}
	
	/* returns true if the employeeID is valid (>0) */
	public static boolean checkEmployeeID(int employeeID) {
		return employeeID > 0;
	}
	
	/* Returns true if the password is at least 10 characters long, contains at least one digit and has at least one Uppercase character */
	/* Basically it enforces password policy*/
	public static boolean checkPassword(String password) {
		if(!password.matches(".{10,}")) return false;
		if(!password.matches(".*\\d+.*")) return false;
		if(!password.matches(".*[A-Z].*")) return false;
		return true;
	}
	
	/* Returns true if the number specified is within a range of 0-3*/
	public static boolean checkRoleID(int roleID) {
		return roleID >=0 && roleID < 4;
	}
	
	/* Returns true if the phone number matches a regex with 10 digits */
	public static boolean checkPhoneNumber(String phoneNumber) {
		return phoneNumber.matches("\\d{10}");
	}
	
	/* Remove all the ' symbols from the input to avoid sql injections */
	public static String sanitizeInput(String input) {
		return input.replaceAll("'", "");
	}
	
}
