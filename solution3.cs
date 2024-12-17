
public int FindHeight(TreeNode node)
{
    if (node == null)
        return -1; // Base case: empty tree has a height of -1

    // Recursively find the height of left and right subtrees
    int leftHeight = FindHeight(node.Left);
    int rightHeight = FindHeight(node.Right);

    // Height of the tree = max of left or right subtree + 1
    return Math.Max(leftHeight, rightHeight) + 1;
}

//How to Use It
//Integrate this function into the BinaryTree class:

class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();

        // Construct a binary tree
        tree.Root = new TreeNode(1);
        tree.Root.Left = new TreeNode(2);
        tree.Root.Right = new TreeNode(3);
        tree.Root.Left.Left = new TreeNode(4);
        tree.Root.Left.Right = new TreeNode(5);

        // Find and display the height
        int height = tree.FindHeight(tree.Root);
        Console.WriteLine("Height of the binary tree: " + height);
    }
}
