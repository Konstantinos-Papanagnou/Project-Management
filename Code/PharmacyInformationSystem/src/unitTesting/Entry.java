package unitTesting;
import businessLogic.loginFunctionality.*;
public class Entry {
	public static void main(String[] args) {
		System.out.println("Let's begin some testing...");
		//Call your other classes here to see your results
		boolean first = Sanitizer.checkIDCard("AM520145");
		boolean second = Sanitizer.checkIDCard("AS526455");
		if (first && !second)
			System.out.println("PASSED");
		else 
			System.out.println("FAILED");
	}
}
