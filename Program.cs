using ConsoleApp3.ArrayExamples;
using ConsoleApp3.functionExample;
using ConsoleApp3.Looping;
using ConsoleApp3.MathFunction;
using ConsoleApp3.OOPS;
using ConsoleApp3.Operators;
using ConsoleApp3.Statement;
using ConsoleApp3.StringFunction;
using System;
using System.Threading;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.ThreadT));
            Thread t2 = new Thread(new ThreadStart(mt.ThreadT));
            //Thread t3 = new Thread(new ThreadStart(MyThread.ThreadT));
            //t1.Name = "Rupam";
            //t2.Name = "Rohan";
            //t3.Name = "Om Prakash";
            //t3.Priority = ThreadPriority.Highest;
            //t2.Priority = ThreadPriority.Normal;
            //t1.Priority = ThreadPriority.Lowest;
            t1.Start();
         //   t1.Join();
            t2.Start();
            //t3.Start();

            //try
            //{
            //    t1.Abort();
            //    t2.Abort();
            //}
            //catch(ThreadAbortException tea)
            //{
            //    Console.WriteLine(tea.ToString());
            //}

            //finally
            //{
            //    Console.WriteLine("Finally Block is running");
            //}
            //ThreadExample te = new ThreadExample();
            //CheckedUnchecked cu = new CheckedUnchecked();
            //cu.CheckedExample();

            //CustomExceptionExample example = new CustomExceptionExample();

            //try
            //{
            //    example.AcceptAge();
            //}
            //catch(InvalidAgeExcepiton e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("rest code is working fine");
            //}

            //ExceptionHandling exceptionHandling = new ExceptionHandling();
            //exceptionHandling.Divide();

            //InterfaceExample ie = new InterfaceExample();
            //ie.Deposit();
            //ie.Withdraw();
            //SavingAccount acc = new SavingAccount();
            //acc.AccountNo = "A001";
            //acc.Deposit(15000);
            //acc.Withdraw(2000);

            //Dog d = new Dog();
            //d.MakeSound();
            //Cat c = new Cat();
            // c.MakeSound();
            //Polymorphism pm = new Polymorphism();
            //pm.Add();
            //pm.Add(45, 54);
            //pm.Add(154.5, 85.6);
            //Polymorphism pm1 = new Polymorphism(54);
            //Polymorphism pm2 = new Polymorphism("Jay Prakash");

            //RBI sbi = new SBI();
            //sbi.InterestRate();

            //RBI icici = new ICICI();
            //icici.InterestRate();

            //RBI s = new SC();
            //s.InterestRate();

            Console.ReadKey();
            
        }
    }
}
