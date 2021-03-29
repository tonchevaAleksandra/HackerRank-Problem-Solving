using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            bool result = ValidateSequence(new int[] { 1, 7, 3, 6 });
            Console.WriteLine(result);
        }

        private static bool ValidateSequence(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    int currentNum = array[i] * 2;
                    if (currentNum > 9)
                    {
                        int digit = currentNum % 10;
                        currentNum /= 10;
                        sum += digit;
                        sum += currentNum;
                    }
                    else
                    {
                        sum += currentNum;
                    }
                }
                else
                {
                    sum += array[i];
                }
            }

            Console.WriteLine(sum);
            PrintArray(array);
            return sum % 10 == 0;
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
