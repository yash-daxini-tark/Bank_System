using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Transaction
    {
        static int transactionId = 1;

        protected double transactionAmount {  get; set; }

        protected DateTime transactionDate;

        public Transaction(double transactionAmount) {
            transactionId += 1;
            this.transactionAmount = transactionAmount;
            transactionDate = DateTime.Now;
        }
        public string giveTransactionDetails()
        {
            return "\nTransaction Type = " + (this.transactionAmount > 0 ? "Debit" : "Credit") + "\nAmount = " + Math.Abs(this.transactionAmount) + "\nDate & Time :- " + this.transactionDate + "\n";
        }
    }
}
