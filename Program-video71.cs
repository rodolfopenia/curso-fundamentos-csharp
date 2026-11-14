// --- MAIN PROGRAM (VIDEO 71: BINARY SEARCH TREE) ---

// Smaller values go left, bigger values go right
TreeNode? root = null;
int[] values = { 8, 3, 10, 1, 6, 14, 4 };
foreach (int v in values)
{
    root = Insert(root, v);
}

Console.WriteLine("Contains 6? " + Contains(root, 6));
Console.WriteLine("Contains 5? " + Contains(root, 5));


// --- FUNCTIONS DECLARATION AREA ---

// Puts the value in its place and returns the node
static TreeNode Insert(TreeNode? node, int value)
{
    if (node == null)
    {
        return new TreeNode(value);
    }
    if (value < node.Value)
    {
        node.Left = Insert(node.Left, value);
    }
    else
    {
        node.Right = Insert(node.Right, value);
    }
    return node;
}

// Goes left or right until it finds the value
static bool Contains(TreeNode? node, int value)
{
    while (node != null)
    {
        if (value == node.Value)
        {
            return true;
        }
        if (value < node.Value)
        {
            node = node.Left;
        }
        else
        {
            node = node.Right;
        }
    }
    return false;
}


// --- CLASSES DECLARATION AREA ---

class TreeNode
{
    public int Value;
    public TreeNode? Left;
    public TreeNode? Right;

    public TreeNode(int value)
    {
        Value = value;
    }
}
