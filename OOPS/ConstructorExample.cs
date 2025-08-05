using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    public class ConstructorExample
    {
        int num;
        public ConstructorExample(int number)
        {
            Console.WriteLine(" Hello I am Jay Prakash");
            num = number;
        }

        public ConstructorExample( ConstructorExample cee)
        {
            Console.WriteLine("Copy COnstructor is running");
            num = cee.num+45;
        }
        public void Example()
        {
            Console.WriteLine("Number is "+num);
        }
    }
}
