using PizzaDelivery.Entity;

namespace PizzaDelivery.Security
{
    internal class UserSession
    {
        private static UserSession instance;
        public User CurrentUser { get; private set; }

        public UserSession()
        {
        }

        private UserSession(User user) 
        {
            CurrentUser = user;
        }

        public static UserSession StartSession(User user) 
        {
            if (instance == null)
            {
                instance = new UserSession(user);
            }

            return instance;
        }

        public static void EndSession()
        {
            instance = null;
        }

        public static UserSession GetCurrentSession()
        {
            return instance;
        }
    }
}
