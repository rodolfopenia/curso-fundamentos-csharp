// --- MAIN PROGRAM (VIDEO 66: CIRCULAR QUEUE) ---

// The queue lives in an array; front = first, count = size
int[] items = new int[4];
int front = 0;
int count = 0;

Enqueue(10);
Enqueue(20);
Enqueue(30);
Console.WriteLine("Dequeue: " + Dequeue());
Console.WriteLine("Dequeue: " + Dequeue());

// End of the array reached: the queue wraps around
Enqueue(40);
Enqueue(50);
Enqueue(60);
Enqueue(70);
Console.WriteLine("Count: " + count + ", front: " + front);

while (count > 0)
{
    Console.WriteLine("Dequeue: " + Dequeue());
}


// --- FUNCTIONS DECLARATION AREA ---
// (no "static": they can use items, front and count)

// Adds a value at the end of the queue
void Enqueue(int value)
{
    if (count == items.Length)
    {
        Console.WriteLine("Full! " + value + " not added");
        return;
    }
    int rear = (front + count) % items.Length;
    items[rear] = value;
    count++;
}

// Takes the value at the front of the queue
int Dequeue()
{
    int value = items[front];
    front = (front + 1) % items.Length;
    count--;
    return value;
}
