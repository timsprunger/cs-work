/*
 	p3b.java
 	Tim Sprunger
 	Fall 2019
 	This program includes a recursive function which determines whether or not
 	a string is a palindrome and returns either true or false.
 */

public class p3b {
	public static void main(String[] args) {
		String testCaseStrings[] = {"Mado Gonzalez", "googoog", "kayak", "cs325"};
		
		for (int z=0; z<testCaseStrings.length; z++) {
			if ( palindrome(testCaseStrings[z]) == true ) {
				System.out.println("The string \"" + testCaseStrings[z] + "\" is a palindrome.");
			}
			else {
				System.out.println("The string \"" + testCaseStrings[z] + "\" is not a palindrome.");
			}
		}
    }

	public static boolean palindrome(String s) {
        if(s.length() == 0 || s.length() == 1) {
            return true; 
        }
       
        if(s.charAt(0) == s.charAt(s.length()-1)) {
        	return palindrome(s.substring(1, s.length()-1));
        }
        else {
        	return false;
        }
	}
}
