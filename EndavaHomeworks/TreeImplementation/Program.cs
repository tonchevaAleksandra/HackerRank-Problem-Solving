using System;

namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new TreeNode<int>(10);
            tree.Root.LeftNode = new TreeNode<int>(5);
            tree.Root.RightNode = new TreeNode<int>(20);
            tree.Root.LeftNode.LeftNode = new TreeNode<int>(4);
            tree.Root.LeftNode.RightNode = new TreeNode<int>(8);
            tree.Root.RightNode.LeftNode = new TreeNode<int>(15);
            tree.Root.RightNode.RightNode = new TreeNode<int>(25);

            Console.WriteLine(Search(tree.Root.LeftNode, 20));
        }

        public static bool Search<T>(TreeNode<T> root, T value)
        {

            if (root == null)
                return false;

            if (root.Data .Equals(value))
                return true;

            if (!Search(root.LeftNode, value))
                return Search(root.RightNode, value);

            else if (!Search(root.RightNode, value))
                return Search(root.RightNode, value);

            return false;
        }
    }
}
