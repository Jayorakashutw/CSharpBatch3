using ConsoleApp3.Operators;
using ConsoleApp3.Statement;
using System;
namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            JumpStatement js = new JumpStatement();
            js.PrimeNo();
            Console.ReadKey();
        }
    }
}
