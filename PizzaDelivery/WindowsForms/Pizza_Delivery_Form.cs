using PizzaDelivery.WindowsForms;
using System;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class Pizza_Delivery_Form : Form
    {
        private Form previousForm;

        public Pizza_Delivery_Form(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Registration_Form registrationForm = new Registration_Form(this);
            registrationForm.ShowDialog();
        }

        private void Pizza_Delivery_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && previousForm.Visible)
            {
                return;
            }

            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}