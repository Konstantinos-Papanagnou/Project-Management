package businessLogic;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
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
	
	/*Add new user*/
	public boolean insertUser(User user) throws SQLException {
		Connection con;
		Statement addUser;
    	ResultSet addResult;
    	
    	
    	addUser = con.createStatement();
    	String query = "INSERT INTO personnel " + user + ";";
    	addResult = addUser.executeQuery(query);
		return false;
	}
	
}
