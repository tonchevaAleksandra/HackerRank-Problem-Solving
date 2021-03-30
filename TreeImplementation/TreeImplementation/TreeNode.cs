using System.Collections.Generic;

namespace BasicTreeImplementation
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;

            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }

            return height;
        }
    }
}
