using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Aula_123.Entities.Enums;

namespace Aula_123.Entities
{
    class Order
    {
        //Attributes
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        //Constructors
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        //Methods

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.00;
            /*"OrderItem" é a classe, "Item" é um numerador e "Items" 
             * é o nome da lista que contém itens do tipo "OrderItem",
             * declarada e instanciada nessa classe!!!
             */
            foreach(OrderItem Item in Items)
            {
                sum += Item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            /*
             * "Moment", "Status", "Client" e "Items" que são utilizados abaixo
             * nada mais são do que os atributos dessa classe!!!
            */

            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
