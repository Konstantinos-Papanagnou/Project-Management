package businessLogic.loginFunctionality;

/* Unique exception that happens when the Authentication Failed. */
public class AuthenticationFailure extends Exception{

	/*Constructor*/
	public AuthenticationFailure(String message) {
		super(message);
	}
	
}
