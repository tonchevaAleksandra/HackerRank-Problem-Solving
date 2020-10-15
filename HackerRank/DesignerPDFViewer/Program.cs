using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignerPDFViewer
{
    class Program
    {
        static int designerPdfViewer(int[] h, string word)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < h.Length; i++)
            {
                dict.Add(i + 1, h[i]);
            }
            List<int> charactersNum = new List<int>();
            foreach (var c in word)
            {
                var num = dict[(int)(c) - 96];
                charactersNum.Add(num);
            }
            var countLetters = word.Length;
            var maxNum = charactersNum.Max();
            return maxNum * countLetters;

        }
        static void Main(string[] args)
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
       ;
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
        }
    }
}
