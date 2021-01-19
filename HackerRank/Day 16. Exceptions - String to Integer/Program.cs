using System;

namespace Day_16._Exceptions___String_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
