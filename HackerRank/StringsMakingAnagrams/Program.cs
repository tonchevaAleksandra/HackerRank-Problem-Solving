using System;
using System.Collections.Generic;
using System.Text;

namespace StringsMakingAnagrams
{
    class Program
    {
        static int makeAnagram(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            var length = a.Length + b.Length;
            var first = new List<char>(a);
            var second = new List<char>(b);
            for (int i = 0; i < first.Count; i++)
            {
                if (second.Contains(first[i]))
                {
                    var currC = first[i];
                    sb.Append(currC);
                    first.RemoveAt(i);
                    var index = second.IndexOf(currC);
                    second.RemoveAt(index);
                    i--;
                }

            }
            return length - (2 * sb.Length);

        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            string b = Console.ReadLine();

            int res = makeAnagram(a, b);

            Console.WriteLine(res);

        }
    }
}
