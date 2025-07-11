using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Statement
{
    public class ConditionIfElse
    {
        public int age;
        public int num1, num2,res,choice;

        public void ValidAge()
        {
            Console.WriteLine("Enter your age");
            age=Convert.ToInt32(Console.ReadLine());
            if(age>0 && age<=120)
            {
                Console.WriteLine("Valid Age");
            }
        }

        public void GreatestInTwo()
        {
            Console.WriteLine("Enter first number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("First Number is greater " + num1);
            }
            else if(num2>num1)
            {
                Console.WriteLine("Second Number is greater " + num2);
            }
            else
            {
                Console.WriteLine("Both Are equal");
            }
        }
        public void NestedCondition()
        {
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            num1 = Convert.ToInt32(Console.ReadLine());

            if(age>=18)
            {
                if(num1>=80)
                {
                    Console.WriteLine("Get Job");
                }
                else
                {
                    Console.WriteLine("Your marks is not for qualify");
                }
                
            }
            else
            {
                Console.WriteLine("Not Eligible for Job");
            }

        }

        public void SimpleCalculator()
        {
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your choice \n 1. For Addition \n 2 For Subtraction \n 3. For Multiplication \n 4 For Division");
            choice = Convert.ToInt32(Console.ReadLine());
            
            if(choice==1)
            {
                res = num1 + num2;
                Console.WriteLine("Result is " + res);
            }
            else if(choice==2)
            {
                res = num1 - num2;
                Console.WriteLine("Result is " + res);
            }
            else if(choice==3)
            {
                res = num1 * num2;
                Console.WriteLine("Result is " + res);
            }
            else if(choice==4)
            {
                res = num1 / num2;
                Console.WriteLine("Result is " + res);
            }
            else
            {
                Console.WriteLine("Wrong Choice ");
            }
        }
    }
}
