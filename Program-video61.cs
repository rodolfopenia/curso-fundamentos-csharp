// --- MAIN PROGRAM (VIDEO 61: LIST) ---

// 1. A List starts empty
List<int> scores = new List<int>();
Show("Empty", scores);

// 2. Add five scores, one by one
int[] values = { 15, 8, 20, 12, 17 };
foreach (int v in values)
{
    scores.Add(v);
    Show("Add " + v, scores);
}

// 3. Read and change by index, like an array
Console.WriteLine("First: " + scores[0]);
scores[1] = 9;

// 4. Walk the whole list
int total = 0;
foreach (int s in scores)
{
    total = total + s;
}
Console.WriteLine("Total: " + total);


// --- FUNCTIONS DECLARATION AREA ---

// Shows how many items it has and how many fit
static void Show(string label, List<int> list)
{
    Console.Write(label + " -> Count: " + list.Count);
    Console.WriteLine(", Capacity: " + list.Capacity);
}
