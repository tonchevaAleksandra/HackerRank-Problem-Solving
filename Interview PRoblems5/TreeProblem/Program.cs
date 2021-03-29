using System;

namespace TreeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        private static int FindMaxValue(Leaf leaf)
        {
            int maxValue = int.MinValue;

            if (leaf.Value>maxValue)
            {
                maxValue = leaf.Value;
            }

            while (leaf.FirstLeaf !=null || leaf.SecondLeaf!=null)
            {
                if (leaf.FirstLeaf!=null)
                {
                    FindMaxValue(leaf.FirstLeaf);
                }

                if (leaf.SecondLeaf!=null)
                {
                    FindMaxValue(leaf.SecondLeaf);
                }
                
            }

            return maxValue;
        }
    }
}
