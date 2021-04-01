package businessLogic.loginFunctionality;

import java.sql.SQLException;

import businessLogic.User;

public class AuthenticationHandler {

	private DatabaseHandler handler;

	/*Authentication handler's constructor*/
	public AuthenticationHandler() {
		handler = new DatabaseHandler();
	}

	/*Authenticates user*/
	public User authenticateUser(String username, String password) throws AuthenticationFailure{
		// sanitize the username
		username = Sanitizer.sanitizeInput(username);
		// no need to sanitize the password, we just hash it.
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
