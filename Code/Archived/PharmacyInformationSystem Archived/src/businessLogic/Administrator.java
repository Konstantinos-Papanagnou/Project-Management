package businessLogic;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Random;

import businessLogic.loginFunctionality.DatabaseHandler;
import businessLogic.loginFunctionality.Hashing;
import businessLogic.loginFunctionality.Sanitizer;

public class Administrator extends User{

	private DatabaseHandler database;
	
	/*Admin's constructor*/
	public Administrator(String firstName, String lastName, String idCard, int employeeID, String username,
			String password, int roleID, ArrayList<String> phoneNumbers) throws ClassNotFoundException, SQLException {
		super(firstName, lastName, idCard, employeeID, username, password, roleID, phoneNumbers);
		database = new DatabaseHandler();
	}

	/*Setters n getters*/
	public DatabaseHandler getDatabase() {
		return database;
	}
	
	/*Add new user*/
	public boolean insertUser(User user) throws SQLException, ClassNotFoundException {
		//Setup the connection if it does not already exist
		if(database == null)
			database = new DatabaseHandler();
		Statement addUser;
    	ResultSet addResult;
    	//get the connection
    	addUser = database.getConnection().createStatement();
    	String query = "INSERT INTO personnel VALUES(" + user.getEmployeeID() + "," + user.getFirstName() + ","
    		+ user.getLastName() + "," + user.getIdCard() + "," + user.getUsername() + "," + user.getPassword() +
    		"," + user.getRoleID() + ");";
    	// insert the new user and report back with the result
    	addResult = addUser.executeQuery(query);
		return addResult.rowInserted();
	}

	/*Modify user*/
	public boolean modifyUser(User user) throws SQLException, ClassNotFoundException {
		//Setup the connection if it does not already exist
		if(database == null)
			database = new DatabaseHandler();
		Statement modUser;
    	ResultSet modResult;
    	//get the connection
    	modUser = database.getConnection().createStatement();
    	String query;
    	//If there's no password supplied don't update the password to nothing.
    	if(user.getPassword() == null || user.getPassword() == "")
    		query = "UPDATE personnel SET firstName=" + Sanitizer.sanitizeInput(user.getFirstName()) + ",lastName=" + Sanitizer.sanitizeInput(user.getLastName()) +
    		",idCard=" + user.getIdCard() + ",username=" + user.getUsername() +
    		",roleID" + user.getRoleID() + 
    		"WHERE employeeID=" + user.getEmployeeID() + ";";
    	else
    		query = "UPDATE personnel SET firstName=" + user.getFirstName() + ",lastName=" + user.getLastName() +
    		",idCard=" + user.getIdCard() + ",username=" + user.getUsername() +
    		",passphrase=" + Hashing.hashing(user.getPassword()) + ",roleID" + user.getRoleID() + 
    		"WHERE employeeID=" + user.getEmployeeID() + ";";
    	//update the password and report back with the result
    	modResult = modUser.executeQuery(query);
		return modResult.rowUpdated();
	}
	
	/*Remove user*/
	public boolean deleteUser(int employeeID) throws SQLException, ClassNotFoundException {
		//Setup the connection if it does not already exist
		if(database == null)
			database = new DatabaseHandler();
		Statement deleteUser;
    	ResultSet deleteResult;
    	//prepei na elexei ti einai o user oste na svinei oles tis eggrafes sxetika me ayton apo olous touw pinakes
    	deleteUser = database.getConnection().createStatement();
    	String query = "DELETE FROM personnel WHERE employeeID=" + employeeID + ";";
    	//delete the user and all his data and report back with the result
    	deleteResult = deleteUser.executeQuery(query);
		return deleteResult.rowDeleted();
	}
	
	/*Get all users*/
	public ArrayList<User> getAllUsers() throws ClassNotFoundException, SQLException{
		//Setup the connection if it does not already exist
		if(database == null)
			database = new DatabaseHandler();
		ArrayList<User> users = new	ArrayList<User>();
		try {
			//first get all user data
			Statement searchUser = database.getConnection().createStatement();
			String q = "SELECT * FROM personnel;";
			ResultSet rs = searchUser.executeQuery(q);		
			// while there are users
			while (rs.next()) {
				//get their phoneNumbers as well
				ArrayList<String> phoneNumbers = new ArrayList<String>();
				String q2 = "SELECT * FROM phone WHERE username=" + rs.getString(4) + ";";
				ResultSet rs2 = searchUser.executeQuery(q2);
				//while there are phone numbers
				while (rs2.next()) {
					phoneNumbers.add(rs.getString(1)); //retrieve them in a list
				}
				//add the user with his registered phone numbers
				users.add(new User(rs.getString(1),
					rs.getString(2), rs.getString(3),
					rs.getInt(0), rs.getString(4),
					null, rs.getInt(6), phoneNumbers));
            }
			// and then return the users array.
			return users;
		} catch (SQLException e) {
			//if we hit any sort of exception return null for the front end to handle 
			return null;
		}
	}
	
	/*Creates a unique username for a user*/
	public String generateUsername(String firstname, String lastname) throws SQLException, ClassNotFoundException {
		//Setup the connection if it does not already exist
		if(database == null)
			database = new DatabaseHandler();
		//Sanitize firstname and last name just to be safe
		String generated = Sanitizer.sanitizeInput(firstname.substring(0,2) + lastname.substring(0,4));
		Statement findUsernameIfExists;
    	ResultSet Result;
    	findUsernameIfExists = database.getConnection().createStatement();
    	//Loop until we find a username that does not exist.
    	while(true) {
    	//query the database for the generated username
        String query = "SELECT username FROM personnel WHERE username= " + generated + ";";
    	Result = findUsernameIfExists.executeQuery(query);
    	//if that username is not occupied then return it to the callee
    	if(Result.wasNull())
    		return generated.toLowerCase(); // we only return if we find a unique username
    	else
    	{
    		//otherwise mess with it.
    		Random rand = new Random();
    		//pick a random position to switch the character
    		int position = rand.nextInt(6);
    		//pick a random character to switch with
    		char c = (char)(rand.nextInt(26) + 'a');
    		char[] cs = generated.toCharArray();
    		//change the character from a random position with a new random character
    		cs[position] = c;
    		generated = new String(cs);
    	}
    	//and then check again if that exists.
    	}
	}
	
	//Destructor to disconnect from the database
    protected void finalize(){
    	try {
			database.doDisconnect();
		} catch (SQLException e) {
		}
    }
}
