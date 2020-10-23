using System;

namespace BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            int maxSeqOf1 = 1;
            for (int i = 0; i < binary.Length - 1; i++)
            {
                int currCount = 1;
                for (int j = i + 1; j < binary.Length; j++)
                {
                    if (binary[i] == binary[j] && binary[i] == '1')
                    {
                        currCount++;
                    }
                    else
                    {
                        currCount = 1;
                        break;
                    }
                    maxSeqOf1 = Math.Max(currCount, maxSeqOf1);
                }
            }
            Console.WriteLine(maxSeqOf1);

            //int counter = 0;
            //int max = 0;
            //while (n > 0)
            //{
            //    int temp = n % 2;
            //    if (temp == 1) counter++;
            //    else counter = 0;
            //    max = Math.Max(counter, max);
            //    n /= 2;
            //}
            //Console.WriteLine(max);
        }
    }
}
