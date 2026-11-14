// --- MAIN PROGRAM (VIDEO 78: VALID PALINDROME, THE CODE) ---

string[] tests = { "A Santa at NASA", "race a car", " ", "0P" };
foreach (string s in tests)
{
    Console.WriteLine("\"" + s + "\" -> " + IsPalindrome(s));
}


// --- FUNCTIONS DECLARATION AREA ---

// Two pointers on the original text: no copy, O(1) memory
static bool IsPalindrome(string s)
{
    int left = 0;
    int right = s.Length - 1;
    while (left < right)
    {
        if (!char.IsLetterOrDigit(s[left]))
        {
            left++;
        }
        else if (!char.IsLetterOrDigit(s[right]))
        {
            right--;
        }
        else
        {
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            left++;
            right--;
        }
    }
    return true;
}
