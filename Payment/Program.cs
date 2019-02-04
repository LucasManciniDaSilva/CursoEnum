using System;
using Payment.Entities;
using Payment.Entities.Enums;
namespace Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment




            };
            Console.WriteLine(order);

            string txt = OrderStatus.Processing.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Shipped");
            Console.WriteLine(os);



        }
    }
}
