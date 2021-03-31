package businessLogic.loginFunctionality;

import java.sql.SQLException;

import businessLogic.User;

public class AuthenticationHandler {

	private int attemptCounter;
	private DatabaseHandler handler;

	/*Authentication handler's constructor*/
	public AuthenticationHandler() {
		attemptCounter = 0;
		handler = new DatabaseHandler();
	}

	/*Creating n getters*/
	public int getAttemptCounter() {
		return attemptCounter;
	}
	
	/*Authenticates user*/
	public User authenticateUser(String username, String password) throws AuthenticationFailure{
		  username = Sanitizer.sanitizeInput(username);
		  String hash = Hashing.hashing(password);
		  try {
			if(!handler.credentialCheck(username, hash))
			    throw new AuthenticationFailure("Username or password is not correct");
		} catch (SQLException e) {
			throw new AuthenticationFailure("Your database is corrupted or offline");
		}
		return handler.getUserData(username);
	}
	
    protected void finalize(){
    	try {
			handler.doDisconnect();
		} catch (SQLException e) {
		}
    }
	
}
