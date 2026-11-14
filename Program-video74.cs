// --- MAIN PROGRAM (VIDEO 74: TWO SUM, THE CODE) ---

int[] nums = { 3, 8, 4, 11, 6 };
int target = 10;

int[] answer = TwoSum(nums, target);
Console.WriteLine("Answer: [" + answer[0] + ", " + answer[1] + "]");

// Repeated values work too: check first, save after
int[] twins = TwoSum(new int[] { 5, 5 }, 10);
Console.WriteLine("Twins: [" + twins[0] + ", " + twins[1] + "]");


// --- FUNCTIONS DECLARATION AREA ---

// One pass: for each number, look for its complement
static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> seen = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int need = target - nums[i];
        if (seen.ContainsKey(need))
        {
            return new int[] { seen[need], i };
        }
        Console.WriteLine("need " + need + ": not seen");
        seen[nums[i]] = i;
    }
    return new int[0];
}
