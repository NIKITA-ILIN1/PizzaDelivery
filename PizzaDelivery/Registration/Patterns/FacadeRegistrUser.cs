using PizzaDelivery.Dao.inreface;
using PizzaDelivery.DataAccessObject.Implementations;
using PizzaDelivery.DataAccessObject.Services;
using PizzaDelivery.Entity;

namespace PizzaDelivery.Registration.Patterns
{
    internal class FacadeRegistrUser
    {
        private IUserDAO userDAO; 
        private VerificationsUserForRegistr userService; 

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
            userService = new VerificationsUserForRegistr();
            return userService.CheckExistUser(user);
        }
    }
}
