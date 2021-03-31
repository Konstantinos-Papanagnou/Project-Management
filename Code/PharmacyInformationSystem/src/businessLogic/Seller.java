package businessLogic;

import java.util.ArrayList;

public class Seller extends User{

	/*Seller's constructor*/
	public Seller(String firstName, String lastName, String idCard, int employeeID, String username,
			String password, int roleID, ArrayList<String> phoneNumbers) {
		super(firstName, lastName, idCard, employeeID, username, password, roleID, phoneNumbers);
	}
	
}
