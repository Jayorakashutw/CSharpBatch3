using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.StringFunction
{
    public class StringExample
    {
        string fname = "Jay Prakash";
        string lname = "Pathak";
        public void StringManupulation()
        {
            string fullname = fname + " " + lname; //concatenation

            int age = 25;
            string info = $"your age is {age}";
            Console.WriteLine(info);// your age is 25

            Console.WriteLine(fname.Length);

            Console.WriteLine(fname.ToUpper());
            Console.WriteLine(lname.ToLower());

            Console.WriteLine(fullname.Contains("Prakash"));

            Console.WriteLine(fullname.Replace("Prakash", "Light"));

            Console.WriteLine(fullname.Substring(3));

            foreach (char c in lname)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(fullname.StartsWith("Jay"));
            Console.WriteLine(fullname.EndsWith("Pathak"));

            Console.WriteLine(fullname.IndexOf("k"));//first occurance /apperance
            Console.WriteLine(fullname.LastIndexOf("k"));//last occurance or apperance

            Console.WriteLine(fullname.Substring(3, 12));

            string value = "    Hello Students      ";
            Console.WriteLine(value);
            Console.WriteLine(value.Trim());
            Console.WriteLine(value.TrimEnd());
            Console.WriteLine(value.TrimStart());


            string a = "Jay";
            string b = "jay";

            Console.WriteLine(a.Equals(b));//false
            Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(a == b);

            Console.WriteLine(a.Insert(3, " Prakash"));

            string text = "Udesha Technology";
            Console.WriteLine(text.Remove(6));
            Console.WriteLine(text.Remove(7,3));

            Console.WriteLine(string.Compare("abcd","ABCD",true));

        }
        //Jay Prakash Pathak    J.P. Pathak
        public void Interview()
        {
            string fullname = "Jay Prakash Pathak";
            //string[] names = fullname.Split(' ');
            //string shortname = $"{names[0][0].ToString().ToUpper()}.{names[1][0].ToString().ToUpper()}. {names[2]}";
            string names = " " + fullname;
            string shortname = "";
            int count = 0;
            foreach(char c in names)
            {
                if(c==' ')
                {
                    count++;
                    if(count<3)
                    {
                        shortname=shortname.Substring(0,count);
                    }
                }
            }
            //Console.WriteLine(shortname);
           // Console.WriteLine(fullname);
        }
    }
}
