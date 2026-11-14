// --- MAIN PROGRAM (VIDEO 73: TWO SUM, THE LOGIC) ---

int[] nums = { 3, 8, 4, 11, 6 };
int target = 10;

// Which two positions add up to target?
int[] answer = TwoSumBrute(nums, target);
Console.WriteLine("Answer: [" + answer[0] + ", " + answer[1] + "]");


// --- FUNCTIONS DECLARATION AREA ---

// Tries every pair: each i with every j after it
static int[] TwoSumBrute(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            Console.WriteLine(nums[i] + " + " + nums[j]);
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }
    return new int[0];
}
