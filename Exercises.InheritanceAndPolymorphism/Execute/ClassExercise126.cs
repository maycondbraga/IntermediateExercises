using Exercises.Inheritance.Entities.Exercise126;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercises.Inheritance.Execute
{
    public class ClassExercise126
    {
        public void UpcastingDowncasting()
        {
            // UPCASTING
            Account acc2 = new BusinessAccount(1003, "Braga", 0.0, 500.0);
            Account acc3 = new SavingsAccount(1004, "Santos", 0.0, 0.01);

            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            
            // acc2.Loan(100.0); 
            acc4.Loan(100.0);

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            else if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            //CLASS EXERCISE 133
            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            accounts.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            accounts.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            accounts.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

            double sum = accounts.Sum(x => x.Balance);
            Console.WriteLine("\nTotal Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            accounts.ForEach(x => x.Withdraw(10));
            double sumUpdated = accounts.Sum(x => x.Balance);

            accounts.ForEach(x => 
            Console.WriteLine($"\nUpdated balance for account: {x.Number}: {x.Balance.ToString("F2", CultureInfo.InvariantCulture)}"));
        }
    }
}
