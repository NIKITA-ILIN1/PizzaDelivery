using PizzaDelivery.Dao.inreface;
using PizzaDelivery.DataAccessObject.Services;
using PizzaDelivery.Entity;

namespace PizzaDelivery.Registration.Patterns
{
    //private IUserDAO userDAO;
    //private VerificationsUserForRegistr userService; 

    internal class FacadeRegistrUser
    {
        public User RegistrationFacade(string text, User user)
        {
            FactoryRegistrUser factoryRegistrUser = new FactoryRegistrUser();
            factoryRegistrUser.CreateFactory(text, user);

            return user;
        }

        //public void RegistrationUser(User user)
        //{
        //    userDAO = new ImplUserDAO();

        //    userDAO.SaveUser(user);
        //}

        //public bool CheckExistUser(User user)
        //{
        //    userService = new VerificationsUserForRegistr();

        //    return userService.CheckExistUser(user);
        //}
    }
}
