import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

/*
 * p6.java
 * Fall 2019
 * Tim Sprunger
 * This program converts String to double using Java Collection Stack and Queue
 */
public class p6 {

	public static void main(String[] args) {
		//test cases - add x3 additional cases here
		test("6", 6.0);
		test("7,000,000", 7000000.0);
		test("  $$$7 000 000 ", 7000000.0);
		test("$5,678.13  ", 5678.13);
		test("$0.25", 0.25);
		test("  -$.25", -0.25);
		test("-8.96", -8.96);	
		test("$1,000,000", 1000000.0);		
		test("-.01", -.01);
		test("-$5.00", -5.0);
	}//main

	private static double toDouble(String a) {
		double answer = 0.0;
		
		Stack<Integer> s = new Stack<Integer>();
		Queue<Integer> q = new LinkedList<Integer>();
		
		boolean decimalFound = false; //*** may or may not use this approach
		boolean negative = false; //*** may or may not use this approach
		
		//*** add code here ***		
		
		//ADD VALUES TO STACK AND QUEUE
		for (int x=0; x<a.length(); x++) {
			if (decimalFound == false) {
				if (a.charAt(x) == '-') {
					negative = true;
				}
				else if (Character.isDigit(a.charAt(x))) {
					s.push(Character.getNumericValue(a.charAt(x)));
				}
				else if (a.charAt(x) == '.') {
					decimalFound = true;
				}
			}
			else if (decimalFound == true) {
				if (Character.isDigit(a.charAt(x))) {
					q.add(Character.getNumericValue(a.charAt(x)));
				}
			}
		}	
				
		int stackMultiplier = 1;
		int queueDivider = 10;
		int wholeNumber = 0;
		double decimalNumber = 0.0;
				
		while (!s.isEmpty()) {
			wholeNumber += (s.peek() * stackMultiplier);
			stackMultiplier *= 10;
			s.pop();
		}
		
		while(!q.isEmpty()) {
			decimalNumber += ( Double.valueOf(q.peek()) / Double.valueOf(queueDivider) );
			queueDivider *= 10;
			q.remove();
		}
				
		answer = wholeNumber;
				
		if ( (decimalFound == true) && (decimalNumber > 0) ) {
			answer += decimalNumber;
		}
		
		if (negative == true) {
			answer = -answer;
		}
		
		return answer;
	}//main
	
	
	//test method
	private static void test(String s, double expected)
	{
		double actual = toDouble(s);
		
		if ( actual == expected)
			System.out.printf("Passed: %15s => %15f\n", s, actual);
		else
			System.out.printf(" Error: %15s => %15f  Expected: %15f\n", s, actual, expected);
	}	
}//class