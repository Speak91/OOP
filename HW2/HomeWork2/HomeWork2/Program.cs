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

        public Account()
        {
            GeneateAccountNumber();
        }

        public void MakeADeposit(int balance, bankAccountType AccountType)
        {
             
            _balance = balance;
            _accountNumber = _generateAccountNumber;
            _accountType = AccountType.ToString();
        }

        public void Display ()
        {
            Console.WriteLine($"Номер счета: {_accountNumber}, Баланс счета: {_balance} рублей, Тип счета: {_accountType}");
        }

        private static void GeneateAccountNumber()
        {
            Random random = new Random();
            _generateAccountNumber = Guid.NewGuid().ToString();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Account account = new Account();
            account.MakeADeposit(100, bankAccountType.Сберегательный);
            account.Display();

            Account account2 = new Account();
            account.MakeADeposit(100, bankAccountType.Инвестиционный);
            account.Display();
        }
    }
}
