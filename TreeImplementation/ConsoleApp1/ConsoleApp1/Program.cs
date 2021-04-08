using System;

namespace SearchOccurenciesInBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode<int>();
            tree.Value = 1;
            tree.LefChild = new TreeNode<int>()
            {
                Value = 2,
                LefChild = new TreeNode<int>() { Value = 1, LefChild = new TreeNode<int>() { Value = 3 } },
                RightChild = new TreeNode<int>() { Value = 5 }
            };
            tree.RightChild = new TreeNode<int>() { Value = 2 };
            var count = 0;
            bool isThereOccurencies = FindOccurencies(tree, 1, ref count);
            Console.WriteLine(isThereOccurencies);
        }

        public static bool FindOccurencies(TreeNode<int> treeNode, int value, ref int count)
        {

            if (treeNode.Value == value)
            {
                count++;
            }

            if (treeNode.LefChild != null)
            {
                FindOccurencies(treeNode.LefChild, value, ref count);
            }
            if (treeNode.RightChild != null)
            {
                FindOccurencies(treeNode.RightChild, value, ref count);
            }


            return count >= 2 ? true : false;
        }
    }
}
