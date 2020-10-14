using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare second integer, double, and String variables.
            int a = 4;
            double b = 4.0;
            string c = "HackerRank ";
            // Read and save an integer, double, and String to your variables.
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            string k = Console.ReadLine();

            Console.WriteLine(a+n);
            Console.WriteLine($"{b+m:F1}");
            Console.WriteLine(c+k);

            // Print the sum of both integer variables on a new line.

            // Print the sum of the double variables on a new line.

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.

        }
    }
}
