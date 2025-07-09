using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Operators
{
    public class Arithmatic
    {
        int num1, num2, result;
        //wap to accept two numbers and perform addition
        public void Addition()
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }

        //wap to accept two numbers and perform subtraction

        public void Subtraction()
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int difference = num1 - num2;
            Console.WriteLine($"The difference between {num1} and {num2} is: {difference}");
        }
    }
}
