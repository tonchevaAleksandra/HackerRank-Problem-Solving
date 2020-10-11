using System;
using System.Text;
using System.Text.RegularExpressions;

namespace RepeatedString
{
    class Program
    {
        static long repeatedString(string s, long n)
        {
            var cycles = n / s.Length;
            var rest = n % s.Length;

            string pattern = @"[a]";
            MatchCollection matches = Regex.Matches(s, pattern);
            var repeatingCount = matches.Count * cycles;
            repeatingCount += Regex.Matches(s.Substring(0, (int)rest), pattern).Count;

            return repeatingCount;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);

        }
    }
}
