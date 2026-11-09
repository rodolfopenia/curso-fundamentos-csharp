// --- MAIN PROGRAM (VIDEO 52: BINARY SEARCH) ---

// 1. Sorted array: binary search needs order
int[] numbers = { 3, 5, 8, 9, 12, 15, 20 };

// 2. Ask the user which number to find
Console.WriteLine("Enter the number to find:");
int target = int.Parse(Console.ReadLine());

// 3. Search and print the result
int position = BinarySearch(numbers, target);

if (position != -1)
{
    Console.WriteLine("Found at index " + position);
}
else
{
    Console.WriteLine("Not found");
}


// --- FUNCTIONS DECLARATION AREA ---

// Returns the index of target, or -1 if missing
static int BinarySearch(int[] arr, int target)
{
    int low = 0;
    int high = arr.Length - 1;

    while (low <= high)
    {
        int mid = low + (high - low) / 2;
        Console.WriteLine("Checking index " + mid);

        if (arr[mid] == target)
        {
            return mid;           // found it
        }
        else if (arr[mid] < target)
        {
            low = mid + 1;        // look right
        }
        else
        {
            high = mid - 1;       // look left
        }
    }

    return -1;                    // low > high
}
