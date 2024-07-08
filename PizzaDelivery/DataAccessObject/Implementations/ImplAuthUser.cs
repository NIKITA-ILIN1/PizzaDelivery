using PizzaDelivery.Dao.inreface;
using PizzaDelivery.Entity;
using System;

namespace PizzaDelivery.DataAccessObject.Implementations
{
    internal class ImplAuthUser : IUserDAO
    {
        public User AuthenticateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(User user, Address address)
        {
            throw new NotImplementedException();
        }
    }
}
