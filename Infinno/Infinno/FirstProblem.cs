using System;

namespace Infinno
{
   public class FirstProblem
    {
        static void Main(string[] args)
        {

            //да се напише програма, която печата числата от 1 до 100.
            //всяко число да бъде на нов ред;
            //ако е кратно на 3 вместо числото да се напечата "git";
            //ако е кратно на 5 вместо числото да се напечата "hub";
            for (int i = 1; i < 100; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine("git");
                }
                else if(i%4==0)
                {
                    Console.WriteLine("hub");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
