using PizzaDelivery.DataAccessObject.Services;
using PizzaDelivery.Entity;
using System;
using System.Windows.Forms;
using Dadata;

namespace PizzaDelivery.WindowsForms
{
    public partial class RegistrationForm : Form
    {
        private SuggestClientAsync api;

        public RegistrationForm()
        {
            InitializeComponent();

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
    }
}
