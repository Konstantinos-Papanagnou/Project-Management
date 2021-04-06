package businessLogic;

import java.util.ArrayList;

public class MarketingTeam  extends User{

	/*MarketingTeam's constructor*/
	public MarketingTeam(String firstName, String lastName, String idCard, int employeeID, String username,
			String password, int roleID, ArrayList<String> phoneNumbers) {
		super(firstName, lastName, idCard, employeeID, username, password, roleID, phoneNumbers);
	}
	
}
