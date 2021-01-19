using System;
using System.Linq;

namespace _2D_Arrays
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int maxSum = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
               
                int currentMaxSum = 0;
                for (int j = 0; j < 4; j++)
                {
                    currentMaxSum =
                         arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                         + arr[i + 1][j + 1]
                         + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (currentMaxSum >= maxSum)
                        maxSum = currentMaxSum;
                }

            }

            Console.WriteLine(maxSum);
        }
    }
}
