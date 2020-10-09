using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiagonalSumDifference
{
    class Result
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                sum1 += arr[j][j];
                sum2 += arr[j][arr.Count - (j + 1)];
            }
            //for (int j = 0; j < arr.Count; j++)
            //{
            //    sum2 += arr[j][arr.Count - (j + 1)];
            //}
            //for (int j = 0; j < arr.Count; j++)
            //{
            //    for (int k = 0; k < arr.Count; k++)
            //    {
            //        if(j==arr.Count-k-1)
            //        {
            //            sum2 += arr[j][k];
            //        }
                    
            //    }
            //}
            int result = Math.Abs(sum1 - sum2);
            return result;
        }
            
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.DiagonalDifference(arr);

            Console.WriteLine(result);

            
        }
    }

}
