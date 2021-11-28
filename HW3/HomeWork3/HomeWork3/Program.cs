using System;

namespace HomeWork2
{
    class Program
    {

        static void Main(string[] args)
        {
            Account account = new Account(10, bankAccountType.Чековый);
            account.Display();
            account.WithDraw(5);
            account.WithDraw(15);
            Console.WriteLine();

            Account account2 = new Account(50);
            account2.Display();
            account2.DepositACheck(1000);
            Console.WriteLine();

            Account account3 = new Account(bankAccountType.Инвестиционный);
            account3.Display();
            account3.DepositACheck(500);
            account3.TransferFundsToCurrentAccount(account2, 500); //Снимаем деньги со счета
            account3.Display();
            Console.WriteLine();
            account2.Display();
        }
    }
}
