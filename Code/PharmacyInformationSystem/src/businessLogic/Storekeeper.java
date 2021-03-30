package businessLogic;

import java.util.ArrayList;

public class Storekeeper extends User{

	/*Storekeeper's constructor*/
	public Storekeeper(String firstName, String lastName, String idCard, int employeeID, String username, String password,
			ArrayList<String> phoneNumbers) {
		super(firstName, lastName, idCard, employeeID, username, password,phoneNumbers);
	}
	
}
