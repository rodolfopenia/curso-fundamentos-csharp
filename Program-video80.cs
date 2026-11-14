// --- MAIN PROGRAM (VIDEO 80: VALID ANAGRAM, THE CODE) ---

Test("anagram", "nagaram");
Test("rat", "car");
Test("aab", "abb");


// --- FUNCTIONS DECLARATION AREA ---

// LeetCode 242: +1 for s, -1 for t, then every count must be 0
static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }
    int[] count = new int[26];
    for (int i = 0; i < s.Length; i++)
    {
        count[s[i] - 'a']++;
        count[t[i] - 'a']--;
    }
    foreach (int c in count)
    {
        if (c != 0)
        {
            return false;
        }
    }
    return true;
}

// Prints both words and the answer
static void Test(string s, string t)
{
    Console.WriteLine(s + ", " + t + " -> " + IsAnagram(s, t));
}
