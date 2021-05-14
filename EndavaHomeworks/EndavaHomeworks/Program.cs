using System;
using System.Collections.Generic;

namespace HomeWork
{
   public class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //var container1 = new Container<Int32>() {Data = 126};
            //Console.WriteLine(container1.ToString());

            //var container2 = new Container<String> {Data = "Container String"};
            //Console.WriteLine(container2.ToString());

            // Task 2

            var container = new Container<string>() {Data = "test data"};
            var n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            var result = 0;

            for (int i = 0; i < n; i++)
            {
                var element = Console.ReadLine();
                list.Add(element);
               
            }

            Console.WriteLine($"Equals values found: {CompareValues(container, list)}");
        }

        private static int CompareValues(Container<string> container, List<string> list)
        {
            var result = 0;
            foreach (var element in list)
            {
                if (container.CompareTo(element)==1)
                {
                    result++;
                }
            }

            return result;
        }
    }


}
