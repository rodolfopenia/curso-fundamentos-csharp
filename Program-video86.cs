// --- MAIN PROGRAM (VIDEO 86: REVERSE LINKED LIST, THE CODE) ---

ListNode? a = Build(new int[] { 1, 2, 3, 4 });
Print(ReverseList(a));

ListNode? b = Build(new int[] { 1, 2, 3, 4 });
Print(ReverseRecursive(b));

Print(ReverseList(null));


// --- FUNCTIONS DECLARATION AREA ---

// LeetCode 206, iterative: flip each arrow while walking
static ListNode? ReverseList(ListNode? head)
{
    ListNode? prev = null;
    while (head != null)
    {
        ListNode? next = head.next;
        head.next = prev;
        prev = head;
        head = next;
    }
    return prev;
}

// Recursive: reverse the rest, then hook this node at its end
static ListNode? ReverseRecursive(ListNode? head)
{
    if (head == null || head.next == null)
    {
        return head;
    }
    ListNode? newHead = ReverseRecursive(head.next);
    head.next.next = head;
    head.next = null;
    return newHead;
}

// Builds a list from an array, back to front
static ListNode? Build(int[] values)
{
    ListNode? head = null;
    for (int i = values.Length - 1; i >= 0; i--)
    {
        head = new ListNode(values[i], head);
    }
    return head;
}

// Prints the values from head to null
static void Print(ListNode? head)
{
    string text = "";
    for (ListNode? n = head; n != null; n = n.next)
    {
        text += n.val + " -> ";
    }
    Console.WriteLine(text + "null");
}

// LeetCode's node: val and next, in lowercase
public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}
