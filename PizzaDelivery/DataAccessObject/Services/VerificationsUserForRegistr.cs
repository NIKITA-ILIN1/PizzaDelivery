using Microsoft.Data.SqlClient;
using PhoneNumbers;
using PizzaDelivery.DataAccessObject.Implementations;
using PizzaDelivery.Entity;
using System;

namespace PizzaDelivery.DataAccessObject.Services
{
    internal class VerificationsUserForRegistr
    {
        static SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public static string CheckEmailUser(string emailUser)
        {
            if (string.IsNullOrEmpty(emailUser))
            {
                throw new Exception("Email is null of empty");
            }

            if (!emailUser.Contains("@"))
            {
                throw new Exception("Email not Contains @");
            }

            return emailUser;
        }

        public static string CheckPhoneNumberUser(string phoneNumber)
        {
            PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();

            if (string.IsNullOrEmpty(phoneNumber))
            {
                throw new ArgumentException("Phone number null or empty", nameof(phoneNumber));
            }

            if (!phoneNumber.StartsWith("+"))
            {
                phoneNumber = "+" + phoneNumber;
            }

            try
            {
                PhoneNumber number = phoneNumberUtil.Parse(phoneNumber, null);

                string formattednumber = phoneNumberUtil.Format(number, PhoneNumberFormat.INTERNATIONAL);

                if (!phoneNumberUtil.IsValidNumber(number))
                {
                    throw new ArgumentException("Phone number not valid", nameof(phoneNumber));
                }

                return formattednumber;
            }
            catch (NumberParseException e)
            {
                throw new ArgumentException("Error parsing phone number: " + e.Message);
            }
        }

        public static bool CheckExistUser(User user)
        {
            try
            {
                sqlConnection.Open();

                string sqlQueryCheckExistUser = "SELECT * FROM Users WHERE phone_number = @PhoneNumber OR email = @Email OR login = @Login";

                SqlCommand sqlCommandCheckExistUser = new SqlCommand(sqlQueryCheckExistUser, sqlConnection);

                sqlCommandCheckExistUser.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                sqlCommandCheckExistUser.Parameters.AddWithValue("@Email", user.Email);
                sqlCommandCheckExistUser.Parameters.AddWithValue("@Login", user.Login);

                int count = Convert.ToInt32(sqlCommandCheckExistUser.ExecuteScalar());

                sqlConnection.Close();

                return count > 0;
            }
            catch (SqlException e)
            {
                throw new Exception("Произошла ошибка при работе с базой данных: " + e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Произошла ошибка: " + e.Message);
            }
            finally { sqlConnection.Close(); }
        }
    }
}
