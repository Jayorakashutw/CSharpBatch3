using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    public delegate void DelegateTeam(string msg);

    public class DelegateExample
    {
        public void PrintMsg(string msg)
        {
            Console.WriteLine(msg);
        }

       
    }

    public class PredicateExample
    {
        public void PredicateProgram()
        {
            List<int> number = new List<int> { 12,15,78,698,35,12};
            Predicate<int> isGreaterThan18 = x=>x>18;
            int result = number.Find(isGreaterThan18);

            Console.WriteLine("Greater than 18 is "+result);
        }
    }
    public class LambdaExample
    {
        public void lambdaProgram() // (parameter)=>expression
        {
            List<int> number = new List<int> { 12, 15, 78, 69, 35, 12 };
            List<int> everNumber = number.FindAll(x=>x%2==0);

            Console.WriteLine("Even numbers  ");
            foreach(int a in everNumber)
            {
                Console.WriteLine(a);
            }
        }
    }

}
