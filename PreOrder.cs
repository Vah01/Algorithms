class Node
{
    public int key;
    public Node left, right;
    public Node(int item)
    {
        key = item;
        left = right = null;
    }
}
class BinaryTree
{
    Node root;
    BinaryTree()
    {
        root = null;
    }
    void PrintInOrder(Node node)
    {
        if (node == null)
            return;
            Console.Write(node.key + " ");
            PrintInOrder(node.left);
            PrintInOrder(node.right);
    }
    void PrintInOrder()
    {
        PrintInOrder(root);
    }
    static public void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.left.right = new Node(5);
        Console.WriteLine("PreOrder traversal " + "of binary tree is ");
        tree.PrintInOrder();
    }
}
