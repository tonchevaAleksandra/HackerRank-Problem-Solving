using System;
using System.Collections.Generic;
using System.Threading;

namespace SecondProblem
{
    class Result
    {

        /*
         * Complete the 'droppedRequests' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY requestTime as parameter.
         */

        public static int droppedRequests(List<int> requestTime)
        {
            if (requestTime.Count == 1 || requestTime.Count == 2 || requestTime.Count == 3)
            {
                return 0;
            }

            int dropped = 0;
            int currentSEc = 1;

            int allRequest = 1;
            int tenSecondsPeriod = 1;
            for (int i = 1; i < requestTime.Count; i++)
            {

                int previous = requestTime[i - 1];
                int current = requestTime[i];

                //if (allRequest*1.00/20 > current*1.00/10)
                //{
                //    dropped++;
                //    continue;
                //}
                if (allRequest >= 20 && current <= 10)
                {
                    dropped++;
                    continue;
                }


                if (allRequest >= 60 && current <= 60)
                {
                    dropped++;
                    continue;
                }
                if (current == previous)
                {
                    if (currentSEc >= 3)
                    {
                        dropped++;
                       
                        continue;
                    }
                    currentSEc++;
                }
                else
                {
                    currentSEc = 1;
                }

                allRequest++;

            }

            return dropped;
        }

    }
    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int requestTimeCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> requestTime = new List<int>();

            for (int i = 0; i < requestTimeCount; i++)
            {
                int requestTimeItem = Convert.ToInt32(Console.ReadLine().Trim());
                requestTime.Add(requestTimeItem);
            }

            int result = Result.droppedRequests(requestTime);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
