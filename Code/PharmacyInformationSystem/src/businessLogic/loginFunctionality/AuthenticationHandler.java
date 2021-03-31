package businessLogic.loginFunctionality;

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
	
	/*Creating methods
	public User getUserData(String username) {
		User ur;
		return ur;
		
	}
	*/
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
		    	return (Shopkeeper)user;
		    	break;
		    case 2:
		    	return (Seller)user;
		    	break;
		    case 3:
		    	return (MarketingTeam)user;
		    	break;
		    
		    }
		} 
	
}
