using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using Tests;
using Sorts;

class Program
{
    static void TimeTest()
    {
        string outfileName = "out.csv";
        int nLimit = 500 * 1000;
        List<int> nCol = new List<int>();
        List<long> tMerge = new List<long>();

        StreamWriter sw = new StreamWriter(outfileName);
        Stopwatch timer = new Stopwatch();

        Console.WriteLine("Starting timing test...");
        for (int n = 1; n <= nLimit; n+=100)
        {
            int[] arr = Helper.CreateRandomIntArray(n);
            int[] cpy = new int[n];
            arr.CopyTo(cpy, 0);
            Console.WriteLine($"n={n}");

            timer.Restart();
            Sort.MergeSort(arr);
            timer.Stop();
            long deltaT1 = timer.ElapsedMilliseconds;

            // timer.Restart();
            // Array.Sort(cpy);
            // timer.Stop();
            // long deltaT2 = timer.ElapsedMilliseconds;
            sw.WriteLineAsync(string.Format("{0:G},{1:G}", n, deltaT1));
        }
        // Console.WriteLine("Testing complete, outputting to file...");
        // string[] rows = new string[nLimit];
        // int[] nCols = nCol.ToArray();
        // for (int i = 0; i < nLimit; i++)
        //     rows[i] = string.Format("{0:G},{1:G}", nCols[i], tMerges[i]);
        // foreach (var s in rows)
        //     sw.WriteLine(s);
        sw.Close();
    }
    static void Main()
    {
        // int n = 50;
        // int[] arr = Helper.CreateRandomIntArray(n);
        // int[] copy = new int[n];
        // arr.CopyTo(copy, 0);

        // Helper.PrintArray(arr);
        // Helper.PrintArray(copy);

        // Sort.MergeSort(arr);
        // Array.Sort(copy);

        // Helper.PrintArray(arr);
        // Console.WriteLine(Test.TestArrayEquals(copy, arr));

        TimeTest();

        // var watch = new System.Diagnostics.Stopwatch();
        // int[] arr = Helper.CreateRandomIntArray(9000*1000);
            
        // watch.Start();
        // Sort.MergeSort(arr);
        // watch.Stop();
        // Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        // watch.Start();
        // Array.Sort(arr);
        // watch.Stop();
        // Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
}

