using System;
using ActivityOrder.Entities.Enum;
using ActivityOrder.Entities;

namespace ActivityOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the client name: ");
            string nameClient = Console.ReadLine();

            Console.Write("Enter the Client E-mail: ");
            string EmailClient = Console.ReadLine();

            Console.Write("Enter the birth date(DD/MM/YYYY): ");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nameClient, EmailClient, dateBirth); 

            Console.Write("Enter the order data \nStatus: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many itens to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, os, client);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the data item {i + 1}");
                Console.Write("Name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Price: ");
                double priceProduct = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantity: ");
                int q = int.Parse(Console.ReadLine());
                                             
                Product product = new Product(nameProduct, priceProduct);

                OrderItem oi = new OrderItem(q, priceProduct, product);

                order.addItem(oi);



            }

            Console.WriteLine(order);


        }
    }
}
