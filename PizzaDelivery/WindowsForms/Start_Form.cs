using System;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            Pizza_Delivery_Form pizzaDeliveryForm = new Pizza_Delivery_Form(this);
            pizzaDeliveryForm.Show();
            this.Hide();
        }

        private void Start_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
