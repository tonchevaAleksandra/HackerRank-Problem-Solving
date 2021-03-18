using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, give me an array of numbers and on a new line a number which represents a sum of two other numbers in the array!");
            Console.WriteLine("And I will tell you the indices of the first two numbers that meet the condition!");

            string input = Console.ReadLine();
            int[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                //.OrderBy(x => x)
                .ToArray();
            int searchedSum = int.Parse(Console.ReadLine());

            bool isFound = false;

            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int i = 0;
            while (i < arr.Length )
            {
                if (arr[i]>=searchedSum)
                {
                    continue;
                }
                if (dict.ContainsKey(searchedSum - arr[i]))
                {
                    result[0] = dict[searchedSum - arr[i]];
                    result[1] = i;
                    isFound = true;
                    break;
                }

                dict.Add(arr[i], i);
                i++;
            }

            Console.WriteLine(!isFound
                ? "There are no numbers that match the condition!"
                : $"The positions of the first two numbers that match the condition are  {result[0]} and {result[1]}");
        }
    }
}
