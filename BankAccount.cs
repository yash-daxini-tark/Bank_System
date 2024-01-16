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

        public List<Transaction> transactions = new List<Transaction>();

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
            try
            {
                if (Balance < 0)
                {
                    throw new ArgumentOutOfRangeException("You must give balance more than 0");
                }
                this.Balance += Balance;
                transactions.Add(new Transaction(Balance));
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine("You must give balance more than 0");
            }
        }
        public void CreditBalance(double Balance)
        {
            try
            {
                if (Balance < 0)
                {
                    throw new ArgumentOutOfRangeException("You must give balance more than 0");
                }
                if (this.Balance < Balance)
                {
                    throw new InvalidOperationException("Can't Credit because you don't have sufficient balance");
                }
                this.Balance -= Balance;
                transactions.Add(new Transaction(-Balance));
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine("You must give balance more than 0");
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Can't Credit because you don't have sufficient balance");
            }

        }
        public string giveMiniStatement()
        {
            StringBuilder miniStatement = new StringBuilder();
            miniStatement.AppendLine("Transaction Type\t\tAmount\t\tDate & Time ");
            Console.WriteLine("\n**** Transactions Details ****\n");
            foreach (var transaction in transactions)
            {
                miniStatement.AppendLine(transaction.giveTransactionDetails());
            }
            miniStatement.AppendLine("");
            return miniStatement.ToString();
        }
    }
}
