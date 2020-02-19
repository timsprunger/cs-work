/*
	p3a.java
	Tim Sprunger
	This program includes two recursive functions.
	These functions include one to calculate powers and 
	another to calculate greatest common denominators.
 */

public class p3a {
	//MAIN START
	public static void main(String[] args) {
		//power test cases START
		System.out.println("Power Test Cases START");
		System.out.println( "2 to the power of 10 is " + power(2,10) );
		System.out.println( "10 to the power of 3 is " + power(10,3) );
		System.out.println( "2 to the power of 20 is " + power(2,20) );
		System.out.println( "10 to the power of 6 is " + power(10,6) );
		System.out.println( "2 to the power of 30 is " + power(2,30) );
		System.out.println( "10 to the power of 9 is " + power(10,9) );
		System.out.println("Power Test Cases END");
		//power test cases END
		
		System.out.println();
		
		//gcd test cases START
		System.out.println("GCD Test Cases START");
		System.out.println( "The greatest common denominator of 4 and 12 is " + gcd(12,4) );
		System.out.println( "The greatest common denominator of 100 and 250 is " + gcd(250,100) );
		System.out.println( "The greatest common denominator of 16 and 64 is " + gcd(64,16) );
		System.out.println( "The greatest common denominator of 123 and 3 is " + gcd(123,3) );
		System.out.println( "The greatest common denominator of 77 and 3 is " + gcd(77,3) );
		System.out.println("GCD Test Cases END");
		//gcd test cases END
	}
	//MAIN END

	//POWER FUNCTION START
	public static int power(int x, int y) {
		int result = 0;
		
		if (y == 0) {
			result = 1;
		}
		else if (y == 1) {
			result = x;
		}
		
		if (y>1) {
			result = x * ( power(x, y-1) );
		}
		
		return result;
	}
	//POWER FUNCTION END

	public static int gcd(int x, int y) {
		int gcd = 0;
		
		if (y == 0) {
			gcd = x;
		}
		else {
			gcd = gcd(y, x%y);
		}
		
		return gcd;
	}
}
