// Shell Sorting Algorithm
import java.util.Random;

public class Ass2_Q1 {
    public static void main(String[] args) {
        int[] sizes = {500,1000,2000,4000,8000,10000};
        // using for each loop to iterate over each size in above sizes array having 500-8000 
        for (int size : sizes) {
            int[] array1 = generateRandomArray(size);
            
            
            // Below lines of code is used to caculate running time of code in miliseconds
            
            // startTime when function will start execution
            long startTime = System.nanoTime();
            // call function 
            shellSortGap4xplus2(array1);
            // again use nanoTime function to check end time
            long endTime = System.nanoTime();
            // take difference between both times
            long duration1 = endTime - startTime;
            
            // Convert duration from nanoseconds to seconds
            // here 1e9 is 10^9, as e represents with number being 10 and 9 as power
            double durationSeconds = duration1 / 1e9;
            
            System.out.println("Size of array being used with random Integers: " + size);
            System.out.println("Gap (4x + 2) Duration: " + duration1 + " nanoseconds");
            System.out.println("Gap (4x + 2) Duration: " + durationSeconds + "seconds");
            
            // function to check either our array is sorted or not by using customized isSorted function
            boolean isSorted1 = isSorted(array1);
            System.out.println("SortedArray is sorted: " + isSorted1 + " for size: " + size); // Output: true
        
            // println is used here for new line, better formatting for next N term 
            System.out.println();
            
            array1 = generateRandomArray(size);
            
            // Below lines of code is used to caculate running time of code in miliseconds
            
            // startTime when function will start execution
            startTime = System.nanoTime();
            // call function 
            shellSortGap2powerKplus1(array1);
            // again use nanoTime function to check end time
            endTime = System.nanoTime();
            // take difference between both times
            duration1 = endTime - startTime;
            
            // Convert duration from nanoseconds to seconds
            // here 1e9 is 10^9, as e represents with number being 10 and 9 as power
            durationSeconds = duration1 / 1e9;
            
            System.out.println("Size of array being used with random Integers: " + size);
            System.out.println("Gap (2^k + 1) Duration: " + duration1 + " nanoseconds");
            System.out.println("Gap (2^k + 1) Duration: " + durationSeconds + "seconds");
            
            // function to check either our array is sorted or not by using customized isSorted function
            isSorted1 = isSorted(array1);
            System.out.println("SortedArray is sorted: " + isSorted1 + " for size: " + size); // Output: true
        
            // println is used here for new line, better formatting for next N term 
            System.out.println();
            
            System.out.println("------------------");
            
            
            
        }
    }
    // function to check either array is sorted 
     public static boolean isSorted(int[] array) {
         // iterate over array by comparing each two adjacent elements
         // 1st index element with 0th index
         // 1st index element with 2nd index
         // 2nd index element with 3rd index
         
         // Incrementing index starting from 1 upto size of array - 1.
        for (int indexArray = 1; indexArray <= array.length - 1 ; indexArray++) {
            // In case previous element is greater than current element, so array is not sorted
            if (array[indexArray - 1] > array[indexArray]) {
                // exit from function using return false as boolean
                return false;
            }
        }
        // array is sorted and exiting by return with boolean value true
        return true;
    }
    
    
    // function to generate array datasets with given size but with Random Integers ranging 0 to 40000
    public static int[] generateRandomArray(int size) {
        // Random class 
        Random rand = new Random();
        
        int[] dataset = new int[size];
        
        for (int indexArray = 0; indexArray <= size-1 ; indexArray++) {
            dataset[indexArray] = rand.nextInt(40000);
        }
        return dataset;
    }
    
    // Function to sort according to 4x+2 as gap with shell sequence
    // ShellSort using 4x+2 as gap sequence
    // Sorting here is based on ascending wise like 1,2,3,4 from 4,2,3,1 unsorted type
    public static void shellSortGap4xplus2(int[] array) {
        // Get array length
        int n = array.length;
        // Starting value of x as -1/4 as 4 (-1/4) + 2 will be 1 that will help to compare adjacent
        // elements
        double x = -0.25; // Starting with x = -1/4
        // Starting value is 0 
        int h = 0 ;
        
        int[] gaps = new int[n/2]; // Maximum number of gaps
        
        
        // default element is -20 
        for(int i = 0; i <= (n/2) -1; i++){
            gaps[i] = -20;
        }
        
        int incrementing = 0;
        
        // This while loop will generate gaps until h is less than n/2
        while (h < n/2 ) {
            h = (int) (4 * x + 2);
            
            gaps[incrementing ]  = h;
            
            // increment of 50 as for large dataset is suitable 
            x+=50;
            
            incrementing++;
            
        }
        // Now we have to move from end of gap array to start upto number 1
        int iter = ((n/2) - 1);
        
        // iterate till starting element
        while(iter>=0){
            // as there is gap 
            if (gaps[iter] != -20 ){
                
            int gap = gaps[iter];
            // iterate from gap until n
            for (int outer = gap; outer < n; outer++) {
                // compare element at gap like 4th with -4 that is 0 like that making sequence
                for (int inner  = outer; inner  >= gap && array[inner] < array[inner  - gap]; inner -= gap) {
                    // swap element element
                    swap(array, inner, inner  - gap);
                }
            }
            
            }
            // decrement for next gap
            iter--;
        }
        
    }
       
    
    public static void shellSortGap2(int[] array) {
        int n = array.length;
        for (int gap = n / 2; gap > 0; gap /= 2) {
            for (int i = gap; i < n; i++) {
                for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap) {
                    swap(array, j, j - gap);
                }
            }
        }
    }
    
    // Function to swap array elements 
    public static void swap(int[] array, int i, int j) {
        // Using calculations
        // i=5 , j= 3
        array[i] = array[i] + array[j]; // i = 8
        array[j] = array[i] - array[j]; // j = 5 , i = 8
        array[i] = array[i] - array[j]; // i = 3 , j = 5
    }
    
    // Sorting with 2^k + 1
    // ShellSort using -> 2^k +1 Papernov & Stasevich, 1965[10], k is 1,2,3.. so on
   // Sorting here is based on ascending wise like 1,2,3,4 from 4,2,3,1 unsorted type
    
    
      public static int power(int base, int exponent){
    // result for power like 2^2 is 4, so 4 will be here as example
    int result = 1;
    for (int iter = 0; iter  < exponent; iter ++) {
         result *= base;
    }
    
    return result;
    }
    
    // Function to sort according to 4x+2 as gap with shell sequence
    public static void shellSortGap2powerKplus1(int[] array) {
        // Get array length
        int n = array.length;
        // Starting value of x as -1/4 as 4 (-1/4) + 2 will be 1 that will help to compare adjacent
        // elements
        int k = 1; // Starting with k = 0
        // Starting value is 0 
        int h = 0 ;
        
        int[] gaps = new int[n/2]; // Maximum number of gaps
        
        
        // default element is -20 
        for(int i = 0; i <= (n/2) -1; i++){
            gaps[i] = -20;
        }
        
        int incrementing = 1;
        
        // start with 1 then 3,5,9,17,33,65 so on
        gaps[0]  = incrementing;
        
        // This while loop will generate gaps until h is less than n/2
        while (h < n/2 ) {
            h =  power(2, k) + 1;
        
            
            gaps[incrementing ]  = h;
            
            // increment of 1 in this sequence
            k+=1;
            
            incrementing++;
            
        }
        // Now we have to move from end of gap array to start upto number 1
        int iter = ((n/2) - 1);
        
        // iterate till starting element
        while(iter>=0){
            // as there is gap 
            if (gaps[iter] != -20 ){
                
            int gap = gaps[iter];
            // iterate from gap until n
            for (int outer = gap; outer < n; outer++) {
                // compare element at gap like 4th with -4 that is 0 like that making sequence
                for (int inner  = outer; inner  >= gap && array[inner] < array[inner  - gap]; inner -= gap) {
                    // swap element element
                    swap(array, inner, inner  - gap);
                }
            }
            
            }
            // decrement for next gap
            iter--;
        }
        
    }
     
}
