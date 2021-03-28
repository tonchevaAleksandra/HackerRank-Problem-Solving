using System;
using System.Linq;
using System.Text;

namespace SecondProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //да се напише функция, която получава като параметър 2 стринга.Като резултат да върне друг стринг, съдържащ само символите, които се срещат едновременно и в двата входни стринга:
            //Пример:

            //"abc", "def" => "" "abc", "cde" => "c" "abc", "dafc" => "ac" "abca", "deaf" => "a"

            Console.WriteLine("Please enter two words separated by whitespace and you will receive the duplicated symbols : ");

            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string result = DuplicatedSymbols(arr[0], arr[1]);

            Console.WriteLine($"The result string is: {result}.");
        }

        private static string DuplicatedSymbols(string input1, string input2)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var symbol in input1)
            {
                if (input2.Contains(symbol) && !sb.ToString().Contains(symbol))
                {
                    sb.Append(symbol);
                }
            }

            return sb.ToString();
        }
    }
}
