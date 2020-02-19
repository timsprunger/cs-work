import java.util.*;

public class bucketSortModified {	
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
    	//Default Array If No Command Line Arguments are Given
    	else {
    		int[] arrayOfIntegers = {47, 85, 10, 45, 16, 34, 67, 80, 34, 4, 0, 99};
    		System.out.println("Original array = " + Arrays.toString(arrayOfIntegers));
    		sort(arrayOfIntegers, arrayOfIntegers.length);
    	}
    }
    
    //PERFORM BUCKET SORT START
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
        
        // Merge buckets to get sorted array
        int z=0;
        for (int v=0; v<buckets.length; v++){
        	for (int n=0; n<buckets[v].size(); n++) {
        		array[z++] = buckets[v].get(n);
            }
        }
        
        //INSERTION SORT OF DATA
        insertionSort(array);
        
        //Display Sorted Array
        System.out.println("Sorted Array = " + Arrays.toString(array));
    }
    //PERFORM BUCKET SORT END

    
    //MODIFIED HASH FUNCTION START
    private static int hash(int number){
    	return number/10;
    }
    //MODIFIED HASH FUNCTION END

    //INSERTION SORT START
    private static int[] insertionSort(int[] data) {
        for (int i=1; i<data.length; i++)
        {
            //insert the next value
            int j=i;
            
            while (j>0 && data[j] < data[j-1]){
                int temp = data[j];
                data[j] = data[j-1];
                data[j-1] = temp;
                j--;
            }
        }
        return data;
    }
    //INSERTION SORT END

}


//MODIFICATIONS
	//BUCKET SORT IS AN O(N) SORTING ALGORITHM, BUT IS KNOWN TO HAVE 
	//FASTER SORTING COMPARED TO OTHER O(N) SORTING ALGORITHMS LIKE
	//MERGESORT OR QUICKSORT

	// #1  ADJUST HASH FUNCTION (By default, it divided the number by 10)
	//        CHANGED TO SQUARE ROOT HASH -- SQUARE ROOT OF NUMBER IS PLACED INTO RESULTING NODE

	// #2  ADDDED OPTION TO CREATE ARRAY OF SPECIFIC SIZE USING COMMAND LINE INPUT
	
	// #3  ADDDED OPTION TO FILL ARRAY WITH SEED VALUES USING COMMAND LINE INPUT

	// #4  PUT THE UNSORTED ELEMENTS OF THE BUCKETS BACK IN THE ORIGINAL ARRAY FIRST,
	//	   THEN RUN INSERTION SORT OVER THE COMPLETE ARRAY

	//BUCKET SORT LEARNING LINKS
		//https://www.youtube.com/watch?v=VuXbEb5ywrU
		//https://netjs.blogspot.com/2019/01/bucket-sort-program-in-java.html

