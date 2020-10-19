using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
             
                Console.WriteLine($"{n} x {i} = {n*i}");
            }
        }
    }
}
