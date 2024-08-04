// MergeSort Algorithm 
import java.util.Random;
public class Ass2_Q2 {
    // Main Function
    public static void main(String[] args) {
        // declare sizes of Arrays to be used
        int[] sizes = {500, 1000, 2000, 4000, 8000, 10000};
        // start from first towards end of sizes array
        for (int size : sizes) {
            // make three arrays for each case
            int[] bestCase = generateBestCaseArray(size);
            int[] worstCase = generateWorstCaseArray(size);
            int[] averageCase = generateRandomArray(size);

            long startTime = System.nanoTime();
            mergeSort (bestCase,0, bestCase.length - 1);
            long endTime = System.nanoTime();
            long bestDuration = endTime - startTime;
            System.out.println("Size of array being used with Integers: " + size);
            
             // function to check either our array is sorted or not by using customized isSorted function
            boolean isSorted1 = isSorted(bestCase );
            System.out.println("BestCase Array is sorted: " + isSorted1 + " for size: " + size); // Output: true
        
            
            // Convert duration from nanoseconds to seconds
            // here 1e9 is 10^9, as e represents with number being 10 and 9 as power
            double durationSecondBest = bestDuration / 1e9;
            // Best Case
            System.out.println("Best Case Duration: " + bestDuration + " ns");
            System.out.println("MergeSort Best Duration: " + durationSecondBest + "seconds");

            startTime = System.nanoTime();
            mergeSort(worstCase,0, worstCase.length - 1);
            endTime = System.nanoTime();
            long worstDuration = endTime - startTime;
            
            // function to check either our array is sorted or not by using customized isSorted function
            isSorted1 = isSorted(worstCase);
            System.out.println("WorstCase Array is sorted: " + isSorted1 + " for size: " + size); // Output: true
        
            
            // Convert duration from nanoseconds to seconds
            // here 1e9 is 10^9, as e represents with number being 10 and 9 as power
            double durationSecondWorst = worstDuration / 1e9;
            // Worst Case
            System.out.println("Worst Case Duration: " + worstDuration + " ns");
            System.out.println("MergeSort Worst Duration: " + durationSecondWorst + "seconds");

            startTime = System.nanoTime();
            mergeSort(averageCase,0, averageCase.length - 1);
            endTime = System.nanoTime();
            long averageDuration = endTime - startTime;
            
             // function to check either our array is sorted or not by using customized isSorted function
            isSorted1 = isSorted(averageCase);
            System.out.println("WorstCase Array is sorted: " + isSorted1 + " for size: " + size); // Output: true
        
            
            // Convert duration from nanoseconds to seconds
            // here 1e9 is 10^9, as e represents with number being 10 and 9 as power
            double durationSecondAverage = averageDuration / 1e9;
            // Average case
            System.out.println("Average Case Duration: " + averageDuration + " ns");
            System.out.println("MergeSort Average Duration: " + durationSecondAverage + "seconds");

             // println is used here for new line, better formatting for next N term 
            System.out.println();
            
            System.out.println("------------------");
        }
    }
    
    // Function to generate array with already sorted data 
    // so just give values from 0 upto size - 1
    public static int[] generateBestCaseArray(int size) {
        int[] dataset = new int[size];
        // for loop to iterate over indexes
        for (int indexArray = 0; indexArray <= size - 1; indexArray++) {
            dataset[indexArray] = indexArray;
        }
        return dataset;
    }
    // Function to generate worst case array by making integers in descending order 
    // like 10,9,8,5. Size is 10 , so 10-0 = 10 at 0th index, 10-1 = 9 at 1st index 
    public static int[] generateWorstCaseArray(int size) {
        int[] dataset = new int[size];
        for (int indexArray = 0; indexArray < size; indexArray++) {
            dataset[indexArray] = size - indexArray;
        }
        return dataset;
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
    
    // function to sort array using merge and divide and conquer technique
    public static void mergeSort(int[] array, int left, int right) {
        // In case left is less than right than find middle 
        if (left < right) {
            // Find the middle point
            int middle = (left + right) / 2;

            // Sort first and second halves
            mergeSort(array, left, middle);
            mergeSort(array, middle + 1, right);

            // Merge the sorted halves
            merge(array, left, middle, right);
        }
    }

    public static void merge(int[] array, int left, int middle, int right) {
        // Find sizes of two subarrays to be merged
        int sizeLeft = middle - left + 1;
        int sizeRight = right - middle;

        // Create temporary arrays
        int[] leftArray = new int[sizeLeft];
        int[] rightArray = new int[sizeRight];

        // Copy data to left and right temporary arrays
        for (int i = 0; i < sizeLeft; ++i)
            leftArray[i] = array[left + i];
        for (int j = 0; j < sizeRight; ++j)
            rightArray[j] = array[middle + 1 + j];

        // Merge the above left and right temporary  arrays
        int iter = 0, j = 0;
        int k = left;
        
        while ( iter < sizeLeft && j < sizeRight) {
            if (leftArray[iter] <= rightArray[j]) {
                array[k] = leftArray[iter];
                iter++;
            } else {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements of leftArray if any present
        while (iter < sizeLeft) {
            array[k] = leftArray[iter];
            iter++;
            k++;
        }

        // Copy remaining elements of rightArray if any present
        while (j < sizeRight) {
            array[k] = rightArray[j];
            j++;
            k++;
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
}
