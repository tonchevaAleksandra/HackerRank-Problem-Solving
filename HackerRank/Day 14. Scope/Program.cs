using System;
using System.Linq;

namespace Day_14._Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] array)
        {
            this.elements = array;
            this.maximumDifference = int.MinValue;
        }

        public void computeDifference()
        {
            for (int i = 0; i < this.elements.Length-1; i++)
            {
                for (int j = i+1; j < this.elements.Length; j++)
                {
                    if (Math.Abs(elements[i] - elements[j]) > this.maximumDifference)
                        maximumDifference = Math.Abs(elements[i] - elements[j]);
                }
            }
        }

    }
}
