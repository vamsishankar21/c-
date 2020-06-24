using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            var account = new BankAccount("Vamsi", 1000);
            System.Console.WriteLine("Account created");
            account.Deposit(3000, "Added from friende");
            account.Withdraw(100, "Withdrawed");
            Console.WriteLine(account.Balance);
            Console.WriteLine("Withdrawed");
            account.Withdraw(120, "bought online");
            Console.WriteLine(account.Balance);
            Console.ReadLine();

        }
    }
}
