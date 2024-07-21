using PizzaDelivery.Entities;

namespace PizzaDelivery.Entity
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
