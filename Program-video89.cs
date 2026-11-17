// --- MAIN PROGRAM (VIDEO 89: BACKTRACKING) ---

int[] nums = { 1, 2, 3 };
List<int> path = new List<int>();
bool[] used = new bool[nums.Length];
Permute(nums, path, used);


// --- FUNCTIONS DECLARATION AREA ---

// Choose, explore, undo: every order of nums
static void Permute(int[] nums, List<int> path, bool[] used)
{
    if (path.Count == nums.Length)
    {
        Console.WriteLine(string.Join(" ", path));
        return;
    }
    for (int i = 0; i < nums.Length; i++)
    {
        if (used[i]) continue;
        used[i] = true;                    // choose
        path.Add(nums[i]);
        Permute(nums, path, used);         // explore
        path.RemoveAt(path.Count - 1);     // undo
        used[i] = false;
    }
}
