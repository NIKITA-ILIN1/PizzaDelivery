namespace PizzaDelivery.Entity
{
    internal class Address
    {
        public long AddressID { get; set; }  
        public long UserID { get; set; }  
        public int CountryID { get; set; }  
        public long LocalityID { get; set; }  
        public long UrbanSpaceID { get; set; }  
        public string HouseNumber { get; set; }  
        public string ApartmentNumber { get; set; }  
        public string PostalCode { get; set; }  
    }
}
