// --- MAIN PROGRAM (VIDEO 82: VALID PARENTHESES, THE CODE) ---

string[] tests = { "()[]{}", "{[]}", "(]", "([)]", "]", "((" };
foreach (string s in tests)
{
    Console.WriteLine(s + " -> " + IsValid(s));
}


// --- FUNCTIONS DECLARATION AREA ---

// LeetCode 20: each closer must match the opener on top
static bool IsValid(string s)
{
    if (s.Length % 2 != 0)
    {
        return false;
    }
    Dictionary<char, char> pairs = new Dictionary<char, char>
    {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
    };
    Stack<char> stack = new Stack<char>();
    foreach (char c in s)
    {
        if (pairs.ContainsKey(c))
        {
            if (stack.Count == 0 || stack.Pop() != pairs[c])
            {
                return false;
            }
        }
        else
        {
            stack.Push(c);
        }
    }
    return stack.Count == 0;
}
