package businessLogic;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Random;

import businessLogic.loginFunctionality.DatabaseHandler;
import businessLogic.loginFunctionality.Sanitizer;

public class Administrator extends User{

	private DatabaseHandler database;
	
	/*Admin's constructor*/
	public Administrator(String firstName, String lastName, String idCard, int employeeID, String username,
			String password, int roleID, ArrayList<String> phoneNumbers) {
		super(firstName, lastName, idCard, employeeID, username, password, roleID, phoneNumbers);
		database = new DatabaseHandler();
	}

	/*Setters n getters*/
	public DatabaseHandler getDatabase() {
		return database;
	}
	
	/*Add new user*/
	public boolean insertUser(User user) throws SQLException {
		if(database == null)
			database = new DatabaseHandler();
		Statement addUser;
    	ResultSet addResult;
    
    	addUser = database.getConnection().createStatement();
    	String query = "INSERT INTO personnel " + user + ";";
    	addResult = addUser.executeQuery(query);
		return addResult.rowInserted();
	}

	/*Modify user*/
	public boolean modifyUser(User user) throws SQLException {
		if(database == null)
			database = new DatabaseHandler();
		Statement modUser;
    	ResultSet modResult;
    	
    	modUser = database.getConnection().createStatement();
    	String query = "UPDATE personnel() SET " + user + "WHERE employeeID=" + user.getEmployeeID() + ";";
    	modResult = modUser.executeQuery(query);
		return modResult.rowUpdated();
	}
	
	/*Remove user*/
	public boolean deleteUser(int employeeID) throws SQLException {
		if(database == null)
			database = new DatabaseHandler();
		Statement deleteUser;
    	ResultSet deleteResult;
    	//prepei na elexei ti einai o user oste na svinei oles tis eggrafes sxetika me ayton apo olous touw pinakes
    	deleteUser = database.getConnection().createStatement();
    	String query = "DELETE FROM personnel WHERE employeeID=" + employeeID + ";";
    	deleteResult = deleteUser.executeQuery(query);
		return deleteResult.rowDeleted();
	}
	
	/*Get all users*/
	public ArrayList<User> getAllUsers(){
		if(database == null)
			database = new DatabaseHandler();
		ArrayList<User> users = new	ArrayList<User>();
		try {
			Statement searchUser = database.getConnection().createStatement();
			String q = "SELECT * FROM personnel;";
			ResultSet rs = searchUser.executeQuery(q);		
			while (rs.next()) {
				
				ArrayList<String> phoneNumbers = new ArrayList<String>();
				String q2 = "SELECT * FROM phone WHERE username=" + rs.getString(4) + ";";
				ResultSet rs2 = searchUser.executeQuery(q);
				while (rs2.next()) {
					phoneNumbers.add(rs.getString(1));
				}
				users.add(new User(rs.getString(1),
					rs.getString(2), rs.getString(3),
					rs.getInt(0), rs.getString(4),
					null, rs.getInt(6), phoneNumbers));
            }

			return users;
		} catch (SQLException e) {
			return null;
		}
	}
	
	public String generateUsername(String firstname, String lastname) throws SQLException {
		if(database == null)
			database = new DatabaseHandler();
		String generated = Sanitizer.sanitizeInput(firstname.substring(0,2) + lastname.substring(0,4));
		Statement deleteUser;
    	ResultSet Result;
    	deleteUser = database.getConnection().createStatement();
    	while(true) {
        String query = "SELECT username FROM personnel WHERE username= " + generated + ";";
    	Result = deleteUser.executeQuery(query);
    	if(Result.wasNull())
    		return generated;
    	else
    	{
    		Random rand = new Random();
    		int position = rand.nextInt(6);
    		char c = (char)(rand.nextInt(26) + 'a');
    		char[] cs = generated.toCharArray();
    		cs[position] = c;
    		generated = new String(cs);
    	}
    	}
	}
	
    protected void finalize(){
    	try {
			database.doDisconnect();
		} catch (SQLException e) {
		}
    }
}
