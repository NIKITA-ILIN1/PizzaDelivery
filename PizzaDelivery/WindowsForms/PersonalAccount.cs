using PizzaDelivery.Entity;
using PizzaDelivery.Security;
using System;
using System.Windows.Forms;

namespace PizzaDelivery.WindowsForms
{
    public partial class PersonalAccount : Form
    {
        private Form previousForm;
        private User currentUser = UserSession.GetCurrentSession().CurrentUser;

        public PersonalAccount(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;

            Surname.Text = currentUser.Surname;
            Name.Text = currentUser.Name;
            Patronymic.Text = currentUser.Patronymic;
            DateOfBirth.Value = currentUser.DateOfBirth;
            Email.Text = currentUser.Email;
            Login.Text = currentUser.Login;
            PhoneNumber.Text = currentUser.PhoneNumber;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void PersonalAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && previousForm.Visible)
                return;

            Application.Exit();
        }
    }
}
