// --- MAIN PROGRAM (VIDEO 68: YOUR FIRST CLASS) ---

// 1. Create objects from the class (the mold)
Node a = new Node(5);
Node b = new Node(8);
Node c = new Node(3);
Console.WriteLine("a.Value = " + a.Value);

// 2. Link them: each node points to the next one
a.Next = b;
b.Next = c;

// 3. Walk the chain, starting from the first node
Node? current = a;
while (current != null)
{
    Console.WriteLine("Value: " + current.Value);
    current = current.Next;
}

// 4. Two references, one object
Node same = b;
same.Value = 80;
Console.WriteLine("b.Value = " + b.Value);


// --- CLASSES DECLARATION AREA ---

// A node keeps a value and a reference to the next node
class Node
{
    public int Value;
    public Node? Next;

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}
