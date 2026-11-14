// --- MAIN PROGRAM (VIDEO 64: OUR OWN STACK) ---

// The stack lives in an array; top = how many there are
int[] items = new int[4];
int top = 0;

Push(5);
Push(8);
Push(3);
Console.WriteLine("Count: " + top + ", Peek: " + Peek());

Console.WriteLine("Pop: " + Pop());
Push(7);
Push(1);
Console.WriteLine("Count: " + top + ", Peek: " + Peek());

// The array is full: one more Push is rejected
Push(9);

while (top > 0)
{
    Console.WriteLine("Pop: " + Pop());
}


// --- FUNCTIONS DECLARATION AREA ---
// (no "static": these functions can use items and top)

// Puts a value on top
void Push(int value)
{
    if (top == items.Length)
    {
        Console.WriteLine("Full! " + value + " not added");
        return;
    }
    items[top] = value;
    top++;
}

// Takes the value on top
int Pop()
{
    top--;
    return items[top];
}

// Looks at the top without removing it
int Peek()
{
    return items[top - 1];
}
