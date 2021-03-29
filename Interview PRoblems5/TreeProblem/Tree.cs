using System.Collections.Generic;

namespace TreeProblem
{
    public abstract class Tree
    {
        public int Root { get; set; }
        public ICollection<Leaf> Leaves { get; set; }
    }
}
