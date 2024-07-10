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
            WindowsForms.Registration registrationForm = new WindowsForms.Registration(this);
            registrationForm.Show();
            this.Hide();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {

        }   

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
