using ConsoleApp3.ArrayExamples;
using ConsoleApp3.functionExample;
using ConsoleApp3.Looping;
using ConsoleApp3.MathFunction;
using ConsoleApp3.OOPS;
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
            Employee emp = new Employee();
            emp.AcceptDetails();
            emp.DisplayDetails();
            Console.ReadKey();
            
        }
    }
}
