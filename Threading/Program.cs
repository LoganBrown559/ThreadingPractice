/*
 * 
 * Name: Logan Brown
 * Date: 3/23/2021
 * File: Program.cs
 * Description: The driver to help find pi. Creates threads here
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            int darts;
            int threads;

            Console.WriteLine("Hello! We are going to determine Pi by throwing imaginary darts at a board.");
            Console.WriteLine("Or at least, a quarter of the board.");
            Console.WriteLine();
            
            Console.Write("How many darts per thread will we throw? ");
            darts = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many Threads will there be? ");
            threads = Convert.ToInt32(Console.ReadLine());

            List<Thread> myThreads = new List<Thread>();
            List<FindPiThread> myObjs = new List<FindPiThread>();

            for(int i = 0; i < threads; i++)
            {
                FindPiThread myPi = new FindPiThread(darts);
                myObjs.Add(myPi);

                myThreads.Add(new Thread(new ThreadStart(myPi.throwDarts)));

                myThreads[i].Start();

                Thread.Sleep(16);
            }

            for(int i = 0; i < threads; i++)
            {
                myThreads[i].Join();
            }

            int totalHits = 0;

            for (int i = 0; i < threads; i++)
            {
                totalHits += myObjs[i].dartsLanded;
            }

            Console.WriteLine(totalHits);
            Console.WriteLine(darts);
            Console.WriteLine(threads);

            //This is not clean, but it made it work. And I will take that all day
            double pi = (4 * ((double)totalHits / ((double)darts * (double)threads)));

            Console.WriteLine();
            Console.WriteLine("My estimation of Pi is: " + pi);
        }
    }
}
