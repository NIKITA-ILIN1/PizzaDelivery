using Dadata;
using PizzaDelivery.DataAccessObject.Services;
using PizzaDelivery.Entity;
using System;
using System.Windows.Forms;

namespace PizzaDelivery.WindowsForms
{
    public partial class Registration_Form : Form
    {
        private Form previousForm;
        private SuggestClientAsync api;

        public Registration_Form(Form previousForm)
        {
            InitializeComponent();

            this.previousForm = previousForm;

            listBoxAddressesFromDaData.Visible = false;

            var token = "ca31e39548cf4ccc48017654a9b62c4fe704048e";
            api = new SuggestClientAsync(token);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            if (!UniversalMethodsCheckIsEmptyAndSelected.CheckStringsIsNullOfEmpty(Surname.Text, Name.Text, Patronymic.Text, Email.Text, Login.Text, Password.Text, PhoneNumber.Text) ||
                DateOfBirth.Value == DateTime.Today)
                return;



        }

        private async void Address_TextChanged(object sender, EventArgs e)
        {
            string input = Address.Text;

            if (input.Length >= 1)
            {
                var result = await api.SuggestAddress(input);

                if (result.suggestions != null)
                {
                    listBoxAddressesFromDaData.Items.Clear();

                    foreach (var suggestion in result.suggestions)
                    {
                        listBoxAddressesFromDaData.Items.Add(suggestion.value);
                    }

                    listBoxAddressesFromDaData.Visible = listBoxAddressesFromDaData.Items.Count > 0;
                }
            }
        }

        private void listBoxAddressesFromDaData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAddressesFromDaData.SelectedItem != null)
            {
                Address.Text = listBoxAddressesFromDaData.SelectedItem.ToString();

                listBoxAddressesFromDaData.Visible = false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void Registration_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && previousForm.Visible)
            {
                return;
            }

            Application.Exit();
        }
    }
}
