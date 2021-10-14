using System.Globalization;

namespace Exercises.Compositions.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int _quantity, double _price, Product _product)
        {
            Quantity = _quantity;
            Price = _price;
            Product = _product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
                 + ", $"
                 + Price.ToString("F2", CultureInfo.InvariantCulture)
                 + ", Quantity: "
                 + Quantity
                 + ", Subtotal: $"
                 + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
