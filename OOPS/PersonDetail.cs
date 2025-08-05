using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPS
{
    public class PersonDetail
    {
        protected string name, address, gender, parentsname, phoneno;
        protected int age;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Your Name");
            name=Console.ReadLine();
            Console.WriteLine("Enter Your Father's Name");
            parentsname = Console.ReadLine();
            Console.WriteLine("Enter Your Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter Your gender");
            gender = Console.ReadLine();
            Console.WriteLine("Enter Your Phoneno");
            phoneno = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name is \t" + name);
            Console.WriteLine("Parents Name is \t" + parentsname);
            Console.WriteLine("Age is \t" + age);
            Console.WriteLine("Address is \t" + address);
            Console.WriteLine("Gender is \t" + gender);
            Console.WriteLine("Phone No is \t" + phoneno);
        }
    }

    public class Employee : PersonDetail
    {
        string empid, department, designation;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Employee ID");
            empid = Console.ReadLine();
            Console.WriteLine("Enter Department");
            department = Console.ReadLine();
            Console.WriteLine("Enter Designation");
            designation = Console.ReadLine();
            base.AcceptDetails();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("EmployeeID is \t" + empid);
            Console.WriteLine("Designation is \t" + designation);
            Console.WriteLine("Department is \t" + department);
            base.DisplayDetails();
        }
    }
}
