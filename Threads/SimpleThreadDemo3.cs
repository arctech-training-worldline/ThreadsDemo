using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class SimpleThreadDemo3
    {
        internal static void Demo()
        {
            var thread1 = new Thread(Show);
            thread1.Name = "A-Child";

            var thread2 = new Thread(Show);
            thread2.Name = "B-Child";

            thread1.Start(10);
            thread2.Start(20);
        }

        static void Show(object param)
        {
            int num = (int)param;
            for (var i = 1; i <= num; i++)
            {
                Console.Write($"{Thread.CurrentThread.Name}-{i} ");
            }
        }
    }
}
