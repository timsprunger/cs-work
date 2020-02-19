//p8.java
//October 20, 2019
//Tim Sprunger
//This program uses a binary search algorithm to emulate a guessing game

import java.util.Scanner;
import java.lang.Math;

public class p8 {
	public static int LogBaseTwo(int x) {
		return (int) Math.ceil((Math.log(x) / Math.log(2)));
	}
	
	public static void main(String[] args) {
		Scanner scnr = new Scanner(System.in);
		
		System.out.print("Enter the largest number: ");
		int last = scnr.nextInt();
		
		int first = 1;
		int mid = (first + last) / 2;
		
		System.out.println("Pick a number between 1 and " + last + " but don't tell me");
		
		int numMaxGuesses = LogBaseTwo(last);
		System.out.println("I can guess your number in " + numMaxGuesses +  " guesses");
		
		int numGuesses = 1;
		boolean found = false;
		while ( (first != last) && !found ) {
			mid = (first + last) / 2;
			
			System.out.print("Guess " + numGuesses + ": Is your number " + mid + "? (y,n)");
			char yesNoCheck = scnr.next().charAt(0);
			if (yesNoCheck == 'y') {
				found = true;
				System.out.println("I was able to guess your number in " + numGuesses + " guesses");
			}
			else {
				System.out.print("Is your number higher or lower than " + mid + "? (h,l)");
				char lowerHigherCheck = scnr.next().charAt(0);
				
				if (lowerHigherCheck == 'h') {
					first = mid + 1;	
				}
				else {
					last = mid - 1;	
				}
				numGuesses++;
			}
		}		
		
		if (first == last) {
			mid = (first + last) / 2;
			
			System.out.print("Guess " + numGuesses + ": Is your number " + mid + "? (y,n)");
			char yesNoCheck = scnr.next().charAt(0);
			if (yesNoCheck == 'y') {
				found = true;
				System.out.println("I was able to guess your number in " + (numGuesses + 1) + " guesses");		
			}
			else {
				found = false;
				System.out.println("Input Error Detected. Please Try Again!");
			}
		}
		scnr.close();
	}
}
