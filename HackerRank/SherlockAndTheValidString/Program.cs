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

            var list = countingChars.Values.OrderBy(a=>a).ToList();
            long max = list.Max();
            long min = list.Min();
            var minValues = list.Where(x => x==min).ToList().Count();
            var maxValues = list.Where(x => x == max).ToList().Count();
            var restElements = list.Where(x => x != max && x != min).ToList().Count();
           
            if (min == max  )
                return "YES";
                
            if(max-min ==1 && restElements==0 && maxValues==1)
                 return "YES";
            if (max - min >= 1 && minValues == 1 && list[0] == 1 && restElements == 0)
                return "YES";
       
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
