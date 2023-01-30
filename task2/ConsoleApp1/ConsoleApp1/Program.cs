using System;

public class Node
{
    public int value;
    public Node left, right, middle;

    public Node(int val)
    {
        value = val;
        left = right = middle = null;
    }
}

public class BinaryTree
{
    Node root;

    int maxDepth(Node root)
    {
        if (root == null)
            return 0;

        // Recursively find the depth of each subtree.
        int leftDepth = maxDepth(root.left);
        int rightDepth = maxDepth(root.right);
        int middleDepth = maxDepth(root.middle);

       
        if (leftDepth > middleDepth)
            return (leftDepth + 1);
        else if (middleDepth > leftDepth)
            return (middleDepth + 1);
        else if(middleDepth > rightDepth)
            return (middleDepth + 1);
        else return (rightDepth + 1);
    }

    // Driver code
    public static void Main()
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new Node(1);
        tree.root.right = new Node(1);
        tree.root.left = new Node(2);
        tree.root.left.left = new Node(2);
        tree.root.right.left = new Node(1);
        tree.root.right.middle = new Node(7);
        tree.root.right.right = new Node(1);
        tree.root.right.left.left = new Node(1);
        tree.root.right.middle.left = new Node(9);
        tree.root.right.middle.left.middle = new Node(11);
        tree.root.right.middle.right = new Node(7);
        Console.WriteLine("Max depth: " + tree.maxDepth(tree.root));
    }
}