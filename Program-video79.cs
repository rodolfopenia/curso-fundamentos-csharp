// --- MAIN PROGRAM (VIDEO 79: VALID ANAGRAM, THE LOGIC) ---

Test("anagram", "nagaram");
Test("rat", "car");
Test("ab", "abc");


// --- FUNCTIONS DECLARATION AREA ---

// Same letters, same amounts: sorted, they look identical
static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }
    char[] a = s.ToCharArray();
    char[] b = t.ToCharArray();
    Array.Sort(a);
    Array.Sort(b);
    Console.WriteLine(new string(a) + " vs " + new string(b));
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] != b[i])
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
