using System;

namespace HomeWork2
{
    /// <summary>
    /// Класс банковский счет
    /// </summary>
    class Account
    {
        private int _balance;
        private string _accountNumber;
        private string _accountType;
        private static string _generateAccountNumber;

        public int Balance { get { return _balance; } set { _balance = value; } }
        public string AccountNumber { get {return _accountNumber; } private set { _accountNumber = value; } }
        public string AccountType { get { return _accountType; } set { _accountType = value; } }
        
        public Account(bankAccountType bankAccountType) : this(0)
        {
            this.AccountType = bankAccountType.ToString();
            this.AccountNumber = GenerateAccountNumber();
        }

        public Account(int balance) : this(balance, bankAccountType.Сберегательный)
        {
            this.AccountNumber = GenerateAccountNumber();
        }

        public Account(int balance, bankAccountType AccountType)
        {
           this.Balance = balance;
           this.AccountType = AccountType.ToString();
           this.AccountNumber = GenerateAccountNumber();
        }

        /// <summary>
        /// Снятие со счета
        /// </summary>
        /// <param name="sum">сумма</param>
        public void WithDraw(int sum)
        {
            if (_balance > sum)
            {
                _balance -= sum;
                Console.WriteLine($"Сумма в размере {sum} руб снята со счета ваш баланс составляет {Balance} руб");
            }
            else
            {
                Console.WriteLine("Недостаточно средств для снятия со счета");
            }
        }

        /// <summary>
        /// Пополнение счета
        /// </summary>
        /// <param name="sum">Сумма</param>
        public void DepositACheck(int sum)
        {
            _balance += sum;
            Console.WriteLine($"Ваш счет пополнен в размере {sum} руб, ваш баланс составляет {Balance} руб");
        }

        /// <summary>
        /// Показать информацию о счете
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}, Баланс счета: {Balance} руб, Тип счета: {AccountType}");
        }

        private static string GenerateAccountNumber()
        {
            return _generateAccountNumber = Guid.NewGuid().ToString();
        }
    }
}
