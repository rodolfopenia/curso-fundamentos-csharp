// --- MAIN PROGRAM (VIDEO 69: LINKED LIST) ---

// The whole list is reached from one variable: head
Node? head = null;

AddLast(5);
AddLast(8);
AddLast(3);
Print();

AddFirst(1);
Print();
Console.WriteLine("Count: " + Count());


// --- FUNCTIONS DECLARATION AREA ---
// (no "static": they can use head)

// Adds a node at the start: O(1)
void AddFirst(int value)
{
    Node node = new Node(value);
    node.Next = head;
    head = node;
}

// Adds a node at the end: walks to the last one, O(n)
void AddLast(int value)
{
    Node node = new Node(value);
    if (head == null)
    {
        head = node;
        return;
    }
    Node current = head;
    while (current.Next != null)
    {
        current = current.Next;
    }
    current.Next = node;
}

// Prints the chain, following Next until null
void Print()
{
    string text = "";
    Node? current = head;
    while (current != null)
    {
        text = text + current.Value + " -> ";
        current = current.Next;
    }
    Console.WriteLine(text + "null");
}

// Counts the nodes
int Count()
{
    int count = 0;
    for (Node? n = head; n != null; n = n.Next)
    {
        count++;
    }
    return count;
}


// --- CLASSES DECLARATION AREA ---

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
