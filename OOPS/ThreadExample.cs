using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    public class MyThread
    { 
      public void ThreadT()
        {
            //Thread t = Thread.CurrentThread;
            //Console.WriteLine(" Running thread name " + t.Name);
            lock(this)
            {
                for (int i = 0; i <= 5; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i);

                }
            }
           
        }
    }
    internal class ThreadExample
    {
        public ThreadExample()
        {
            Thread t= Thread.CurrentThread;
            t.Name = " C# Main Thread";
            Console.WriteLine(" Thread name is "+ t.Name);
        }
    }
}
