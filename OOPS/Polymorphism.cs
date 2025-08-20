using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    //overriding
    public class RBI
    {
        
        public virtual void InterestRate()
        {
            Console.WriteLine("RBI Interest Rate");
        }
    }

    public class SBI:RBI
    {
        public override void InterestRate()
        {
            Console.WriteLine("SBI Bank Interest Rate is 8.6%");
        }
    }
    public class ICICI : RBI
    {
        public override void InterestRate()
        {
            Console.WriteLine("ICICI Bank Interest Rate is 8.76%");
        }
    }
    public class SC : RBI
    {
        public override void InterestRate()
        {
            Console.WriteLine("SC Bank Interest Rate is 9.6%");
        }
    }
    public class Polymorphism
    {
        //constructro Overloading
       public Polymorphism()
        {
            Console.WriteLine("Basic Polymorphism Overloading");
        }

        public Polymorphism(int num)
        {
            Console.WriteLine("Basic Polymorphism Overloading with 1 integer "+num);
        }

        public Polymorphism(string uname)
        {
            Console.WriteLine("Basic Polymorphism Overloading with 1 string " + uname);
        }
        //method overloading
        public void Add()
        {
            Console.WriteLine("Add is working");
        }
        public void Add(int a,int b)
        {
            Console.WriteLine("Adding integer" +(a+b));
        }
        public void Add(double a, double b)
        {
            Console.WriteLine("Adding double "+(a+b));
        }
    }
}
