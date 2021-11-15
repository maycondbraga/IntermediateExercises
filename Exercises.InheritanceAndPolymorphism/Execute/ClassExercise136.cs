using Exercises.Inheritance.Entities.Exercise136;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercises.Inheritance.Execute
{
    public class ClassExercise136
    {
        public void Taxes()
        {
            List<TaxPayer> payers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or Company (i/c)? ");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type.ToUpper() == "I")
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpense = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    payers.Add(new Individual(name, annualIncome, healthExpense));
                }
                else
                {
                    Console.Write("Numbers of Employees: ");
                    int totalEmployees = int.Parse(Console.ReadLine());

                    payers.Add(new Company(name, annualIncome, totalEmployees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");

            payers.ForEach(x =>
                Console.WriteLine($"{x.Name} : $ {x.Tax().ToString("F2", CultureInfo.InvariantCulture)}"));

            Console.WriteLine($"\nTOTAL TAXES: {payers.Sum(x => x.Tax()).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
