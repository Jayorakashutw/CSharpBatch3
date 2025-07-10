using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Operators
{
    public class TernaryRelationalComparisonal
    {
        //syntax: condition ? expression1 : expression2;
        int age, num1, num2, res;
        string result;
        public void ValidAge()
        { 
          Console.WriteLine("Enter your age:");
          age=Convert.ToInt32(Console.ReadLine());
          result=(age>=1 && age<=120) ? "Your age is valid." : "Your age is invalid";
          Console.WriteLine(result);
        }

        public void CompareTwoNumbers()
        { 
          Console.WriteLine("Enter first number:");
          num1=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter second number:");
          num2=Convert.ToInt32(Console.ReadLine());
          res=(num1>num2) ? num1 : num2; //returns the greater of the two numbers 

            Console.WriteLine($"The greater number is: {res}");
        }
        public void CompareThreeNumbers()
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int greatest = (num1 > num2 && num1 > num3) ? num1 : (num2 > num1 && num2 > num3) ? num2 :num3; // returns the greatest of the three numbers

            Console.WriteLine($"The greatest number is: {greatest}");
        }

        public void CheckCarEligibility()
        {
            Console.WriteLine("Enter employee salary:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee department:");
            string department = Console.ReadLine();

            string eligibility = (salary > 100000 || department.Equals("sales"))
                ? "Eligible for car."
                : "Not eligible for car.";

            Console.WriteLine(eligibility);
        }
    }
}
