// --- MAIN PROGRAM (VIDEO 88: MERGE TWO SORTED LISTS, THE CODE) ---

int[] a = { 1, 2, 4 };
int[] b = { 1, 3, 4 };
Print(MergeTwoLists(Build(a), Build(b)));
Print(MergeRecursive(Build(a), Build(b)));
Print(MergeTwoLists(null, Build(new int[] { 0 })));


// --- FUNCTIONS DECLARATION AREA ---

// LeetCode 21, iterative: dummy + tail, always take the smaller head
static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
{
    ListNode dummy = new ListNode();
    ListNode tail = dummy;
    while (list1 != null && list2 != null)
    {
        if (list1.val <= list2.val)
        {
            tail.next = list1;
            list1 = list1.next;
        }
        else
        {
            tail.next = list2;
            list2 = list2.next;
        }
        tail = tail.next;
    }
    tail.next = list1 ?? list2;
    return dummy.next;
}

// Recursive: the smaller head goes first, merge the rest after it
static ListNode? MergeRecursive(ListNode? l1, ListNode? l2)
{
    if (l1 == null) return l2;
    if (l2 == null) return l1;
    if (l1.val <= l2.val)
    {
        l1.next = MergeRecursive(l1.next, l2);
        return l1;
    }
    l2.next = MergeRecursive(l1, l2.next);
    return l2;
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
