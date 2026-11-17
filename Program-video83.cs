// --- MAIN PROGRAM (VIDEO 83: QUEUE WITH TWO STACKS, THE LOGIC) ---

Stack<int> inbox = new Stack<int>();
Stack<int> outbox = new Stack<int>();

inbox.Push(1);
inbox.Push(2);
inbox.Push(3);
Console.WriteLine("Dequeue: " + Dequeue(inbox, outbox));
inbox.Push(4);
Console.WriteLine("Dequeue: " + Dequeue(inbox, outbox));
Console.WriteLine("Dequeue: " + Dequeue(inbox, outbox));
Console.WriteLine("Dequeue: " + Dequeue(inbox, outbox));


// --- FUNCTIONS DECLARATION AREA ---

// Pours inbox into outbox only when outbox is empty
static int Dequeue(Stack<int> inbox, Stack<int> outbox)
{
    if (outbox.Count == 0)
    {
        while (inbox.Count > 0)
        {
            int x = inbox.Pop();
            Console.WriteLine("  move " + x);
            outbox.Push(x);
        }
    }
    return outbox.Pop();
}
