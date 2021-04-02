package businessLogic.loginFunctionality;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import businessLogic.User;

public class DatabaseHandler {
	
	private Connection connection;//order to connect to sql
	private String username="pasklid";
	private String password="sPAqCRwt";
	private String host="localhost";//servers ip
	private String port="1521";//port
	private String databaseName="xe";//database name
	
	//Constructor that makes a connection to the database on the fly
	public DatabaseHandler() throws ClassNotFoundException, SQLException {
		doConnect();
	}
	
	public Connection getConnection() {
		return this.connection;
	}
	
	/*Try to connect to DB*/
	public void doConnect() throws ClassNotFoundException, SQLException {
            Class.forName("oracle.jdbc.driver.OracleDriver");
            String url = "jdbc:oracle:thin:@" + host + ":" + port + ":" + databaseName;
            connection = DriverManager.getConnection(url, username, password);        
    }
	
	/*Try to disconnect from DB*/
	public void doDisconnect() throws SQLException {
        connection.close();
    }
	
    /*Returns the user data of a specified user to the front end*/
	public User getUserData(String username) {
    	User user = null;
    	username = Sanitizer.sanitizeInput(username);
		try {
			// fetch user data from the database.
			Statement searchUser = connection.createStatement();
			String q = "SELECT * FROM personnel WHERE username='" + username + "';";
			ResultSet rs = searchUser.executeQuery(q);		
			while (rs.next()) {
				user = new User(rs.getString(1),
					rs.getString(2), rs.getString(3),
					rs.getInt(0), rs.getString(4),
					null, rs.getInt(6), null);
            }
			// fetch user registered phone numbers from the database
			q = "SELECT * FROM phone WHERE username='" + username + "';";
			rs = searchUser.executeQuery(q);
			ArrayList<String> phones = new ArrayList<String>();
			while (rs.next()) {
				phones.add(rs.getString(1));
			}
			user.setPhoneNumbers(phones);
			//and return the user data
			return user;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			return null;
		}

	}
	
    public void showCustomers() {
        Statement searchStatement;
        ResultSet searchResultSet;
        try {
            searchStatement = connection.createStatement();
            String query = "SELECT * FROM userRole";
            searchResultSet = searchStatement.executeQuery(query);
            while (searchResultSet.next()) {
                String role = searchResultSet.getString("roleID");
                String description = searchResultSet.getString("roleDescription");

                System.out.println("ID: " + role + " DESCRIPTION: " + description);
            }
            searchResultSet.close();
            searchStatement.close();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }
    
    /*Returns true if the authentication succeeded and false if the authentication failed*/
	boolean credentialCheck(String username, String password) throws SQLException {
    	
		Statement searchUser;
    	ResultSet searchUserResult;
    	
    	
    	searchUser = connection.createStatement();
    	String q = "SELECT * FROM personnel WHERE username = '" + username+"' "
    			+ " AND passphrase = '" + password + "'" ;
    	searchUserResult = searchUser.executeQuery(q);
    	return searchUserResult.next();
    }

    
}
