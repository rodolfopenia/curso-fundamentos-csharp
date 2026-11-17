// --- MAIN PROGRAM (VIDEO 85: REVERSE LINKED LIST, THE LOGIC) ---

Node head = new Node(1);
head.Next = new Node(2);
head.Next.Next = new Node(3);
head.Next.Next.Next = new Node(4);

Print(head);
Node? reversed = Reverse(head);
Print(reversed);


// --- FUNCTIONS DECLARATION AREA ---

// Flips every arrow, one node at a time
static Node? Reverse(Node? head)
{
    Node? prev = null;
    Node? curr = head;
    while (curr != null)
    {
        Node? next = curr.Next;
        curr.Next = prev;
        prev = curr;
        curr = next;
        Console.WriteLine("  flipped " + prev.Value);
    }
    return prev;
}

// Prints the values from head to null
static void Print(Node? head)
{
    string text = "";
    for (Node? n = head; n != null; n = n.Next)
    {
        text += n.Value + " -> ";
    }
    Console.WriteLine(text + "null");
}

// One node: a value and a reference to the next one
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
