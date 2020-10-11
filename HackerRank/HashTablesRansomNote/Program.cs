using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HashTablesRansomNote
{
    class Program
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> magazineWords = new Dictionary<string, int>();
            foreach (var item in magazine)
            {
                if(!magazineWords.ContainsKey(item))
                {
                    magazineWords.Add(item,0);
                }
                magazineWords[item]++;
            }
            foreach (var item in note)
            {
                if(magazineWords.ContainsKey(item))
                {
                    magazineWords[item]--;
                    if (magazineWords[item] == 0) magazineWords.Remove(item); 
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}
