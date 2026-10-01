// --- PROGRAM MAIN EXECUTION ---

int[] prices = new int[4];

// 1. Interactive loop to populate grocery prices from terminal
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Enter product price:");
    prices[i] = int.Parse(Console.ReadLine());
}

// 2. Invoke the Bubble Sort engine
BubbleSort(prices);

Console.WriteLine("\n--- SORTED PRICES REPORT ---");

// 3. Print the final ordered results to screen
for (int i = 0; i < prices.Length; i++)
{
    Console.Write(prices[i] + " ");
}
Console.WriteLine();


// --- FUNCTIONS DECLARATION AREA (ALGORITHMS) ---

static void BubbleSort(int[] arr)
{
    int n = arr.Length;

    // Outer loop controls the maximum number of passes through memory
    for (int i = 0; i < n - 1; i++)
    {
        // Inner loop controls adjacent pair comparisons and swaps
        for (int j = 0; j < n - i - 1; j++)
        {
            // If current item is greater than adjacent item, perform swap
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
