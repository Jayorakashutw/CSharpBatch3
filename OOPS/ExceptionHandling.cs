using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    public class ExceptionHandling
    {
        int num1, num2,res;
        public void Divide()
        {
            int[] arr = new int[5];
           
            try
            {
                arr[5] = 54;
                Console.WriteLine("Enter two number");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                res = num1 / num2;
                
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Exception is "+ex.Message);
            }
            catch (IndexOutOfRangeException ind)
            {
                Console.WriteLine("Array Index exception " + ind.Message);
            }
            catch(SystemException ex)
            {
                Console.WriteLine("exception is "+ex.Message);
            }

            finally
            {
                Console.WriteLine("Result is " + res);
            }
            
             
        }
    }
}
