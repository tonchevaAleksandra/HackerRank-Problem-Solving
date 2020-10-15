using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingNumbers
{
    class Program
    {
        //Working on some test cases
        public static int pickingNumbers(List<int> a)
        {
             a= a.OrderBy(x => x).ToList();
            int maxCount = 1;

            //var firstElement = a[0];
            //var count1 = 1;
            //for (int i = 1; i < a.Count; i++)
            //{
            //    if (a[i] - firstElement <= 1) count1++;
            //    else
            //    {
            //        count1 = 1;

            //    }
            //}

            for (int i = 0; i < a.Count() - 1; i++)
            {
                var currCount = 1;
                for (int j = i + 1; j < a.Count(); j++)
                {
                    if (Math.Abs(a[j] - a[i]) <= 1)
                    {
                        currCount++;
                    }
                    if (currCount > maxCount) maxCount = currCount;
                    else break;
                }
            }

            return maxCount>=2 ? maxCount : 0;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);

            Console.WriteLine(result);

        }
    }
}
