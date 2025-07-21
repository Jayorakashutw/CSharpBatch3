using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Looping
{
    public class LoopingExamples
    {
        int num;
        public void NaturalNoWhile()
        {
            num = 1; //initilization
            while (num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }
        }
        public void NaturalNoFor()
        {
            for(num=1;num<=10; num++)
            {
                Console.WriteLine(num);
            }
        }
        public void NaturalNoDowhile()
        {
            num = 51;
            do
            {
                Console.WriteLine(num);
                num++;
            }while (num <= 10);
        }

        //wap to accept a number and display its table

        public void TableOfNumber()
        {
            Console.WriteLine("Enter a number whose table you want");
            int tableno = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Table of {0} is below",tableno);

            for(num=1;num<=10;num++)
            {
                Console.WriteLine(num*tableno);
            }
        }

        //wap to accept a number and check whether it is Prime or not

        public void PrimeNo()
        {
            Console.WriteLine("Enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isprime = true;
            if(number<=1)
            {
                isprime = false;
            }
            else
            {
                for(num=2;num<number;num++)
                {
                    if(number%num==0)
                    {
                        isprime = false;
                        break;
                    }
                }
            }

            if(isprime)
            {
                Console.WriteLine("Prime No");
            }
            else
            {
                Console.WriteLine("Not Prime No");
            }
        }

        //interview questions
        //121 , 12321 , 785 -> 587  , 161 ->161

        public void reverseno()
        {
            int res = 0,rem;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                rem = num % 10;
                Console.WriteLine( rem );
                res = res * 10 + rem;
                Console.WriteLine(res);
                num = num / 10;
                Console.WriteLine(num);
                Console.WriteLine("______________________________");
            }

            Console.WriteLine("Finally Number after reverse is " + res);
        }
        public void Palindrom()
        {
            int res = 0, rem;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            while (num != 0)
            {
                rem = num % 10;
                res = res * 10 + rem;
                num = num / 10;
            }
            if(temp==res)
            {
                Console.WriteLine("Number is palindrom");
            }
            else
            {
                Console.WriteLine("Number is not palindrom");
            }
        }

        //wap to display sum of all the digit of a number

        public void DigitSum()
        {
            int res = 0, rem;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                Console.WriteLine(rem);
                res = res + rem;
                Console.WriteLine(res);
                num = num / 10;
                Console.WriteLine(num);
                Console.WriteLine("______________________________");
            }

            Console.WriteLine("Finally Sum of Digit " + res);
        }

        //wap to creat right angle triangle
        /*
            *
            **
            ***
            ****
            *****
         */

        public void Pattern1()
        {
            int i, j;
            for(i = 1; i <= 5; i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        /*
            *****
            ****
            ***
            **
            *
         */
        public void Pattern2()
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        /*
            1
            12
            123
            1234
            12345
        */

        public void Pattern3()
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
        /*
            1 
            2 3
            4 5 6
            7 8 9 10
            11 12 13 14 15
         
         */

        public void Pattern4()
        {
            int i, j,num=1;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(num++ + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
