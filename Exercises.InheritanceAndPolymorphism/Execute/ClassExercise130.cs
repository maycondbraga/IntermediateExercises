using Exercises.Inheritance.Entities.Exercise130;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercises.Inheritance.Execute
{
    public class ClassExercise130
    {
        /// <summary>
        /// Exercise to get employee information and then return values
        /// </summary>
        public void LoadPayment()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int total = int.Parse(Console.ReadLine());

            for(int i = 0; i < total; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Oursourced (y/n)? ");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type.ToUpper() == "Y")
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
