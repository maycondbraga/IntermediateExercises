namespace Exercises.Inheritance.Entities.Exercise136
{
    class Company : TaxPayer
    {
        public int TotalEmployees { get; set; }

        public Company(string name, double annualIncome, int totalEmployees) : base(name, annualIncome)
        {
            TotalEmployees = totalEmployees;
        }

        public override double Tax()
        {
            if (TotalEmployees <= 10)
                return AnnualIncome * 0.16;
            else
                return AnnualIncome * 0.14;
        }
    }
}
