package businessLogic;

import java.util.ArrayList;
import businessLogic.loginFunctionality.*;

public class Administrator extends User{

	private DatabaseHandler database;
	
	/*Admin's constructor*/
	public Administrator(String firstName, String lastName, String idCard, int employeeID, String username,
			String password, int roleID, ArrayList<String> phoneNumbers) {
		super(firstName, lastName, idCard, employeeID, username, password, roleID, phoneNumbers);
	}

	/*Setters n getters*/
	public DatabaseHandler getDatabase() {
		return database;
	}

	/*public void setDatabase(DatabaseHandler database) {
		this.database = database;
	}*/
	
	
	
}
