using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class SimpleThreadDemo2
    {
        internal static void Demo()
        {
            var thread1 = new Thread(Show);
            thread1.Name = "A-Child";
            
            var thread2 = new Thread(Show);
            thread2.Name = "B-Child";
            
            thread1.Start();
            thread2.Start();
        }

        static void Show()
        {
            for (var i = 1; i <= 500; i++)
            {
                Console.Write($"{Thread.CurrentThread.Name}-{i} ");
            }
        }
    }
}
