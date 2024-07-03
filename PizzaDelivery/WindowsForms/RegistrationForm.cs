using Newtonsoft.Json.Linq;
using PizzaDelivery.DataAccessObject.Services;
using PizzaDelivery.Entity;
using RestSharp;
using System;
using System.Windows.Forms;

namespace PizzaDelivery.WindowsForms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
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
                var client = new RestClient("https://suggestions.dadata.ru/suggestions.api./4_1/rs/suggest/address");

                var request = new RestRequest(Method.Post.ToString());

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "");//token

                request.AddJsonBody(new { query = input, count = 10 });

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    listBoxAddressesFromDaData.Items.Clear();

                    var jsonResponse = JObject.Parse(response.Content);

                    var suggestions = jsonResponse["suggestions"];

                    foreach (var suggestion in suggestions)
                    {
                        listBoxAddressesFromDaData.Items.Add(suggestion["value"].ToString());
                    }
                }
            }
        }

        private void listBoxAddressesFromDaData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAddressesFromDaData.SelectedItem != null)
            {
                Address.Text = listBoxAddressesFromDaData.SelectedItem.ToString();
            }
        }
    }
}
