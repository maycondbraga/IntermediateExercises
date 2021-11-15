using Exercises.InheritanceAndPolymorphism.Entities;
using System;

namespace Exercises.InheritanceAndPolymorphism.Execute
{
    public class ClassExercise126
    {
        public void UpcastingDowncasting()
        {
            Account acc = new Account(1001, "Maycon", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Douglas", 0.0, 1000.0);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Braga", 0.0, 500.0);
            Account acc3 = new SavingsAccount(1004, "Santos", 0.0, 0.01);

            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            
            // acc2.Loan(100.0); 
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
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
        }
    }
}
