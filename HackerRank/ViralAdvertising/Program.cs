using System;

namespace ViralAdvertising
{
    class Program
    {
        static int viralAdvertising(int n)
        {
            var cumulative = 2;
            var shared = 5;
            var liked = 2;
            for (int i = 1; i < n; i++)
            {
                shared = liked * 3;
                liked =shared / 2;
                cumulative += liked;
            }
            return cumulative;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = viralAdvertising(n);

            Console.WriteLine(result);

        }
    }
}
