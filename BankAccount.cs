using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class BankAccount
    {
        private List<Transaction> transactions = new List<Transaction>();
        public long AccountNumber { get; }
        public string Owner { get; set; }
        public bool Status { get; set; } = true;
        public int Balance
        {
            get
            {
                int balance = 0;
                foreach (var trans in transactions)
                {
                    balance = balance + trans.Amount;
                }
                return balance;
            }
        }
        public void Deposit(int amount, string note)
        {
            var deposit = new Transaction(amount, note);
            transactions.Add(deposit);
        }
        public void Withdraw(int amount, string note)
        {
            var withDraw = new Transaction(-amount, note);
                transactions.Add(withDraw);
        }
        private long GenerateAccountNumber()
        {
            Random rand = new Random();
            return rand.Next(1000);
        }
        public BankAccount(string owner, int initialBalance)
        {
            this.Owner = owner;
            this.Deposit(initialBalance, "Initial Balance");
            this.AccountNumber = GenerateAccountNumber();
            System.Console.WriteLine($"Object initialized with : \n AccountNumber: {this.AccountNumber} \n Owner: {this.Owner} \n Balance: {this.Balance} \n Status: {this.Status}");

        }

    }
}
