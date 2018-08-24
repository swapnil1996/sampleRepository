using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace funWithThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Thread slave = new Thread(funThreads);
            slave.Start();
            funThreads();
            Console.WriteLine("Hello world again");
            Console.WriteLine();

        }
        public static void funThreads()
        {
            Thread.Sleep(10000);
            Console.WriteLine("This is through thread");
            Console.ReadLine();
        }
    }
}
