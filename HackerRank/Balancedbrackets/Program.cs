using System;
using System.Collections.Generic;
using System.Linq;

namespace Balancedbrackets
{
    class Program
    {
        static string isBalanced(string s)
        {
            Stack<char> brackets = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var currChar = s[i];
                switch (currChar)
                {
                    case '(':
                    case '{':
                    case '[':
                        brackets.Push(currChar);
                        break;
                    case ')':
                        if (brackets.Any() && brackets.Peek() == '(')
                            brackets.Pop();
                        else return "NO";
                        break;
                    case '}':
                        if (brackets.Any() && brackets.Peek() == '{')
                            brackets.Pop();
                        else return "NO";
                        break;
                    case ']':
                        if (brackets.Any() && brackets.Peek() == '[')
                            brackets.Pop();
                        else return "NO";
                        break;

                }
            }

            return !brackets.Any() ? "YES" : "NO";

        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = isBalanced(s);

                Console.WriteLine(result);
            }
        }
    }
}
