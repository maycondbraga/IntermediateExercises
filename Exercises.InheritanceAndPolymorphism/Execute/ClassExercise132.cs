using Exercises.Inheritance.Entities.Exercise132;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercises.Inheritance.Execute
{
    public class ClassExercise132
    {
        /// <summary>
        /// Exercise to get products information and return it's values
        /// </summary>
        public void PriceTags()
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type.ToUpper() == "I")
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (type.ToUpper() == "U")
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
