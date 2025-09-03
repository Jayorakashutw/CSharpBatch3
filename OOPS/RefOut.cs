using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    internal class RefOut
    {
        public void OutExample(out int x,out int y)
        {
            x = 10;
            y = 10;
        }

        public void RefExample(ref int num)
        {
            num = num + 10;
        }
    }
}
