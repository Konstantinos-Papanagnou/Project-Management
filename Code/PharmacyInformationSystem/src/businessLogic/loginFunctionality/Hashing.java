package businessLogic.loginFunctionality;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

public class Hashing {
	/* Hashes the string supplied (Usually it's a password) */
	public static String hashing(String password) {
		String hashed = null;
	    try {
	    	//pick the algorithm
	        MessageDigest md = MessageDigest.getInstance("SHA-256");
	        //make a static salt
	        md.update(new byte[] {50,10,20,30,60,50,40,80,90});
	        //hash the password
	        byte[] bytes = md.digest(password.getBytes());
	        //retrieve a string out of the bytes
	        StringBuilder sb = new StringBuilder();
	        for(int i=0; i< bytes.length ;i++)
	        {
	            sb.append(Integer.toString((bytes[i] & 0xff) + 0x100, 16).substring(1));
	        }
	        hashed = sb.toString();
	        //return the hash
	        return hashed;
	    } 
	    catch (NoSuchAlgorithmException e) 
	    {
	        e.printStackTrace();
	        //return null if something failed
	        return null;
	    }    
	}
	
}
