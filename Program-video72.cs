// --- MAIN PROGRAM (VIDEO 72: WALKING THE TREE) ---

TreeNode? root = null;
int[] values = { 8, 3, 10, 1, 6, 14, 4 };
foreach (int v in values)
{
    root = Insert(root, v);
}

// 1. In order: left, node, right → sorted!
InOrder(root);
Console.WriteLine();

// 2. How many levels does it have?
Console.WriteLine("Height: " + Height(root));

// 3. Same values, inserted already sorted
TreeNode? line = null;
foreach (int v in new int[] { 1, 3, 4, 6, 8 })
{
    line = Insert(line, v);
}
Console.WriteLine("Sorted input height: " + Height(line));


// --- FUNCTIONS DECLARATION AREA ---

// Prints left subtree, then the node, then the right
static void InOrder(TreeNode? node)
{
    if (node == null)
    {
        return;
    }
    InOrder(node.Left);
    Console.Write(node.Value + " ");
    InOrder(node.Right);
}

// Levels of the tallest branch
static int Height(TreeNode? node)
{
    if (node == null)
    {
        return 0;
    }
    return 1 + Math.Max(Height(node.Left), Height(node.Right));
}

// Puts the value in its place (video 71)
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
