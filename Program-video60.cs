// --- MAIN PROGRAM (VIDEO 60: STRINGBUILDER) ---
using System.Text;

// 1. Build a word piece by piece
StringBuilder sb = new StringBuilder();
sb.Append("HO");
sb.Append("LA");
Console.WriteLine(sb.ToString() + " (" + sb.Length + ")");

// 2. Unlike a string, it CAN change
sb[0] = 'J';
Console.WriteLine(sb.ToString());

// 3. Reverse a word without creating new strings
Console.WriteLine("Reversed: " + Reverse("HOLA"));


// --- FUNCTIONS DECLARATION AREA ---

// Returns a new string in reverse order
static string Reverse(string text)
{
    StringBuilder result = new StringBuilder(text.Length);
    for (int i = text.Length - 1; i >= 0; i--)
    {
        result.Append(text[i]);
    }
    return result.ToString();
}
