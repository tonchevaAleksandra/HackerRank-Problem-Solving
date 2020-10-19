using System;
using System.Text;

namespace LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string a = Console.ReadLine();
                StringBuilder first = new StringBuilder();
                StringBuilder second = new StringBuilder();
                for (int j = 0; j < a.Length; j++)
                {
                    if (j % 2 == 0) first.Append(a[j]);
                    else second.Append(a[j]);
                  
                }
                Console.WriteLine(first.ToString()+" "+second.ToString());
            }
        }
    }
}
