using PizzaDelivery.DataAccessObject.Services;
using PizzaDelivery.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PizzaDelivery.Registration.Patterns
{
    internal class FactoryRegistrUser
    {
        public void CreateFactory(string text, User user)
        {
            if (text.Contains(".com") || text.Contains(".ru"))
            {
                user.Email = VerificationsUserForRegistr.CheckEmailUser(text);
                user.PhoneNumber = "";
            }
            else if (text.Any(char.IsDigit))
            {
                user.PhoneNumber = VerificationsUserForRegistr.CheckPhoneNumberUser(text);
                user.Email = "";
            }
            else
            {
                MessageBox.Show("Create validator error");
            }
        }
    }
}
