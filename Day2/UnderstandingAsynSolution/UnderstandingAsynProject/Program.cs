using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UnderstandingAsynProject
{
    class Program
    {
        void Print1To10()
        {
            for (int i = 11; i <= 20; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(Thread.CurrentThread.Name + "  " + i);
                }
            }
        }
        void Print11To20()
        {
            for (int i = 11; i <= 20; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
        }
        void UseThreadToCallMethods()
        {
            Thread thread1 = new Thread(Print1To10);
            Thread thread2 = new Thread(Print1To10);
            thread1.Name = "T1";
            thread2.Name = "T2";
            thread1.Start();
            thread2.Start();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.UseThreadToCallMethods();
            Console.ReadKey();
        }
    }
}
