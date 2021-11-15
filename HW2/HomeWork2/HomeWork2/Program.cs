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
            account2.DepositACheck(100);
            Console.WriteLine();

            Account account3 = new Account(bankAccountType.Инвестиционный);
            account3.Display();
            account3.WithDraw(15);
            Console.WriteLine();
            
            Account account4 = new Account(bankAccountType.Чековый);
            account4.Display();
            account4.DepositACheck(150);
        }
    }
}
