import java.util.*;

/*
	p2.java	
	Tim Sprunger
	August 28, 2019
	calculates primes using Sieve of Eratosthenes and demonstrates command line arguments
	and methods

	1.  The maximum prime number that I was able to find using my program was 
		1,429,999,981. I was surprised and unsure why this number was not closer to 
		2,147,483,647 which is java's maximum value for integers at 32 bits.
		Even after adding the -Xmx3g command, I wasn't able to get very close to that
		expected value.  I was able to get slightly over 2,000,000,000 without getting
		errors.

	2.  Printing is the main factor limiting the performance of the program.  
	  	This is easily shown because if you enter an argument with a very large
	  	number, it is completed almost instantly with the print statement taken
	  	out. When you get into the hundreds of millions and billions, however, 
	  	longer delays start to be seen. Therefore, the biggest factor that 
	  	was making the program take a very long time to execute with large 
	  	numbers was because of the printing of hundreds of prime numbers.
		Calculating mulitple for loops also adds delays to the performance
		of the program.
	
	3.  The main factor that prevents this program from finding larger prime numbers
		is the variable type that is used for scanner input and command line input.  
		The program reaches its limit when the maximum number for the int variable 
		type in java.  Also, Java's virtual machine also has limits, which can 
		even cause errors before reaching an int's maximum value.  
*/

public class p2{
	public static void main(String[] args){
		Scanner scnr = new Scanner(System.in);
		int num = 0;

		if (args.length > 0){
			num = Integer.parseInt(args[0]);
		}
		else{
			System.out.print("Enter Maximum Value:");			
			num = scnr.nextInt();	
		}
		
		showPrimes(num);
		scnr.close();
	}


	public static void showPrimes(int N){
		boolean primeCheck[] = new boolean[N+1];
		primeCheck[0] = false;
		primeCheck[1] = false;
		
		for (int x=2; x<=N; x++){
			primeCheck[x] = true;
		}
			
		for (int i=2; i<=( Math.sqrt(N) ); i++){
			if (primeCheck[i]){
				for (int j=(i*i); j<=N; j+=i){
					primeCheck[j] = false;						
				}
			}
		}
		
		for (int z=2; z<=N; z++){
			if (primeCheck[z]){
				System.out.println(z);
			}
		}
	} 
}
