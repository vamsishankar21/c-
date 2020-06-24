using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Transaction
    {
        public int Amount { get; set; }
        public string Note { get; set; }
        public Transaction(int amount, string note)
        {
            this.Amount = amount;
            
            this.Note = note;
        }
    }
}
