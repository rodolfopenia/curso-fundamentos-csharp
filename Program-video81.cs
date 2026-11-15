// --- MAIN PROGRAM (VIDEO 81: VALID PARENTHESES, THE LOGIC) ---

Console.WriteLine("{[]} -> " + IsValid("{[]}"));
Console.WriteLine("([)] -> " + IsValid("([)]"));
Console.WriteLine("(( -> " + IsValid("(("));


// --- FUNCTIONS DECLARATION AREA ---

// Every closer must match the last opener still waiting
static bool IsValid(string s)
{
    Stack<char> stack = new Stack<char>();
    foreach (char c in s)
    {
        if (c == '(' || c == '[' || c == '{')
        {
            stack.Push(c);
        }
        else
        {
            if (stack.Count == 0 || !Matches(stack.Pop(), c))
            {
                return false;
            }
        }
        Console.WriteLine(c + " | " + string.Concat(stack.Reverse()));
    }
    return stack.Count == 0;
}

// True if the opener and the closer are the same type
static bool Matches(char open, char close)
{
    return (open == '(' && close == ')')
        || (open == '[' && close == ']')
        || (open == '{' && close == '}');
}
