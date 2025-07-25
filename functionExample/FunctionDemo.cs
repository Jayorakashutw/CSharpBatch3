using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.functionExample
{
    public class FunctionDemo
    {
        int num1 = 98, num2 = 78;

        //wap to show non return type without parameter

        public void Add()
        {
            Console.WriteLine("Non Return without parameter Sum of two number is  "+(num1+num2));
        }

        //wap to show non return type with parameter

        public void Add(int a,int b)
        {
            
            Console.WriteLine("Non Return with parameter Sum of two number is " + (a+b));
        }
        //wap to show  return type without parameter

        public int Sum()
        {
            return (num1 + num2);
        }

        //wap to show  return type with parameter

        public double Sum(int a, int b)
        {

            return a + b;
        }
    }
}
