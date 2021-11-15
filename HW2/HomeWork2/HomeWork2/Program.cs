using System;

namespace HomeWork2
{
    /// <summary>
    /// Типы банковских счетов 
    /// </summary>
    public enum bankAccountType
    {
        /// <summary>
        /// Это сберегательный счет для длительного хранения денег
        /// </summary>
        Сберегательный,
        
        /// <summary>
        /// Это инвестиционный счет
        /// </summary>
        Инвестиционный,

        /// <summary>
        /// Чековый счет
        /// </summary>
        Чековый
    }

    /// <summary>
    /// Класс банковский счет
    /// </summary>
    class Account
    {
        private int _balance;
        private int _accountNumber;
        private string _accountType;
       
        public void MakeADeposit(int accountNumber, int balance, bankAccountType AccountType)
        {
             
            _balance = balance;
            _accountNumber = accountNumber;
            _accountType = AccountType.ToString();
        }

        public void Display ()
        {
            Console.WriteLine($"Номер счета: {_accountNumber}, Баланс счета: {_balance} рублей, Тип счета: {_accountType}");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Account account = new Account();
            account.MakeADeposit(100, 124124124, bankAccountType.Сберегательный);
            account.Display();
        }
    }
}
