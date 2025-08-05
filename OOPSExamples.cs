using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    //abstraction Example
    abstract class Interest
    {
        public abstract void InteresetRate(); //abstract method with no body
    }

     class SBIBank:Interest
    {
        public override void InteresetRate()
        {
            Console.WriteLine("SBI Bank Interest Rate is "+8.5);   
        }
    }
    class ICICIBank : Interest
    {
        public override void InteresetRate()
        {
            Console.WriteLine("ICICI Bank Interest Rate is " + 8.75);
        }
    }
    /*
     1. Interest class hides the implementation of InterestRate();
     2. Only the behaviour (method name) is exposed
     3. Actual logic is implemented in the Dog class
     4. This is abstraction
     */

    //Example of Encapsulation
    class BankAccount
    {
        private double balance;// private field ( data hiding)
        private double amount;
        public void Deposit (double amount)
        {
            if(amount>0)
            {
                balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            this.amount=amount;
            if (this.amount <= balance)
            {
                balance -= this.amount;
            }
        }

        public double GetBalance( )
        {

            return balance;
        }
    }
    /*
     Explanation
       1. balance is private ( cant access directly )
       2. to Access balance , it allows only through Deposite(), Withdraw(), GetBalance() methods;
       3. This is encapsulation - Protection and controlling access
     */
    /*
       What is does

        A - Hides implementation details
        E - Hides data using access modifier

       Focus 

        A - On what an Object does
        E - On how data is Protected
     
       Achieved by

        A -  abstract class or Interface
        E - Private fields , public method

        
     */
}
