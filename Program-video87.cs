// --- MAIN PROGRAM (VIDEO 87: MERGE TWO SORTED LISTS, THE LOGIC) ---

ListNode? list1 = Build(new int[] { 1, 2, 4 });
ListNode? list2 = Build(new int[] { 1, 3, 4 });
Print(Merge(list1, list2));


// --- FUNCTIONS DECLARATION AREA ---

// Always takes the smaller head; a dummy node starts the result
static ListNode? Merge(ListNode? l1, ListNode? l2)
{
    ListNode dummy = new ListNode();
    ListNode tail = dummy;
    while (l1 != null && l2 != null)
    {
        if (l1.val <= l2.val)
        {
            tail.next = l1;
            l1 = l1.next;
        }
        else
        {
            tail.next = l2;
            l2 = l2.next;
        }
        tail = tail.next;
        Console.WriteLine("  took " + tail.val);
    }
    tail.next = l1 ?? l2;
    return dummy.next;
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
