using System;
using System.Globalization;
using Aula_123.Entities;
using Aula_123.Entities.Enums;

namespace Aula_123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(name, email, birthdate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                /*Nese momento é instanciada e iniciado um objeto
                 * da classe "OrderItem".
                */
                OrderItem orderItem = new OrderItem(quantity, price, product);

                /*O objeto "order" do tipo de classe "Order" foi instanciado
                 * na presente classe. Após isso é utilizado o método
                 * "AddItem"(da classe "Order"), para adcionar um pedido (Order), 
                 * usando como atributo, a instanciação de classe acima!
                */
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
