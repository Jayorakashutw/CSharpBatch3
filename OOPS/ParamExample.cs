using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    internal class ParamExample
    {
        public int Sum( params int[] numbers)
        {
            int total = 0;
            foreach (var n  in numbers)
            {
                total = total + n;
            }
            return total;
        }
    }
}
