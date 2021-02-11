using System;
using System.Linq;
using static TheHurdleRace.Solution;
namespace TheHurdleRace
{
   public class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
                ;
            int result = hurdleRace(k, height);

            Console.WriteLine(result);

        }
    }

   public class Solution
    {

        // Complete the hurdleRace function below.
      public  static int hurdleRace(int k, int[] height)
        {

            int maxHeight = height.Max();
            if (k > maxHeight)
                return 0;
            return maxHeight - k;
        }
    }
}
