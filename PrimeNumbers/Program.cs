﻿using System;
using System.Diagnostics;
using System.Threading;
using Exercise;
using Concurrent;
//using Solution;

/// <summary>
/// This example implements a concurrent version of finding and printing prime-numbers between two given numbers.
/// </summary>
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int min = 5, max = 100000;

            ConPrimeNumbers pn = new ConPrimeNumbers();

            pn.runSequential(min, max);

            Thread.Sleep(5000);
            // Stopwatch sw = new Stopwatch();
            // sw.Start();
            pn.runConcurrent(min, max);
            // sw.Stop(); 
            // Console.WriteLine("Time for concurrent version is {0} msec,", sw.ElapsedMilliseconds);

        }
    }
}
