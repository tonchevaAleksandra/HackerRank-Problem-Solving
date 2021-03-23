using System;
using System.Linq;

namespace SomeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(IsDescending(arr));
        }
        public static bool IsDescending(int[] array) { return IsDescendingOrder(array, 0); }

        private static bool IsDescendingOrder(int[] array, int index)
        {
            if (index >= array.Length-1)
                return true;
            else if (array[index] <= array[index + 1])
                return false;
            else
                return IsDescendingOrder(array, index + 1);
        }
    }
}
