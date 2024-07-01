using System;

namespace PizzaDelivery.Entity
{
    internal class User
    {
        public long UserID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime UserCreationTime { get; set; }
    }
}
