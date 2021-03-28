using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdProblem
{
   public class Program
    {
        static void Main(string[] args)
        {
            //даден е числен масив с дължина N, стойностите на елементите са в диапазона от 1 до 5.Да се напише функция, която го сортира по възможно най ефективен начин.
            //1, 3, 1, 2, 5, 2, 1, 3 => 1, 1, 1, 2, 2, 3, 3, 5
            int[] arr = Console.ReadLine()
                .Split(new char[]{' ',','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> resuList = new List<int>();
            int indexOf1 = 0;
            int indexOf2 = 0;
            int indexOf3 = 0;

            foreach (var num in arr)
            {
                if (num==1)
                {
                    resuList.Insert(0,num);
                    indexOf1++;
                }
                else if (num==2)
                {
                    resuList.Insert(indexOf1,num);
                    indexOf2++;
                }
                else if (num==3)
                {
                    resuList.Insert(indexOf1 + indexOf2, num);
                    indexOf3++;
                }
                else if (num == 4)
                {
                    resuList.Insert(indexOf1 + indexOf2 +indexOf3, num);
                }
                else
                {
                    resuList.Add(num);
                }
            }

            Console.WriteLine(string.Join(", ", resuList));
        }
    }
}
