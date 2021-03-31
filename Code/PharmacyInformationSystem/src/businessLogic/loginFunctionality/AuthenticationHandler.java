package businessLogic.loginFunctionality;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

import  businessLogic.*;


public class AuthenticationHandler {

	private int attemptCounter;

	/*Authentication handler's constructor*/
	public AuthenticationHandler() {
		attemptCounter = 0;
	}

	/*Creating setters n getters*/
	public int getAttemptCounter() {
		return attemptCounter;
	}
	
	/*Gets user data from database
	private User getUserData(String username) {
		username = Sanitizer.sanitize(username);
		Statement searchUser;
		ResultSet rs;
		Connection con;
		searchUser = con.createStatement();
		String q = "SELECT * FROM personnel WHERE username=" + username + ";";
		rs = searchUser.executeQuery(q);
		//User user = new User();
		return user;
	}*/
	
	/*Authenticates user*/
	public User authenticateUser(String username, String password){
		  username = Sanitizer.sanitize(username);
		  String hash = Hashing.hashing(password);
		  DatabaseHandler handler = new DatabaseHandler();
		  if(!handler.credentialCheck(username, password))
		    throw new AuthenticationFailure("Username or password is not correct");
		  User user = handler.getUserData(username);
		  switch(user.getRoleID()){
		    case 0:
		      return (Administrator)user;
		      break;
		    case 1:
		    	return (Storekeeper)user;
		    case 2:
		    	return (Seller)user;
		    	break;
		    case 3:
		    	return (MarketingTeam)user;
		    	break;
		    
		    }
		} 
	
}
