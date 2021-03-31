package businessLogic;

import java.util.ArrayList;

public class User {
	
	private String firstName;
	private String lastName;
	private String idCard;
	private int employeeID;
	private String username;
	private String password;
	private int roleID;
	private ArrayList<String> phoneNumbers = new ArrayList<String>();
	
	/*User's constructor*/
	public User(String firstName, String lastName, String idCard, int employeeID, String username, String password,
			int roleID, ArrayList<String> phoneNumbers) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.idCard = idCard;
		this.employeeID = employeeID;
		this.username = username;
		this.password = password;
		this.roleID = roleID;
		this.phoneNumbers = phoneNumbers;
	}
	
	/*Creating setters n getters for user's attributes*/
	public String getFirstName() {
		return firstName;
	}
	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}
	
	public String getLastName() {
		return lastName;
	}
	public void setLastName(String lastName) {
		this.lastName = lastName;
	}
	
	public String getIdCard() {
		return idCard;
	}
	public void setIdCard(String idCard) {
		this.idCard = idCard;
	}
	
	public int getEmployeeID() {
		return employeeID;
	}
	public void setEmployeeID(int employeeID) {
		this.employeeID = employeeID;
	}
	
	public String getUsername() {
		return username;
	}
	public void setUsername(String username) {
		this.username = username;
	}
	
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	
	public int getRoleID() {
		return roleID;
	}
	public void setRoleID(int roleID) {
		this.roleID = roleID;
	}
	
	public ArrayList<String> getPhoneNumbers() {
		return phoneNumbers;
	}
	public void setPhoneNumbers(ArrayList<String> phoneNumbers) {
		this.phoneNumbers = phoneNumbers;
	}
		
	
}
