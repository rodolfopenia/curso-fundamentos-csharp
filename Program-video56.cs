// --- MAIN PROGRAM (VIDEO 56: HASH TABLE) ---

// 1. A table of 10 buckets; each bucket is a list
List<int>[] table = new List<int>[10];
for (int i = 0; i < table.Length; i++)
{
    table[i] = new List<int>();
}

// 2. Store the numbers
int[] numbers = { 23, 45, 12, 87, 56, 33 };
foreach (int number in numbers)
{
    Insert(table, number);
}

// 3. Ask the user which number to find
Console.WriteLine("Enter the number to find:");
int target = int.Parse(Console.ReadLine());

if (Contains(table, target))
{
    Console.WriteLine("Found " + target);
}
else
{
    Console.WriteLine("Not found");
}


// --- FUNCTIONS DECLARATION AREA ---

// The hash function: which bucket a number uses
static int Hash(int number)
{
    return number % 10;
}

// Adds a number to the end of its bucket
static void Insert(List<int>[] table, int number)
{
    int bucket = Hash(number);
    table[bucket].Add(number);
    Console.WriteLine(number + " -> " + bucket);
}

// Looks only inside the bucket of the target
static bool Contains(List<int>[] table, int target)
{
    int bucket = Hash(target);
    foreach (int item in table[bucket])
    {
        Console.WriteLine("Checking " + item);
        if (item == target)
        {
            return true;
        }
    }
    return false;
}
