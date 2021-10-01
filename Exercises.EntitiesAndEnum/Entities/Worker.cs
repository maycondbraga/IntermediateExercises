using System.Collections.Generic;
using Exercises.Compositions.Entities.Enums;

namespace Exercises.Compositions.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        /// <summary>
        /// Adds a new contract to the worker's contract list
        /// </summary>
        /// <param name="contract"></param>
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        /// <summary>
        /// Removes a existing contract to the worker's contract list
        /// </summary>
        /// <param name="contract"></param>
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        /// <summary>
        /// Sum the worker's income in a given month of the year
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public double Income(int year, int month)
        {
            double income = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    income += contract.TotalValue();
                }
            }

            return income;
        }
    }
}
