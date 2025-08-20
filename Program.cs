using ConsoleApp3.ArrayExamples;
using ConsoleApp3.functionExample;
using ConsoleApp3.Looping;
using ConsoleApp3.MathFunction;
using ConsoleApp3.OOPS;
using ConsoleApp3.Operators;
using ConsoleApp3.Statement;
using ConsoleApp3.StringFunction;
using System;
namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckedUnchecked cu = new CheckedUnchecked();
            cu.CheckedExample();

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
