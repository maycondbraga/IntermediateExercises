using System;
using System.Globalization;
using Exercises.Compositions.Entities.Exercise120;
using Exercises.Compositions.Enum;

namespace Exercises.Compositions.Execute
{
    public class ClassExercise120
    {
        /// <summary>
        /// Create a new file for the worker and add their income to calculate over a period of time
        /// </summary>
        public static void LaborAccounting()
        {
            Console.Write("Enter department's name: ");
            Department _department = new Department(Console.ReadLine());

            Console.WriteLine("\nEnter worker data:");

            Console.Write("\nName: ");
            string _name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel _level = System.Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double _salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(_name, _level, _salary, _department);

            Console.Write("\nHow many contracts to this worker? ");
            int totalContract = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalContract; i++)
            {
                HourContract contract = new HourContract();

                Console.WriteLine($"\nEnter #{i} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                contract.Date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                contract.ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                contract.Hours = int.Parse(Console.ReadLine());

                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string[] period = Console.ReadLine().Split('/');

            string income = worker.Income(int.Parse(period[1]), int.Parse(period[0])).ToString("F2", CultureInfo.InvariantCulture);

            Console.WriteLine($"Name: {worker.Name} " +
                              $"\nDepartment: {worker.Department.Name} " +
                              $"\nIncome for {string.Join('/', period)}: {income}");
        }
    }
}
