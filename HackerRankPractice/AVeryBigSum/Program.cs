using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the aVeryBigSum function below.

    static long aVeryBigSum(long[] ar)
    {
        long result = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            result += ar[i];
        }
        return result;

    }

    static void Main(string[] args)
    {
      

        int arCount = Convert.ToInt32(Console.ReadLine());

        long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
        ;
        long result = aVeryBigSum(ar);

        Console .WriteLine(result);

        
    }
}
