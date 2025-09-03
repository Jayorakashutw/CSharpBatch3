using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    internal class Recursion
    {
        public int Factorial(int n)
        {
            if(n==0 || n==1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1); 
            }
        }
    }
}
