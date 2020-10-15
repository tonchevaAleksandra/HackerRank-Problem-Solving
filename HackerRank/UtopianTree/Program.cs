using System;

namespace UtopianTree
{
    class Program
    {
        static int utopianTree(int n)
        {
            var height = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    height++;
                }
                else height *= 2;
            }
            return height;
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);

                Console.WriteLine(result);
            }
        }
    }
}
