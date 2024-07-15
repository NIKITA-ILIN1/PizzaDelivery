using PizzaDelivery.DataAccessObject.Implementations;
using PizzaDelivery.DataAccessObject.Services;
using PizzaDelivery.Entity;
using PizzaDelivery.Security;
using PizzaDelivery.WindowsForms;
using System;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            WindowsForms.Registration registrationForm = new WindowsForms.Registration(this, LoginUser.Text, PasswordUser.Text);
            registrationForm.Show();
            this.Hide();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            if (!UniversalMethodsCheckIsEmptyAndSelected.CheckStringsIsNullOfEmpty(LoginUser.Text, PasswordUser.Text))
            {
                return;
            }

            User user = new User { Login = LoginUser.Text, Password = ImplRegistrUser.ConvertPasswordToSha256Hash(PasswordUser.Text) };

            if (!VerificationUserForAuth.CheckExistUser(user))
            {
                MessageBox.Show("This user does't exist");
                return;
            }

            Authorization authorization  = new Authorization();

            if (authorization.AuthUser(user))
            {
                PersonalAccount personalAccount = new PersonalAccount(this);
                personalAccount.Show();
                this.Hide();
            }
        }   

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
