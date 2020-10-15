using System;
using System.Collections.Generic;
using System.Linq;

namespace QueriesAtaleOfTwoStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int[] targets = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();
                var command = targets[0];
                switch (command)
                {
                    case 1:
                        stack.Push(targets[1]);
                        queue.Enqueue(targets[1]);
                        break;
                    case 2:
                        if (queue.Any()) queue.Dequeue();
                        break;
                    case 3:
                        Console.WriteLine(queue.Peek());
                        break;
                    default:
                        break;
                }

            }

            while (queue.Any())
            {

                var command = queue.Dequeue();
                switch (command)
                {
                    case 1:
                       
                        break;
                    case 2:
                       
                        break;
                    case 3:
                       
                        break;
                    default:
                        break;
                } 
            }
        }
    }
}
