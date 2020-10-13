using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AlternatingCharacters
{
    class Program
    {
        static int alternatingCharacters(string s)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
               var currChar = s[i];
               if(currChar=='A'  && stack.Peek()=='B')
                {
                    stack.Push(currChar);
                }
               else if(currChar=='B' && stack.Peek()=='A')
                {
                    stack.Push(currChar);
                }
            }
            return s.Length - stack.Count();
        }
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);

                Console.WriteLine(result);
            }
        }

    }
}
