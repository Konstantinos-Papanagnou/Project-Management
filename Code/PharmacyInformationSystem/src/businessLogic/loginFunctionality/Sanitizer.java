package businessLogic.loginFunctionality;

public abstract class Sanitizer {

	public static boolean checkFirstName(String firstName) {
		if (firstName.equals("") || firstName == null || firstName.replaceAll(" ","").equals("") || firstName.length() < 2 || firstName.length() >= 30)
			return false;
		return true;
	}
	
	public static boolean checkLastName(String lastName) {
		if (lastName.equals("") || lastName == null || lastName.replaceAll(" ","").equals("") || lastName.length() < 2 || lastName.length() >= 30)
			return false;
		return true;
	}
	
	public static boolean checkIDCard(String IDCard) {
		if(IDCard.length() != 8) return false;
		return IDCard.matches("[A-Z]{2}\\d{6}");
	}
	
	public static boolean checkEmployeeID(int employeeID) {
		return employeeID > 0;
	}
	
	public static boolean checkPassword(String password) {
		if(!password.matches(".{10,}")) return false;
		if(!password.matches(".*\\d+.*")) return false;
		if(!password.matches(".*[A-Z].*")) return false;
		return true;
	}
	
	public static boolean checkRoleID(int roleID) {
		return roleID >=0 && roleID < 4;
	}
	
	public static boolean checkPhoneNumber(String phoneNumber) {
		return phoneNumber.matches("\\d{10}");
	}
	
	public static String sanitizeInput(String input) {
		return input.replaceAll("'", "");
	}
	
}
