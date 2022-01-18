// See https://aka.ms/new-console-template for more information
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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal neg = 0;
        decimal pos = 0;
        decimal zero = 0;
        decimal count = arr.Count();

        foreach (int a in arr)
        {
            if (a > 0)
            {
                pos += 1;
            }
            if (a < 0)
            {
                neg += 1;
            }
            if (a == 0)
            {
                zero += 1;
            }
        }

        decimal negRatio = neg / count;
        decimal posRatio = pos / count;
        decimal zeroRatio = zero / count;

        Console.WriteLine("{0:0.000000}", posRatio);
        Console.WriteLine("{0:0.000000}", negRatio);
        Console.WriteLine("{0:0.000000}", zeroRatio);
        Console.WriteLine(count);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
