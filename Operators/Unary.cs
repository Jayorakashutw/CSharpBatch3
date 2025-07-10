using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Operators
{
    public class Unary
    {
        int num = 75;
        public void IncrementOperator()
        { 
         Console.WriteLine("Original number is: " + num);
         Console.WriteLine("Value after post increment is :  " + (num++)); // Post-increment: returns the value before incrementing
         Console.WriteLine("Value after pre increment is :  " + (++num)); // Pre-increment: increments the value before returning it

        }
    }
}
