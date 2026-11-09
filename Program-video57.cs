// --- MAIN PROGRAM (VIDEO 57: TERNARY SEARCH) ---

// 1. Sorted array of 10 numbers
int[] numbers = { 3, 7, 12, 18, 25,
                  31, 40, 46, 52, 60 };

// 2. Ask the user which number to find
Console.WriteLine("Enter the number to find:");
int target = int.Parse(Console.ReadLine());

// 3. Search and print the result
int position = TernarySearch(numbers, target);

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
static int TernarySearch(int[] arr, int target)
{
    int low = 0;
    int high = arr.Length - 1;

    while (low <= high)
    {
        int third = (high - low) / 3;
        int m1 = low + third;
        int m2 = high - third;
        Console.WriteLine("Cuts at " + m1 + " and " + m2);

        if (arr[m1] == target) return m1;
        if (arr[m2] == target) return m2;

        if (target < arr[m1])
        {
            high = m1 - 1;          // left third
        }
        else if (target > arr[m2])
        {
            low = m2 + 1;           // right third
        }
        else
        {
            low = m1 + 1;           // middle third
            high = m2 - 1;
        }
    }

    return -1;                      // not found
}
