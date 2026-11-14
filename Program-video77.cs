// --- MAIN PROGRAM (VIDEO 77: VALID PALINDROME, THE LOGIC) ---

using System.Text;

string[] tests = { "A Santa at NASA", "race a car", " " };
foreach (string s in tests)
{
    string clean = Clean(s);
    Console.WriteLine("\"" + clean + "\" -> " + IsMirror(clean));
}


// --- FUNCTIONS DECLARATION AREA ---

// Step 1: keep only letters and digits, in lowercase
static string Clean(string s)
{
    StringBuilder sb = new StringBuilder();
    foreach (char c in s)
    {
        if (char.IsLetterOrDigit(c))
        {
            sb.Append(char.ToLower(c));
        }
    }
    return sb.ToString();
}

// Step 2: each char must match its mirror
static bool IsMirror(string t)
{
    for (int i = 0; i < t.Length / 2; i++)
    {
        if (t[i] != t[t.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}
