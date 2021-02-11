using System;
using System.IO;
using System.Text.Json.Serialization;

namespace First_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int cssFiles = Convert.ToInt32(Console.ReadLine().Trim());

            int jsFiles = Convert.ToInt32(Console.ReadLine().Trim());

            int readMeFiles = Convert.ToInt32(Console.ReadLine().Trim());

            int capacity = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.minFolders(cssFiles, jsFiles, readMeFiles, capacity);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    class Result
    {
        

        public static int minFolders(int cssFiles, int jsFiles, int readMeFiles, int capacity)
        {
            int folders = readMeFiles;
            if (capacity > 2)
            {
                
                if ((cssFiles + jsFiles) * 1.00 / readMeFiles > 1)
                {
                    if (cssFiles >= readMeFiles*2)
                    {
                        cssFiles -= readMeFiles*2;
                        readMeFiles = 0;
                        folders += (cssFiles + jsFiles)/capacity;
                        cssFiles = 0;
                    }

                    else if (cssFiles < readMeFiles * 2)
                    {
                        folders += cssFiles / 2;
                        readMeFiles -= cssFiles / 2;
                        cssFiles = 0;
                    }
                    if (jsFiles >= readMeFiles*2)
                    {
                        jsFiles -= readMeFiles*2;
                        readMeFiles = 0;
                        folders+=(cssFiles+jsFiles)/capacity;
                        jsFiles = 0;
                    }
                    else if (jsFiles < readMeFiles * 2)
                    {
                        folders += jsFiles / 2;
                        readMeFiles -= jsFiles / 2;
                        jsFiles = 0;
                    }

                }

              
                return folders;
            }
            else if (capacity == 2)
            {
                if (cssFiles != 0  && jsFiles != 0)
                {
                    folders += (int) Math.Ceiling(cssFiles * 1.00 / 2);
                    folders += (int) Math.Floor(jsFiles * 1.00 / 2);
                }

                if (jsFiles == 0)
                {
                    folders+= (int)Math.Ceiling(cssFiles * 1.00 / 2);
                }

                if (cssFiles == 0)
                {
                    folders += (int)Math.Ceiling(jsFiles * 1.00 / 2);
                }
             
              return folders;
            }
          
            else
            {
                return cssFiles + jsFiles + readMeFiles;
            }
           

           

        }

    }
}
