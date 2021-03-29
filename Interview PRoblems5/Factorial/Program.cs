using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            uint element = uint.Parse(Console.ReadLine());
        
            ulong result = FindFactorial(element);
            Console.WriteLine(result);
        }

        private static ulong FindFactorial(uint n)
        {
           
            if (n<=1)
            {
                return 1;
            }

           return n * FindFactorial(n - 1);

        }
    }
}
