using System;
using System.Diagnostics;
using System.Threading;
using Exercise;

namespace Concurrent
{
    public class ConPrimeNumbers : PrimeNumbers
    {
        public ConPrimeNumbers()
        {
        }
        /// <summary>
        /// This method 
        /// </summary>
        /// <param name="m"> is the minimum number</param>
        /// <param name="M"> is the maximum number</param>
        /// <param name="nt"> is the number of threads. For simplicity assume two.</param>
        public void runConcurrent(int m, int M)
        {
            // Todo 1: Create two threads, define their segments and start them. Join them all to have all the work done.
            
            Thread minimum = new Thread(() => PrimeNumbers.printPrimes(m, M/2));
            Thread maximum = new Thread(() => PrimeNumbers.printPrimes(M/2, M));
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            minimum.Start();
            maximum.Start();
            minimum.Join();
            maximum.Join();
            
            sw.Stop();
            Console.WriteLine("Time for concurrent version is {0} msec,", sw.ElapsedMilliseconds);

        }

    }
}
