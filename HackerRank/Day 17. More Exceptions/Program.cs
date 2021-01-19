using System;

namespace Day_17._More_Exceptions
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public int power(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new Exception("n and p should be non-negative");
            else
                return (int)(Math.Pow(a, b));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}
