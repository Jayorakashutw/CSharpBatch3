using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Statement
{
    public class SwitchCase
    {
        int num1, num2, choice, result;
        char ch;
        public void SimpleCalculator()
        {
            Console.WriteLine("Enter first number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice \n1. For Addition \n2. For Subtraction \n3. For Multiplication \n4. For Division");
            choice=Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:result = num1 + num2;
                    Console.WriteLine("Sum of two number is "+result);
                    break;
                case 2:result = num1 - num2;
                    Console.WriteLine($" Subtraction of two number is "+result);
                    break;
                case 3:result = num1 * num2;
                    Console.WriteLine("Multiplication of two number is {0}",result);
                    break;
                case 4:
                    result = num1 / num2;
                    Console.WriteLine("Division of two number is {0}", result);
                    break;
                default:Console.WriteLine("Wrong Choice");
                    break;
            }
        }

        public void SimpleCalculatorwithChar()
        {
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice \n+ For Addition \n- For Subtraction \n* For Multiplication \n/ For Division");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Sum of two number is " + result);
                    goto case '-';
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($" Subtraction of two number is " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Multiplication of two number is {0}", result);
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine("Division of two number is {0}", result);
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
    }
}
