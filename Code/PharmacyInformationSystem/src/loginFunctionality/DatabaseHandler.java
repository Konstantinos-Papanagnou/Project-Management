package loginFunctionality;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class DatabaseHandler {
	
	private static Connection connection;//order to connect to sql
	private static String username="pasklid";
	private static String password="sPAqCRwt";
	private static String host="localhost";//servers ip
	private static String port="1521";//port
	private static String databaseName="xe";//database name
	
	/*Try to connect to DB*/
	public static void doConnect() throws ClassNotFoundException, SQLException {
            Class.forName("oracle.jdbc.driver.OracleDriver");
            String url = "jdbc:oracle:thin:@" + host + ":" + port + ":" + databaseName;
            connection = DriverManager.getConnection(url, username, password);
            System.out.println("Connection");
        
    }
	
	/*Try to disconnect from DB*/
    public static void doDisconnect() throws SQLException {
       
            connection.close();
            System.out.println("Disconnected!");
        
    }
	
    /**/
    public static boolean credentialCheck(String username, String password) throws SQLException {
    	boolean credential = false;
    	Statement searchUser;
    	ResultSet searchUserResult;
    	
    	
    		searchUser = connection.createStatement();
    		String query = "SELECT username, passphrase FROM personnel WHERE usrname=" + username + 
        			"AND passphrase=" + password + ";";
    		searchUserResult = searchUser.executeQuery(query);
    		if(searchUserResult.wasNull() == false) {
    			credential = true;
    		}
    	
    	return credential;
    }
    
}
