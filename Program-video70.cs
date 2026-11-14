// --- MAIN PROGRAM (VIDEO 70: SEARCH AND REMOVE) ---

Node? head = null;
AddLast(1);
AddLast(5);
AddLast(8);
AddLast(3);
Print();

// 1. Search: walk until the value appears
Console.WriteLine("Contains 8? " + Contains(8));
Console.WriteLine("Contains 9? " + Contains(9));

// 2. Remove: unhook the node from the chain
Remove(8);
Print();
Remove(1);
Print();
Console.WriteLine("Remove 9? " + Remove(9));


// --- FUNCTIONS DECLARATION AREA ---

// Is the value in the list? O(n)
bool Contains(int value)
{
    Node? current = head;
    while (current != null)
    {
        if (current.Value == value)
        {
            return true;
        }
        current = current.Next;
    }
    return false;
}

// Removes the first node with that value
bool Remove(int value)
{
    if (head == null)
    {
        return false;
    }
    if (head.Value == value)
    {
        head = head.Next;
        return true;
    }
    Node current = head;
    while (current.Next != null)
    {
        if (current.Next.Value == value)
        {
            current.Next = current.Next.Next;
            return true;
        }
        current = current.Next;
    }
    return false;
}

// Adds a node at the end (video 69)
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

// Prints the chain (video 69)
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
