using ConsoleApp3.ArrayExamples;
using ConsoleApp3.functionExample;
using ConsoleApp3.Looping;
using ConsoleApp3.MathFunction;
using ConsoleApp3.Operators;
using ConsoleApp3.Statement;
using ConsoleApp3.StringFunction;
using System;
namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            FunctionDemo fd = new FunctionDemo();
            int res = fd.Sum();
            Console.WriteLine("Return type without Parameter  sum exampe "+ res);
            double result = fd.Sum(544, 78);
            Console.WriteLine("Retrun type with Paramter  sum example " + result);
            Console.ReadKey();
        }
    }
}
