namespace Exercises.Compositions.Entities.Exercise122
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string _name, double _price)
        {
            Name = _name;
            Price = _price;
        }
    }
}
