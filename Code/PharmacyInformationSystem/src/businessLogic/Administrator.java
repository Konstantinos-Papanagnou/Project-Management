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
		return addResult.rowInserted();
	}

	/*Add new user*/
	public boolean modifyUser(User user) throws SQLException {
		Connection con;
		Statement modUser;
    	ResultSet modResult;
    	
    	modUser = con.createStatement();
    	String query = "UPDATE personnel SET " + user + "WHERE employeeID=" + user.getEmployeeID() + ";";
    	modResult = modUser.executeQuery(query);
		return modResult.rowUpdated();
	}
	
	/*Add new user*/
	public boolean deleteUser(int employeeID) throws SQLException {
		Connection con;
		Statement deleteUser;
    	ResultSet deleteResult;
    	//prepei na elexei ti einai o user oste na svinei oles tis eggrafes sxetika me ayton apo olous touw pinakes
    	deleteUser = con.createStatement();
    	String query = "DELETE FROM personnel WHERE employeeID=" + employeeID + ";";
    	deleteResult = deleteUser.executeQuery(query);
		return deleteResult.rowDeleted();
	}
}
