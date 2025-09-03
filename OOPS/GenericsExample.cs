using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    public class GenericsExample<T>
    {
        private T items;
        public void Add(T value)
        {
            items = value;
            Console.WriteLine(items);
        }
    }

    public class GenericsExample1
    {
      
        public void Add<T>(T value)
        {         
            Console.WriteLine(value);
        }
    }
}
