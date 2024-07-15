using Dadata.Model;
using PizzaDelivery.DataAccessObject.Services;
using PizzaDelivery.Entity;
using PizzaDelivery.WindowsForms;
using System;
using System.Web.UI.WebControls;
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
            WindowsForms.Registration registrationForm = new WindowsForms.Registration(this);
            registrationForm.Show();
            this.Hide();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            if (!UniversalMethodsCheckIsEmptyAndSelected.CheckStringsIsNullOfEmpty(LoginUser.Text, PasswordUser.Text))
            {
                return;
            }

            User user = new User { Login = LoginUser.Text, Password = PasswordUser.Text };

            VerificationUserForAuth verificationUserForAuth = new VerificationUserForAuth();

            if (verificationUserForAuth.CheckExistUser(user))
            {
                MessageBox.Show("This user does't exist");
                return;
            }

            Security.Security sec = new Security.Security();

            if (sec.AuthUser(user))
            {
                PersonalAccount personalAccount = new PersonalAccount();
                personalAccount.ShowDialog();
            }
        }   

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
