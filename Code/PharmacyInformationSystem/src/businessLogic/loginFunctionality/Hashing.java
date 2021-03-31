package businessLogic.loginFunctionality;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.security.SecureRandom;

public class Hashing {

	 public static String hashing(String password) {
		 String hashed = null;
	        try {
	        	MessageDigest md = MessageDigest.getInstance("SHA-256");
	            md.update(new byte[] {50,10,20,30,60,50,40,80,90});
	            byte[] bytes = md.digest(password.getBytes());
	            StringBuilder sb = new StringBuilder();
	            for(int i=0; i< bytes.length ;i++)
	            {
	                sb.append(Integer.toString((bytes[i] & 0xff) + 0x100, 16).substring(1));
	            }
	            hashed = sb.toString();
	        } 
	        catch (NoSuchAlgorithmException e) 
	        {
	            e.printStackTrace();
	        }    
		 return hashed;
	}
	
}
