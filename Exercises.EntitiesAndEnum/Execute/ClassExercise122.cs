using System;
using System.Globalization;
using Exercises.Compositions.Entities;
using Exercises.Compositions.Entities.Enums;

namespace Exercises.Compositions.Execute
{
    public class ClassExercise122
    {
        public static void PurchasingSystem()
        {
            Console.WriteLine("Enter client data:");
            
            Console.Write("\nName: ");
            string _name = Console.ReadLine();

            Console.Write("\nEmail: ");
            string _email = Console.ReadLine();

            Console.Write("\nBirth date (DD/MM/YYYY): ");
            DateTime _birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter order data:");

            Console.Write("\nStatus: ");
            OrderStatus _status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client _client = new Client(_name, _email, _birthDate);
            Order order = new Order(DateTime.Now, _status, _client);

            Console.Write("\nHow many items to this order? ");
            int totalItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalItems; i++)
            {
                Console.Write($"\nEnter #{i + 1} item data:");
                
                Console.Write("\nProduct name: ");
                string _productName = Console.ReadLine();

                Console.Write("\nProduct price: ");
                double _price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("\nQuantity: ");
                int _quantity = int.Parse(Console.ReadLine());

                Product _product = new Product(_productName, _price);
                OrderItem item = new OrderItem(_quantity, _price, _product); 

                order.AddItem(item);
            }

            Console.Write("\nORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
