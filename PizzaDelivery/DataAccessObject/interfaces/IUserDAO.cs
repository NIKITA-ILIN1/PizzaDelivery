using PizzaDelivery.Entity;

namespace PizzaDelivery.Dao.inreface
{
    internal interface IUserDAO
    {
        void RegisterUser(User user, Address address);

        User AuthUser(User user);
    }
}