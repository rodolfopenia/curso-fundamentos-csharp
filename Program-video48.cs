using System;
using System.Diagnostics; // Required for high-precision hardware Stopwatch

// --- PROGRAM MAIN EXECUTION ---

// 1. Initialize an array of 10,000 items and fill it with random numbers
int[] largeData = new int[10000];
Random random = new Random();

for (int i = 0; i < largeData.Length; i++)
{
    largeData[i] = random.Next(1, 100000); // Numbers between 1 and 100,000
}

// 2. Start the hardware timer
Stopwatch watch = Stopwatch.StartNew();

// 3. Invoke Quick Sort passing the massive array and its true boundaries
QuickSort(largeData, 0, largeData.Length - 1);

// 4. Stop the hardware timer immediately after execution
watch.Stop();

// 5. Print the execution benchmark report clearly to the console
Console.WriteLine("--- QUICK SORT BENCHMARK REPORT ---");
Console.WriteLine("Total items sorted: " + largeData.Length);
Console.WriteLine("Execution Time: " + watch.ElapsedMilliseconds + " ms");


// --- FUNCTIONS DECLARATION AREA (ALGORITHMS) ---

static void QuickSort(int[] arr, int low, int high)
{
    if (low < high)
    {
        // Find pivot index and rearrange physical slots elements
        int pivotIndex = Partition(arr, low, high);

        // Recursive call for the left subarray (elements smaller than pivot)
        QuickSort(arr, low, pivotIndex - 1);

        // Recursive call for the right subarray (elements larger than pivot)
        QuickSort(arr, pivotIndex + 1, high);
    }
}

static int Partition(int[] arr, int low, int high)
{
    int pivot = arr[high]; // Choosing the last element as pivot
    int i = (low - 1); // Index of smaller element

    for (int j = low; j < high; j++)
    {
        if (arr[j] < pivot)
        {
            i++;
            // Swap elements using temporary variable technique
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    // Swap the pivot element with the correct position element
    int temp2 = arr[i + 1];
    arr[i + 1] = arr[high];
    arr[high] = temp2;

    return i + 1; // Return the exact pivot index
}
