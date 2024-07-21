using Dadata;
using PizzaDelivery.DataAccessObject.Implementations;
using PizzaDelivery.DataAccessObject.Services;
using PizzaDelivery.Entity;
using PizzaDelivery.Registration.Patterns;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PizzaDelivery.WindowsForms
{
    public partial class Registration : Form
    {
        private Form previousForm;
        private SuggestClientAsync api;
        private ImplRegistrUser userDAO = new ImplRegistrUser();

        public Registration(Form previousForm, string loginUser, string passwordUser)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            Login.Text = loginUser;
            Password.Text = passwordUser;

            listBoxAddressesFromDaData.Visible = false;

            var token = "ca31e39548cf4ccc48017654a9b62c4fe704048e";
            api = new SuggestClientAsync(token);
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!UniversalMethodsCheckIsEmptyAndSelected.CheckStringsIsNullOfEmpty(Surname.Text, Name.Text, Patronymic.Text, Address.Text, PhoneNumberOrEmail.Text, Login.Text, Password.Text) ||
                DateOfBirth.Value == DateTime.Today)
            {
                MessageBox.Show("Заполните все поля корректно.");
                return;
            }

            User newUser = new User();

            FacadeRegistrUser facadeRegistrUser = new FacadeRegistrUser();
            newUser = facadeRegistrUser.RegistrationFacade(PhoneNumberOrEmail.Text, newUser);

            newUser.Surname = Surname.Text;
            newUser.Name = Name.Text;
            newUser.Patronymic = Patronymic.Text;
            newUser.DateOfBirth = DateOfBirth.Value;
            newUser.Login = Login.Text;
            newUser.Password = Password.Text;
            newUser.UserCreationTime = DateTime.Now;

            if (facadeRegistrUser.CheckExistUser(newUser))
            {
                MessageBox.Show("User already exist");
                return;
            }

            var addressSuggestion = listBoxAddressesFromDaData.SelectedItem?.ToString() ?? Address.Text;
            var addressresult = await api.SuggestAddress(addressSuggestion);
            var addressData = addressresult.suggestions.FirstOrDefault();

            if (addressData == null)
            {
                MessageBox.Show("Пожалуйста, выберите корректный адрес из подсказок.");
                return;
            }

            var addressParts = addressData.data;
            var cityName = addressParts.city;
            var streetName = addressParts.street;
            int cityID = await userDAO.GetOrCreateCityIDAsync(cityName);
            int streetID = await userDAO.GetOrCreateStreetIDAsync(streetName);

            Address newAddress = new Address
            {
                CityID = cityID,
                StreetID = streetID,
                HouseNumber = addressParts.house,
                ApartmentNumber = addressParts.flat,
                PostalCode = addressParts.postal_code,
            };

            userDAO.RegisterUser(newUser, newAddress);
            MessageBox.Show("Регистрация прошла успешно!");

            PersonalAccount personalAccount = new PersonalAccount(previousForm);
            personalAccount.Show();
            this.Close();
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

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && (previousForm.Visible || !previousForm.Visible))
                return;

            Application.Exit();
        }
    }
}
