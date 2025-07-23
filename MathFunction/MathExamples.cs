using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MathFunction
{
    public class MathExamples
    {
        int num;
        public void ExampleProgram()
        {
            num = -4;
            double num1 = 45.2545;
            int a=5,b = 10;

            Console.WriteLine("square of number is "+Math.Pow(num,2));//16
            Console.WriteLine("Cube of number is " + Math.Pow(num, 3));//64
            Console.WriteLine("Square root of number is " + Math.Sqrt(num));//2
            Console.WriteLine("Cube of number is " + Math.PI); //3.14....

            Console.WriteLine("Absolute number is "+Math.Abs(num)); // 4
            Console.WriteLine("Minimum value is " + Math.Min(a, b));//5
            Console.WriteLine("MaXIMUM value is " + Math.Max(a, b));//10
            Console.WriteLine("Round value is " + Math.Round(num1));  //45
            Console.WriteLine("Round value is " + Math.Ceiling(num1)); //46
            Random random = new Random();
            Console.WriteLine("Random Number is "+random.Next(1,100));

        }

        public void AreaCircle()
        {
            double rad;
            Console.WriteLine("Enter radius of circle");
            rad=Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(rad, 2);

            Console.WriteLine("Area of circle is "+Math.Round(area,2));
        }
    }
}
