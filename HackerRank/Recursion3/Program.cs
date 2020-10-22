using System;

namespace Recursion3
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * (Factorial(n - 1));
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Factorial(n);

            Console.WriteLine(result);

        }
    }
}
