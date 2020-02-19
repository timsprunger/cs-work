import java.util.*;

public class bucketSort {	
    public static void main(String[] args) {
    	//Running Program
    	//java bucketSort numItemsInArray seedNumber
    	
    	if (args.length>0) {
    		Random seed = new Random();
    		
    		int[] integerArray = new int[ Integer.parseInt(args[0]) ];
    		seed.setSeed( Long.parseLong(args[1]) );
    		
    		for (int a=0; a<integerArray.length; a++) {
    			integerArray[a] = seed.nextInt(100);
    		}
    		
    		System.out.println("Original Array = " + Arrays.toString(integerArray) ); 
    		
    		int numBuckets = integerArray.length;
    		if (numBuckets > 9) {
    			System.out.println("Array Size Greater Than 10");
        		sort(integerArray, integerArray.length);
    		}
    		else {
    			System.out.println("Array Size Less Than 10");
        		sort(integerArray, 10);
    		}
    	}
    	//Default Array
    	else {
    		int[] arrayOfIntegers = {47, 85, 10, 45, 16, 34, 67, 80, 34, 4, 0, 99};
    		System.out.println("Original array = " + Arrays.toString(arrayOfIntegers));
    		sort(arrayOfIntegers, arrayOfIntegers.length);
    	}
    }
    
    private static void sort(int[] array, int numBuckets){
        // Create bucket array
    	@SuppressWarnings("unchecked")
    	List<Integer>[] buckets = new List[numBuckets];
        
        // Associate a list with each index in the bucket array         
        for(int i=0; i<numBuckets; i++){
            buckets[i] = new LinkedList<>();
        }
        
        // Assign numbers from array to the proper bucket by using hashing function
        for(int x=0; x<array.length; x++){
            buckets[ hash(array[x]) ].add( array[x] );
        }
        
        // Sort buckets
        for (int y=0; y<buckets.length; y++){
        	Collections.sort(buckets[y]);
        }
    
        int z=0;
        // Merge buckets to get sorted array
        for (int v=0; v<buckets.length; v++){
        	for (int n=0; n<buckets[v].size(); n++) {
        		array[z++] = buckets[v].get(n);
            }
        }
        
        //Display Sorted Array
        System.out.println("Sorted Array = " + Arrays.toString(array));
    }
    
    // A very simple hash function
    private static int hash(int number){
    	return number/10;
    }
}