using System;

namespace HomeWork_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(10, bankAccountType.Чековый);
            Account account2 = new Account(10, bankAccountType.Чековый);
            account2.AccountNumber = account.AccountNumber;

            Console.WriteLine(account == account2);
            Console.WriteLine(account != account2);
            Console.WriteLine(Equals(account, account2));
            Console.WriteLine(account.Equals(account2));
            Console.WriteLine(account.GetHashCode());
        }
    }
}
