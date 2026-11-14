// --- MAIN PROGRAM (VIDEO 65: QUEUE) ---

// 1. A line at the bank: the first one in is the first out
Queue<string> line = new Queue<string>();
line.Enqueue("Ana");
line.Enqueue("Beto");
line.Enqueue("Caro");
Console.WriteLine("Count: " + line.Count);

// 2. Peek: who is next, without removing them
Console.WriteLine("Next: " + line.Peek());

// 3. Dequeue: serve the first one
Console.WriteLine("Served: " + line.Dequeue());
line.Enqueue("Dani");

// 4. Serve everyone, in order of arrival
while (line.Count > 0)
{
    Console.WriteLine("Served: " + line.Dequeue());
}

// 5. Dequeue on an empty queue is an error
// line.Dequeue();   // InvalidOperationException!
