using System;

namespace PizzaDelivery.Entity
{
    internal class Order
    {
        public long OrderID { get; set; }
        public long UserID { get; set; }
        public long AddressID { get; set; }
        public int OrderStatusID { get; set; }
        public DateTime OrderCreationTime { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
