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
        private string _accountNumber;
        private string _accountType;
        private static string _generateAccountNumber;

        public Account(bankAccountType bankAccountType) : this(0)
        {
            _accountType = bankAccountType.ToString();
            _accountNumber = GenerateAccountNumber();
        }

        public Account(int balance) : this(balance, bankAccountType.Сберегательный)
        {
            _accountNumber = GenerateAccountNumber();
        }

        public Account(int balance, bankAccountType AccountType)
        {
            _balance = balance;
            _accountType = AccountType.ToString();
            _accountNumber = GenerateAccountNumber();
        }

        public void Display()
        {
            Console.WriteLine($"Номер счета: {_accountNumber}, Баланс счета: {_balance} рублей, Тип счета: {_accountType}");
        }

        private static string GenerateAccountNumber()
        {
            return _generateAccountNumber = Guid.NewGuid().ToString();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Account account = new Account(10, bankAccountType.Чековый);
            account.Display();

            Account account2 = new Account(50);
            account2.Display();

            Account account3 = new Account(bankAccountType.Инвестиционный);
            account3.Display();

            Account account4 = new Account(bankAccountType.Чековый);
            account4.Display();
        }
    }
}
