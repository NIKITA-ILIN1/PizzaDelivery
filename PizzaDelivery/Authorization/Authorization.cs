using PizzaDelivery.Dao.inreface;
using PizzaDelivery.DataAccessObject.Implementations;
using PizzaDelivery.Entity;

namespace PizzaDelivery.Security
{
    internal class Authorization
    {
        private IUserDAO implUserDAO = new ImplAuthUser();

        public bool AuthUser(User user)
        {
            User tryAuthUser = implUserDAO.AuthUser(user);

            if (tryAuthUser.ID != 0)
            {
                UserSession.StartSession(tryAuthUser); 

                return true;
            }

            return false;
        }

        public static void LogOutUser()
        {
            UserSession.EndSession();
        }
    }
}
