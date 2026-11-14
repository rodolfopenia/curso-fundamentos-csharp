// --- MAIN PROGRAM (VIDEO 63: STACK) ---

// 1. A stack of plates: the last one in is the first out
Stack<int> plates = new Stack<int>();
plates.Push(1);
plates.Push(2);
plates.Push(3);
Console.WriteLine("Count: " + plates.Count);

// 2. Peek: look at the top without removing it
Console.WriteLine("Top: " + plates.Peek());

// 3. Pop: take from the top until it is empty
while (plates.Count > 0)
{
    int plate = plates.Pop();
    Console.WriteLine("Pop: " + plate);
}

// 4. Pop on an empty stack is an error
// plates.Pop();   // InvalidOperationException!

// 5. Real use: undo the last actions
Stack<string> history = new Stack<string>();
history.Push("write Hola");
history.Push("bold");
history.Push("delete line");
Console.WriteLine("Undo: " + history.Pop());
Console.WriteLine("Undo: " + history.Pop());
Console.WriteLine("Last action: " + history.Peek());
