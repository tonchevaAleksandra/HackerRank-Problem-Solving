using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockAndTheValidString
{
    class Program
    {
        static string isValid(string s)
        {
            Dictionary<char, long> countingChars = new Dictionary<char, long>();
           
           
            foreach (var item in s.OrderBy(c => c))
            {
                if (!countingChars.ContainsKey(item)) countingChars.Add(item, 1);
                else countingChars[item]++;
            }

            var list = countingChars.Values.ToList().OrderBy(a=>a);
            long max = list.Max();
            long min = list.Min();
            if (max == min )
                return "YES";
           
            var countMinValues = countingChars.Where(c => c.Value == min).Count();
            var countMaxValues = countingChars.Where(c => c.Value == max).Count();
            var currentDict = countingChars.Where(c => c.Value != max && c.Value != min);
            if(countMaxValues==1 && list.Count()-countMinValues==1 )
                return "YES";
            if(countMinValues == 1 && list.Count()-countMaxValues==1 ) return "YES";
            //if (max - min >= 1 && (countMinValues == 1 || countMaxValues == 1) && currentDict.Count()==0)
            //{
            //    return "YES";
            //}
          

            return "NO";
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = isValid(s);

            Console.WriteLine(result);

        }
    }
}
