using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    public class InvalidAgeExcepiton:Exception
    {
        public InvalidAgeExcepiton(String message):base(message)
        { }
    }
    internal class CustomExceptionExample
    {
        int age;
        public void AcceptAge()
        {
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            if(age<18)
            {
                throw new InvalidAgeExcepiton("Sorry , Age must be greater than 18");
            }
            else
            {
                Console.WriteLine("Your age is valid");
            }
        }
    }
}
