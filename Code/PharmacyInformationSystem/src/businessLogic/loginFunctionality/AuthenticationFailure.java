package businessLogic.loginFunctionality;

public class AuthenticationFailure extends Throwable{

	private String message;
	
	/*Constructor*/
	public AuthenticationFailure(String message) throws Exception {
		super();
		this.message = message;
		throw new Exception(message);
	}
	
	/*Setter n Getters*/
	public String getMessage() {
		return message;
	}

	public void setMessage(String message) {
		this.message = message;
	}
	
}
