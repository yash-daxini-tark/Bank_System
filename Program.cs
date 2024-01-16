using System;

namespace Learning // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount yAccount = new BankAccount("Abc");
            Console.WriteLine(yAccount.Name);
            yAccount.SetName("Yash");
            Console.WriteLine(yAccount.GetBalance());
            yAccount.DebitBalance(1234.0);
            yAccount.CreditBalance(-1);
            Console.WriteLine(yAccount.GetBalance());
            Console.WriteLine(yAccount.giveMiniStatement());
        }
    }
}