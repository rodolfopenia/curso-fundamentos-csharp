// --- MAIN PROGRAM (VIDEO 75: BINARY SEARCH, THE LOGIC) ---

int[] nums = { -1, 0, 3, 5, 9, 12 };

Console.WriteLine("Search 9: " + Search(nums, 9));
Console.WriteLine("Search 2: " + Search(nums, 2));


// --- FUNCTIONS DECLARATION AREA ---

// Halves the range until it finds target or runs out
static int Search(int[] nums, int target)
{
    int lo = 0;
    int hi = nums.Length - 1;
    while (lo <= hi)
    {
        int mid = lo + (hi - lo) / 2;
        Console.WriteLine("lo " + lo + ", mid " + mid + ", hi " + hi);
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
