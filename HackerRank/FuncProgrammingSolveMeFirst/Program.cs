using System;

namespace FuncProgrammingSolveMeFirst
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(a,b));
        }
    }
}
