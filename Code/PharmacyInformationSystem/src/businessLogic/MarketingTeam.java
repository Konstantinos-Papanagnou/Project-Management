package businessLogic;

import java.util.ArrayList;

public class MarketingTeam  extends User{

	/*MarketingTeam's constructor*/
	public MarketingTeam(String firstName, String lastName, String idCard, int employeeID, String username, String password,
			ArrayList<String> phoneNumbers) {
		super(firstName, lastName, idCard, employeeID, username, password,phoneNumbers);
	}
	
}
