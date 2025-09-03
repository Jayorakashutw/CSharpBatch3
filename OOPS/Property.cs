using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    internal class Property
    {
        private string name; // fields
        public string Address { get; set; }
        public string Name //property
        {
            get { return name; }
            set { name = value; }
        }

        
    }
}
