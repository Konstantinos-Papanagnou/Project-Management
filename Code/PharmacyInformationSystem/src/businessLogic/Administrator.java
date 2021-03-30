package businessLogic;

import java.util.ArrayList;

public class Administrator extends User{

	/*Admin's constructor*/
	public Administrator(String firstName, String lastName, String idCard, int employeeID, String username, String password,
			ArrayList<String> phoneNumbers) {
		super(firstName, lastName, idCard, employeeID, username, password,phoneNumbers);
	}

	
	
}
