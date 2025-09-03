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
        delegate void PrintMsg(string name);
        static void Main(string[] args)
        {

            Property p = new Property();
            p.Name = "Jay Prakash";
            Console.WriteLine("Name is "+p.Name);
            Property p1 = new Property { Address = "Ranchi, Jharkhand" };
            Console.WriteLine(p1.Address);
            //LambdaExample le =new LambdaExample();
            //le.lambdaProgram();

            //PrintMsg message = delegate(string name)
            //{
            //    Console.WriteLine("Testing Anonymous Method with  "+ name);
            //};
            //message("Jay Prakash Pathak");
            //PredicateExample pe = new PredicateExample();
            //pe.PredicateProgram();

            //Func<int, int, double> Add = (a, b) => a + b;
            //double result = Add(45, 85);
            //Console.WriteLine("Sum of two number is " + result);

            //Func<string> msg = () => " C# Programming Class";
            //Console.WriteLine("Message is  " + msg());


            //Action<string> greeting = name => Console.WriteLine("Hello "+name);
            //greeting("Jay Prakash");

            //Predicate<int> isEven = num => num % 2 == 0;
            //Console.WriteLine(isEven(10));
            //Console.WriteLine(isEven(9));


            //Predicate<string> isEmpty = str => string.IsNullOrEmpty(str);
            //Console.WriteLine(isEmpty(""));
            //Console.WriteLine(isEmpty("Rohan Verma"));

            //DelegateExample de = new DelegateExample();
            //DelegateTeam dt = de.PrintMsg;
            //dt("Heelo I am running a program");
            //GenericsExample<int> b = new GenericsExample<int>();
            //b.Add(52);
            //GenericsExample<string> c = new GenericsExample<string>();
            //c.Add("Jay Prakahs");

            //GenericsExample1 ge1 = new GenericsExample1();
            //ge1.Display<int>(54);
            //ge1.Display<char>('C');
            //ge1.Display<string>("Jay Prakash");
            //ge1.Display<double>(47.52);
            //ParamExample pe = new ParamExample();
            //Console.WriteLine(pe.Sum());
            //Console.WriteLine(pe.Sum(1));
            //Console.WriteLine(pe.Sum(1,2,3,4,5,6,7,9));
            //Console.WriteLine(pe.Sum( new int[] {1,5,9,7}));
            //int a = 15;
            //Console.WriteLine("Value before method call "+a);
            //RefOut ro = new RefOut();
            //ro.RefExample(ref a);
            //Console.WriteLine("Value After method call " + a);
            //int a, b;
            //RefOut ro = new RefOut();
            //    ro.OutExample(out a, out b);
            //Console.WriteLine("First Value "+a);
            //Console.WriteLine("Second Value is " + b);
            //Recursion re = new Recursion();
            //Console.WriteLine("Factorial is "+re.Factorial(5));
            //MyThread mt = new MyThread();
            //Thread t1 = new Thread(new ThreadStart(mt.ThreadT));
            //Thread t2 = new Thread(new ThreadStart(mt.ThreadT));
            //Thread t3 = new Thread(new ThreadStart(MyThread.ThreadT));
            //t1.Name = "Rupam";
            //t2.Name = "Rohan";
            //t3.Name = "Om Prakash";
            //t3.Priority = ThreadPriority.Highest;
            //t2.Priority = ThreadPriority.Normal;
            //t1.Priority = ThreadPriority.Lowest;
            // t1.Start();
            //   t1.Join();
            // t2.Start();
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
