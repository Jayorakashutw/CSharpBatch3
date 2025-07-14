using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Statement
{
    public class JumpStatement
    {
        //goto ,continue, break ( will cover in loop ), return (in function )
        int num;

        public void NaturalUpto10()
        {
            num = 1;
        number:
            Console.WriteLine(num);
            num++;
            if(num<=10)
                goto number;
        }

        //wap to display table of a number
        public void Table()
        {
            Console.WriteLine("Enter a number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            num = 1;
            Console.WriteLine("Table of {0} is below",num1);
        number:
            Console.WriteLine(num * num1);
            num++;
            if (num <= 10)
                goto number;
        }
        //wap to accept a number and check whether it is prime or not

        public void PrimeNo()
        {
            int i = 2;
            Console.WriteLine("Enter a number ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num<=1)
            {
                Console.WriteLine("Number is not prime");
                return;
            }
            check:
             
            if(i<=num/2)
            {
                if(num%i==0)
                {
                    Console.WriteLine(num + " is not a prime number");
                    return ;
                }
                i++;
                goto check;
            }

            Console.WriteLine(num+" is prime number");
        }
    }
}
