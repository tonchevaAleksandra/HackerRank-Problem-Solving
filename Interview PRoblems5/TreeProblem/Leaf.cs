using System.Collections.Generic;
using System.ComponentModel.Design;

namespace TreeProblem
{
    public class Leaf 
    {
        public Leaf()
        {
           
        }
        public int Value { get; set; }
        //public Leaf ParentLeaf { get; set; }
        public Leaf FirstLeaf { get; set; }
        public Leaf SecondLeaf { get; set; }
    }
}
