namespace Exercises.Inheritance.Entities.Exercise130
{
    public class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double payment = base.Payment();
            double additional = AdditionalCharge * 1.1;
            return payment + additional;
        }
    }
}
