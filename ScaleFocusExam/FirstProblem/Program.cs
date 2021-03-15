using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FirstProblem
{
    class Result
    {

        /*
         * Complete the 'balancedSum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int balancedSum(List<int> arr)
        {
            int index = 0;
            int left = 0;
              int  right = arr.Sum() ;
            for (int i = 0; i < arr.Count-1; i++)
            {
                right -= arr[i];
                if (left==right)
                {
                    index = i;
                    break;
                }
                left += arr[i];
            }

            return index;
        }

    }
    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = new List<int>();

            for (int i = 0; i < arrCount; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                arr.Add(arrItem);
            }

            int result = Result.balancedSum(arr);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }



}
