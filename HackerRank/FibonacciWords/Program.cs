using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var firstWord = input[0];
                var second = input[1];
                var num = long.Parse(input[2]);
                long sum = firstWord.Length + second.Length;
                Queue<string> queue = new Queue<string>();
                queue.Enqueue(firstWord);
                queue.Enqueue(second);

                while(sum<num)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(queue.Dequeue());
                    firstWord = queue.Peek();
                    sb.Append(queue.Peek());
                    if(sb.Length>num)
                    {
                        break;
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
