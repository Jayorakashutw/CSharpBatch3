using ConsoleApp3.Operators;
using System;
namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            TernaryRelationalComparisonal trc=new TernaryRelationalComparisonal();
            trc.CheckCarEligibility();
            Console.ReadKey();
        }
    }
}
