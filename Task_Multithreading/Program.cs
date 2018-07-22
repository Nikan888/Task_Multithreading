using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_Multithreading
{
    class Program
    {
        static void MyThread1()
        {
            //Console.WriteLine("/// First algorithm ///");
            long firstGCD = GCDComputer.FirstGCD(65, 74);
            Console.WriteLine("GCD = {0}", firstGCD);
            //Console.WriteLine("///////////////////////////////////////////////////////////////////////");
        }

        static void MyThread2()
        {
            //Console.WriteLine("/// Second algorithm ///");
            long secondGCD = GCDComputer.SecondGCD(32, 78);
            Console.WriteLine("GCD = {0}", secondGCD);
        }

        static void MyThread3()
        {
            //Console.WriteLine("/// Third algorithm ///");
            long thirdGCD = GCDComputer.ThirdGCD(25, 45);
            Console.WriteLine("GCD = {0}", thirdGCD);
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Thread thread1 = new Thread(MyThread1);
            Thread thread2 = new Thread(MyThread2);
            Thread thread3 = new Thread(MyThread3);

            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.AboveNormal;
            thread3.Priority = ThreadPriority.Highest;

            stopwatch.Start();

            thread1.Start();
            thread2.Start();
            thread3.Start();

            //Console.WriteLine("/// Euqlid algorithm ///");
            long euqlidGCD = GCDComputer.EuqlidGCDRec(63, 77);
            Console.WriteLine("GCD = {0}", euqlidGCD);

            stopwatch.Stop();
            Console.WriteLine("Elapsed = {0}", stopwatch.Elapsed);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
