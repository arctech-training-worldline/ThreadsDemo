using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class NoThreadDemo
    {
        internal static void Demo()
        {
            Show1();
            Show2();

            for (int i = 1; i <= 200; i++)
            {
                Console.Write($"C{i} ");
            }
        }

        private static void Show1()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.Write($"A{i} ");
            }
        }

        private static void Show2()
        {
            for (int i = 1; i <= 500; i++)
            {
                Console.Write($"B{i} ");
            }
        }
    }
}
