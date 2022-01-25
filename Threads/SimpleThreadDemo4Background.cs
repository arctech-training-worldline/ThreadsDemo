using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class SimpleThreadDemo4Background
    {
        internal static void Demo()
        {
            Thread.CurrentThread.Name = "C";
            var thread1 = new Thread(Show);
            thread1.Name = "A";
            thread1.IsBackground = true;

            var thread2 = new Thread(Show);
            thread2.Name = "B";
            thread2.IsBackground = true;

            thread1.Start();
            thread2.Start();

            for (var i = 1; i <= 10; i++)
            {
                Console.Write($"{Thread.CurrentThread.Name}{i} ");
            }
        }

        static void Show()
        {
            for (var i = 1; i <= 500; i++)
            {
                Thread.Sleep(10);
                Console.Write($"{Thread.CurrentThread.Name}{i} ");
            }
        }
    }
}
