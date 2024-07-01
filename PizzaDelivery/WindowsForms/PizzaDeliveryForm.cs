using PizzaDelivery.WindowsForms;
using System;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class PizzaDeliveryForm : Form
    {
        public PizzaDeliveryForm()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            this.Hide();
            registrationForm.ShowDialog();
            this.Show();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {

        }
    }
}
