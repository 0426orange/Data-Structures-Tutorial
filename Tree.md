Trees in C#: A Complete Tutorial

A Tree is a non-linear data structure that represents data in a hierarchical form. It consists of nodes connected by edges. Trees are widely used for searching, sorting, and organizing data efficiently.

In this tutorial, we will discuss the Binary Tree and Binary Search Tree (BST), as they are the most commonly used trees in programming.

Tree Terminology
Before we dive into implementation, here are some key terms:

Root: The topmost node of a tree.
Node: Each element in the tree.
Edge: The connection between two nodes.
Leaf Node: A node that has no children.
Parent/Child: A node that has other nodes connected below it is the parent, and the connected nodes are its children.
Height: The length of the longest path from the root to any leaf.
Depth: The distance of a node from the root.
Binary Tree
A Binary Tree is a tree where each node has at most two children, commonly referred to as left and right children.

Implementing a Binary Tree in C#
We will build a simple binary tree and traverse it using different methods.

1. Define the Node Class
Each node of the tree will have:

A value (data)
A reference to the left child
A reference to the right child
Code:
```csharp
public class TreeNode
{
    public int Data;         // Node value
    public TreeNode Left;    // Left child
    public TreeNode Right;   // Right child

    public TreeNode(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}
```
2. Define the Binary Tree Class
We create a BinaryTree class that will include:

A root node.
Methods to insert nodes and traverse the tree.
Inserting Nodes
Here, we add nodes to the tree manually for demonstration purposes.

Code:
```csharp
using System;

public class BinaryTree
{
    public TreeNode Root;

    public BinaryTree()
    {
        Root = null;
    }

    // Pre-Order Traversal: Root -> Left -> Right
    public void PreOrder(TreeNode node)
    {
        if (node == null) return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // In-Order Traversal: Left -> Root -> Right
    public void InOrder(TreeNode node)
    {
        if (node == null) return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // Post-Order Traversal: Left -> Right -> Root
    public void PostOrder(TreeNode node)
    {
        if (node == null) return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }
}

class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();

        // Manually constructing a binary tree
        tree.Root = new TreeNode(1);
        tree.Root.Left = new TreeNode(2);
        tree.Root.Right = new TreeNode(3);
        tree.Root.Left.Left = new TreeNode(4);
        tree.Root.Left.Right = new TreeNode(5);

        Console.WriteLine("Pre-Order Traversal:");
        tree.PreOrder(tree.Root); // Output: 1 2 4 5 3

        Console.WriteLine("\nIn-Order Traversal:");
        tree.InOrder(tree.Root); // Output: 4 2 5 1 3

        Console.WriteLine("\nPost-Order Traversal:");
        tree.PostOrder(tree.Root); // Output: 4 5 2 3 1
    }
}
```
Output:
Pre-Order Traversal:
1 2 4 5 3

In-Order Traversal:
4 2 5 1 3

Post-Order Traversal:
4 5 2 3 1

Binary Search Tree (BST)
A Binary Search Tree (BST) is a special type of binary tree where:

The left child contains values less than the parent.
The right child contains values greater than the parent.
This structure allows for efficient searching, insertion, and deletion.

1. Inserting Nodes into BST
To insert a node into a BST:

Start from the root.
Compare the new value with the current node.
If it’s smaller, move to the left.
If it’s larger, move to the right.
Repeat until you find an empty spot.
Code:
```csharp
public class BST
{
    public TreeNode Root;

    public BST()
    {
        Root = null;
    }

    // Insert a node into the BST
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private TreeNode InsertRec(TreeNode root, int data)
    {
        if (root == null)
        {
            root = new TreeNode(data);
            return root;
        }

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    // In-Order Traversal to display elements in sorted order
    public void InOrder(TreeNode root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }
    }
}

class Program
{
    static void Main()
    {
        BST bst = new BST();

        // Insert elements into the BST
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(60);
        bst.Insert(80);

        Console.WriteLine("In-Order Traversal of the BST:");
        bst.InOrder(bst.Root); // Output: 20 30 40 50 60 70 80
    }
}
```
Output:
In-Order Traversal of the BST:
20 30 40 50 60 70 80

Searching in a BST

To search for an element in a BST:

Start at the root.
Compare the target value with the current node’s value:
If they are equal, the value is found.
If the target is smaller, move to the left subtree.
If the target is larger, move to the right subtree.
Repeat until the value is found or the subtree is empty.
Code:
```csharp
public bool Search(TreeNode root, int key)
{
    if (root == null) return false;

    if (root.Data == key)
        return true;

    if (key < root.Data)
        return Search(root.Left, key);
    else
        return Search(root.Right, key);
}
```
Conclusion
In this tutorial, you learned:

What trees are and their terminology.
How to implement a binary tree and traverse it using:
Pre-Order
In-Order
Post-Order
What a Binary Search Tree (BST) is and how to:
Insert nodes
Search for elements
How a BST can be used to store and access data efficiently.
Practice Problem
Write a program to find the height of a binary tree.
Implement a function to delete a node in a Binary Search Tree.
```csharp
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
```
