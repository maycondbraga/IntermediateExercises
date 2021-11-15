namespace Exercises.Inheritance.Entities.Exercise136
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpense) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpense;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000.0)
                return (AnnualIncome * 0.15) - HealthExpenditures * 0.5;
            else
                return (AnnualIncome * 0.25) - HealthExpenditures * 0.5;
        }
    }
}
