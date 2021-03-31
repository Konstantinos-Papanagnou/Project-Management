package businessLogic.loginFunctionality;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import businessLogic.User;

public class DatabaseHandler {
	
	private Connection connection;//order to connect to sql
	private String username="pasklid";
	private String password="sPAqCRwt";
	private String host="localhost";//servers ip
	private String port="1521";//port
	private String databaseName="xe";//database name
	
	public DatabaseHandler() {
		try {
			doConnect();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public Connection getConnection() {
		return this.connection;
	}
	
	/*Try to connect to DB*/
	public void doConnect() throws ClassNotFoundException, SQLException {
            Class.forName("oracle.jdbc.driver.OracleDriver");
            String url = "jdbc:oracle:thin:@" + host + ":" + port + ":" + databaseName;
            connection = DriverManager.getConnection(url, username, password);
           // System.out.println("Connection");
        
    }
	
	/*Try to disconnect from DB*/
    public void doDisconnect() throws SQLException {
       
            connection.close();
           // System.out.println("Disconnected!");
        
    }
	
    /*Get user
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
    
    /*Check user's credentials*/
    public boolean credentialCheck(String username, String password) throws SQLException {
    	Statement searchUser;
    	ResultSet searchUserResult;
    	
    	
    	searchUser = connection.createStatement();
    	String query = "SELECT username, passphrase FROM personnel WHERE username=" + username + 
        		"AND passphrase=" + password + ";";
    	searchUserResult = searchUser.executeQuery(query);
    	
    	return !searchUserResult.wasNull();
    }
    
}
