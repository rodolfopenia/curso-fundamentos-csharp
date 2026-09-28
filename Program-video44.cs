// --- PROGRAM MAIN EXECUTION ---

int[] data = { 9, 2, 12, 5, 7 };

// Array.Sort(data); // <- We avoid the native method to learn the logic behind the wheel!
SelectionSort(data);

// Print the sorted array using a simple loop
for (int i = 0; i < data.Length; i++)
{
    Console.Write(data[i] + " ");
}
Console.WriteLine();


// --- FUNCTIONS DECLARATION AREA (ALGORITHMS) ---

static void SelectionSort(int[] arr)
{
    int n = arr.Length;

    // 1. One by one move boundary of unsorted subarray
    for (int i = 0; i < n - 1; i++)
    {
        // Find the minimum element in unsorted array
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j; // Update index of the lowest value
            }
        }

        // 2. Swap the found minimum element with the first element
        int temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;
    }
}
