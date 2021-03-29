using System;
using System.Runtime.InteropServices.ComTypes;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write('W');

                    }
                    else
                    {
                        Console.Write('B');

                    }
                }

                Console.WriteLine();
            }
        }
    }
}
