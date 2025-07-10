using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Operators
{
    public class Assignment
    {
        int num1, num2;

        public void AssignAdd()
        {
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2=Convert.ToInt32(Console.ReadLine());
            num1 +=  num2; //num1=num1 + num2
            Console.WriteLine("After addition, number is:"+num1); // ("After Addition {0} is ",num1);
        }
    }
}
