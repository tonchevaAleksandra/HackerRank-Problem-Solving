using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, give me an array of numbers and on a new line a number with represent a sum of two other numbers in the array!");
            Console.WriteLine("And I will tell you the indices of the first two numbers that meet the condition!");

            string input = Console.ReadLine();
            List<int> arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int searchedSum = int.Parse(Console.ReadLine());

            int firstIndex = int.MinValue;
            int secondIndex = int.MinValue;
            bool isFound = false;

            for (int i = 0; i < arr.Count-1; i++)
            {
                for (int j = i+1; j < arr.Count; j++)
                {
                    if (arr[i] + arr[j] == searchedSum)
                    {
                        isFound = true;
                        firstIndex = i;
                        secondIndex = j;
                        break;
                    }

                }

                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
               Console.WriteLine("There are no numbers that match the condition!"); 
            }
            else
            {
                Console.WriteLine($"The positions of the first two numbers that match the condition are  {firstIndex} and {secondIndex}");
            }

        }
    }
}
