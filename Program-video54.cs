// --- MAIN PROGRAM (VIDEO 54: JUMP SEARCH) ---

// 1. Sorted array: 16 numbers, 4 blocks of 4
int[] numbers = { 2, 5, 8, 12, 16, 23, 38, 41,
                  45, 56, 62, 71, 77, 84, 90, 99 };

// 2. Ask the user which number to find
Console.WriteLine("Enter the number to find:");
int target = int.Parse(Console.ReadLine());

// 3. Search and print the result
int position = JumpSearch(numbers, target);

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
static int JumpSearch(int[] arr, int target)
{
    int n = arr.Length;
    int jump = (int)Math.Sqrt(n);   // block size
    int start = 0;                  // block start
    int end = jump - 1;             // block end

    // Phase 1: jump block by block
    while (end < n)
    {
        Console.WriteLine("Jump to index " + end);
        if (arr[end] >= target)
        {
            break;                  // it is here
        }
        start = end + 1;
        end = end + jump;
    }

    if (end >= n)
    {
        end = n - 1;                // last block
    }

    // Phase 2: one by one inside the block
    for (int i = start; i <= end; i++)
    {
        Console.WriteLine("Check index " + i);
        if (arr[i] == target)
        {
            return i;               // found it
        }
        if (arr[i] > target)
        {
            break;                  // passed it
        }
    }

    return -1;                      // not found
}
