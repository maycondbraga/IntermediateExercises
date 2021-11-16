using Exercises.Exception.Exceptions;

namespace Exercises.Exception.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
                throw new WithdrawException("Not enough balance");
            if (WithdrawLimit < amount)
                throw new WithdrawException("The amount exceeds withdraw limit");

            Balance -= amount;
        }
    }
}
