using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            int currPos = 0;
            while (currPos<c.Length-1)
            {
                if(currPos+2<c.Length && c[currPos+2]==0)
                {
                    currPos += 2;
                    
                }
                else
                {
                    currPos += 1;
                }
                jumps++;
            }
            return jumps;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);

        }
    }
}
