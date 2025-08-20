using System;

namespace ConsoleApp3.OOPS
{
    abstract class Animal
    {
        public abstract void MakeSound(); //abstract 
        public void Sleep() //non abstract
        {
            Console.WriteLine("Sleeping .......");
        }
    }

    class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog is Mewing");
        }
    }

    abstract class BankAccount
    {
        public string AccountNo { get; set; }
        public double Balance { get; set; }

        public abstract void Withdraw(double amount);

        public void Deposit (double amount)
        {
            Balance = amount;
            Console.WriteLine($"Deposited {amount} and new Balance is {Balance}");
        }
    }
    class SavingAccount:BankAccount
    {
        public override void Withdraw(double amount)
        {
           if(Balance-amount>=1000)
            {
                Balance-= amount;
                Console.WriteLine($"Withdraw amount {amount}. Remaining Balance {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for Withdrawal");
            }
        }
    }

    interface Banking
    {
        void Deposit();
        void Withdraw();
    }
    internal class InterfaceExample : Banking
    {
        public void Deposit()
        {
            Console.WriteLine("Hello I am working on Interfae Deposit");
        }

        public void Withdraw()
        {
            Console.WriteLine("Hello I am working on Interfae Withdraw");
        }
    }
}
