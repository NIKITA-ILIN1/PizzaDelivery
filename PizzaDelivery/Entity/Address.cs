namespace PizzaDelivery.Entity
{
    internal class Address
    {
        public long ID { get; set; }  
        public long UserID { get; set; }  
        public long CityID { get; set; }  
        public long StreetID { get; set; }  
        public string HouseNumber { get; set; }  
        public string ApartmentNumber { get; set; }  
        public string PostalCode { get; set; }  
    }
}
