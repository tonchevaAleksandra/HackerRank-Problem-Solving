
namespace TreeImplementation
{
   public class TreeNode<T>
    {
        public TreeNode(T data)
        {
            this.Data = data;
            this.LeftNode = this.RightNode = null;
        }
        public T Data { get; set; }

        public TreeNode<T> LeftNode { get; set; }

        public TreeNode<T> RightNode { get; set; }

        //public TreeNode<T> DeleteNode(TreeNode<T> root, T data)
        //{
        //    if (root==null)
        //    {
        //        return root;
        //    }

        //    if (!root.Data.Equals(data))
        //    {
        //        DeleteNode(root.LeftNode, data);
        //        DeleteNode(root.RightNode, data);
        //    }

        //}
    }
}
