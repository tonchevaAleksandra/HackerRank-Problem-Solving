using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] parameters = Console.ReadLine().Split().ToArray();
                string name = parameters[0];
                int number = int.Parse(parameters[1]);
                if(!phoneBook.ContainsKey(name))
                {
                    phoneBook.Add(name, number);
                }
            }

            string input;
            while ((input = Console.ReadLine())!=null)
            {

                if(phoneBook.ContainsKey(input))
                {
                    Console.WriteLine($"{input}={phoneBook[input]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
