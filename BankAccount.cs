using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class BankAccount
    {
        public static int Id = 1;
        public string Name { get; set; }

        private double Balance { get; set; }
        
        public List<Transaction> transactions  = new List<Transaction>();

        public BankAccount(string Name)
        {
            this.Name = Name;
            Id = Id + 1;
        }

        public double GetBalance() { return Balance; }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void DebitBalance(double Balance)
        {
            if (Balance < 0)
            {
                throw new ArgumentOutOfRangeException("You must give balance more than 0");
            }
            this.Balance += Balance;
            transactions.Add(new Transaction(Balance));
        }
        public void CreditBalance(double Balance)
        {
            if(Balance < 0)
            {
                throw new ArgumentOutOfRangeException("You must give balance more than 0");
            }
            if(this.Balance < Balance)
            {
                throw new InvalidOperationException("Can't Credit because you don't have sufficient balance");
            }
            this.Balance -= Balance;
            transactions.Add(new Transaction(-Balance));
        }
        public void giveMiniStatement()
        {
            foreach (var transaction in transactions)
            {
                Console.WriteLine("\n**** Transactions Details ****");
                Console.WriteLine(transaction.giveTransactionDetails());
            }
        }
    }
}
