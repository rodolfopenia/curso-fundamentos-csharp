// --- MAIN PROGRAM (VIDEO 84: QUEUE WITH TWO STACKS, THE CODE) ---

MyQueue q = new MyQueue();
q.Push(1);
q.Push(2);
Console.WriteLine("Peek: " + q.Peek());
Console.WriteLine("Pop: " + q.Pop());
q.Push(3);
Console.WriteLine("Pop: " + q.Pop());
Console.WriteLine("Pop: " + q.Pop());
Console.WriteLine("Empty: " + q.Empty());


// --- CLASS DECLARATION AREA ---

// LeetCode 232: a FIFO queue built from two LIFO stacks
public class MyQueue
{
    private Stack<int> inbox = new Stack<int>();
    private Stack<int> outbox = new Stack<int>();

    public void Push(int x)
    {
        inbox.Push(x);
    }

    public int Pop()
    {
        Move();
        return outbox.Pop();
    }

    public int Peek()
    {
        Move();
        return outbox.Peek();
    }

    public bool Empty()
    {
        return inbox.Count == 0 && outbox.Count == 0;
    }

    // Pours inbox into outbox, only when outbox is empty
    private void Move()
    {
        if (outbox.Count == 0)
        {
            while (inbox.Count > 0)
            {
                outbox.Push(inbox.Pop());
            }
        }
    }
}
