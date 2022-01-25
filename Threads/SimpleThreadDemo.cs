using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class SimpleThreadDemo
    {
        internal static void Demo()
        {
            var thread1 = new Thread(Show1);
            var thread2 = new Thread(Show2);
            
            thread1.Start();
            thread2.Start();

            for (var i = 1; i <= 200; i++)
            {
                Console.Write($"C{i} ");
            }
        }

        static void Show1()
        {
            for (var i = 1; i <= 1000; i++)
            {
                Console.Write($"A{i} ");
            }
        }

        static void Show2()
        {
            for (var i = 1; i <= 500; i++)
            {
                Console.Write($"B{i} ");
            }
        }
    }
}
