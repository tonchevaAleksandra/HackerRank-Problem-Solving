using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareTheTriplets
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> compare = CompareTriplets(list1, list2);

            Console.WriteLine($"{compare[0]} {compare[1]}");

        }

        static List<int> CompareTriplets(List<int> list1, List<int> list2)
        {

            List<int> result = new List<int>();
            result.Add(0);
            result.Add(0);
            for (int i = 0; i <list1.Count; i++)
            {
                if (list1[i] > list2[i])
                {
                    result[0] += 1;
                }

                else if (list1[i] < list2[i])
                {
                    result[1] += 1;
                }
            }
            
            return result;

        }
    }
}
