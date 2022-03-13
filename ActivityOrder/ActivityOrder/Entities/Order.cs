using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityOrder.Entities.Enum;

namespace ActivityOrder.Entities
{
    class Order
    {
        public List<OrderItem> orderItens { get; set; } = new List<OrderItem>();
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public Client client { get; set; }

        public Order(DateTime moment, OrderStatus stautus, Client client)
        {
            this.orderItens = orderItens;
            this.moment = moment;
            this.status = stautus;
            this.client = client; 

        }

        public void addItem(OrderItem order)
        {
            orderItens.Add(order);
            Console.WriteLine("Order Added");
        }

        public void removeItem(OrderItem order)
        {
            orderItens.Remove(order);
            Console.WriteLine("Order Removed");
        }

        public double total()
        {
            double sum = 0.0;
            foreach (OrderItem o in orderItens)
            {
                sum += o.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order summary: ");
            sb.AppendLine($"Order momment: {moment.ToString("dd/MM/yyy HH:mm:ss")}");
            sb.AppendLine($"Order Status: {status}");
            sb.AppendLine($"Client: {client.Name} {client.BirthDate.ToString("dd/MM/yyyy")} - {client.Email}");
            sb.AppendLine("Order Items: ");

            foreach (OrderItem o in orderItens)
            {
                sb.AppendLine($"{o.product.Name}, ${o.price}, Quantity {o.quantity}," +
                    $"Subtotal: {o.subTotal()}");
            }
            sb.AppendLine($"Total Price: ${total()}");

            return sb.ToString();
        }

    }
}
