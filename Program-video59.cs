// --- MAIN PROGRAM (VIDEO 59: STRINGS INSIDE) ---

// 1. A string is a sequence of characters
string word = "HOLA";
Console.WriteLine("Length: " + word.Length);

// 2. Each character has an index
Console.WriteLine("First: " + word[0]);
Console.WriteLine("Last: " + word[word.Length - 1]);

// 3. Each character is a number
Console.WriteLine("Code of H: " + (int)word[0]);

// 4. Walk it backwards
Console.WriteLine("Reversed: " + Reverse(word));

// 5. A string cannot change (immutable)
// word[0] = 'J';   // compile error!
string other = "J" + word.Substring(1);
Console.WriteLine(word + " / " + other);


// --- FUNCTIONS DECLARATION AREA ---

// Returns a new string in reverse order
static string Reverse(string text)
{
    string result = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        result = result + text[i];
    }
    return result;
}
