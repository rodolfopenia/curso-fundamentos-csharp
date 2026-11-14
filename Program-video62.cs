// --- MAIN PROGRAM (VIDEO 62: LIST OPERATIONS) ---

List<int> scores = new List<int> { 15, 9, 20, 12 };
Print("Start", scores);

// 1. Insert in the middle: everything after it moves
scores.Insert(1, 30);
Print("Insert(1, 30)", scores);

// 2. Search: look one by one
Console.WriteLine("Contains 20? " + scores.Contains(20));
Console.WriteLine("IndexOf 12: " + scores.IndexOf(12));
Console.WriteLine("IndexOf 99: " + scores.IndexOf(99));

// 3. Remove: everything after it moves back
scores.Remove(9);
Print("Remove(9)", scores);
scores.RemoveAt(0);
Print("RemoveAt(0)", scores);


// --- FUNCTIONS DECLARATION AREA ---

// Prints every item of the list in one line
static void Print(string label, List<int> list)
{
    string text = string.Join(", ", list);
    Console.WriteLine(label + ": " + text);
}
