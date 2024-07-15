using PizzaDelivery.Dao.inreface;
using PizzaDelivery.DataAccessObject.Implementations;
using PizzaDelivery.DataAccessObject.Services;
using PizzaDelivery.Entity;

namespace PizzaDelivery.Registration.Patterns
{
    internal class FacadeRegistrUser
    {
        private IUserDAO userDAO;  

        public User RegistrationFacade(string text, User user)
        {
            FactoryRegistrUser factoryRegistrUser = new FactoryRegistrUser();
            factoryRegistrUser.CreateFactory(text, user);

            return user;
        }

        public void RegistrationUser(User user, Address address)
        {
            userDAO = new ImplRegistrUser();
            userDAO.RegisterUser(user, address);
        }

        public bool CheckExistUser(User user)
        {
            return VerificationsUserForRegistr.CheckExistUser(user);
        }
    }
}
