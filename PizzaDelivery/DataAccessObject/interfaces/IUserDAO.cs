using PizzaDelivery.Entity;

namespace PizzaDelivery.Dao.inreface
{
    internal interface IUserDAO
    {
        User FindUserByLoginAndPassword(User user);
        User FindUserById(User user);
        void SaveUser(User user);
    }
}