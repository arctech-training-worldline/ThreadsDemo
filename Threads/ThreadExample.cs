using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class ThreadExample
    {
        static void Show()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.Write($"A{i} ");
            }
        }

        static void Jump()
        {
            for (int i = 1; i <= 500; i++)
            {
                Console.Write($"B{i} ");
            }
        }

        public static void Demo()
        {
            Thread t1 = new Thread(Show); // by default foreground thread
            Thread t2 = new Thread(Show); // by default foreground thread
            //t1.IsBackground = true;
            //t2.IsBackground = true;

            t1.Start();
            t2.Start();

            for (int i = 1; i <= 500; i++)
            {
                Console.Write($"C{i} ");
            }
        }
    }
}

