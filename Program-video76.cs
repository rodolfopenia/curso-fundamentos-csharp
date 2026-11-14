// --- MAIN PROGRAM (VIDEO 76: BINARY SEARCH, THE CODE) ---

int[] nums = { -1, 0, 3, 5, 9, 12 };

// 1. Every value must be found at its own index
bool allFound = true;
for (int k = 0; k < nums.Length; k++)
{
    if (Search(nums, nums[k]) != k)
    {
        allFound = false;
    }
}
Console.WriteLine("All found: " + allFound);

// 2. Missing values: before, between and after
Console.WriteLine("-5: " + Search(nums, -5));
Console.WriteLine("2: " + Search(nums, 2));
Console.WriteLine("20: " + Search(nums, 20));

// 3. Why mid = lo + (hi - lo) / 2
int a = 2000000000;
int b = 2100000000;
Console.WriteLine("(a + b) / 2 = " + (a + b) / 2);
Console.WriteLine("a + (b - a) / 2 = " + (a + (b - a) / 2));


// --- FUNCTIONS DECLARATION AREA ---

// LeetCode 704: position of target, or -1
static int Search(int[] nums, int target)
{
    int lo = 0;
    int hi = nums.Length - 1;
    while (lo <= hi)
    {
        int mid = lo + (hi - lo) / 2;
        if (nums[mid] == target)
        {
            return mid;
        }
        if (nums[mid] < target)
        {
            lo = mid + 1;
        }
        else
        {
            hi = mid - 1;
        }
    }
    return -1;
}
