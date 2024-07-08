using Microsoft.Data.SqlClient;
using PizzaDelivery.Dao.inreface;
using PizzaDelivery.Entity;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace PizzaDelivery.DataAccessObject.Implementations
{
    internal class ImplRegistrUser : IUserDAO
    {
        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public void RegisterUser(User user, Address address)
        {
            string passwordHash = ConvertPasswordToSha256Hash(user.Password);

            using (sqlConnection)
            {
                using (SqlCommand command = new SqlCommand("RegisterUser", sqlConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Surname", user.Surname);
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@Patronymic", user.Patronymic);
                    command.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Login", user.Login);
                    command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    command.Parameters.AddWithValue("@LocalityID", address.LocalityID);
                    command.Parameters.AddWithValue("@UrbanSpaceID", address.UrbanSpaceID);
                    command.Parameters.AddWithValue("@HouseNumber", address.HouseNumber);
                    command.Parameters.AddWithValue("@ApartmentNumber", address.ApartmentNumber);
                    command.Parameters.AddWithValue("@PostalCode", address.PostalCode);

                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private static string ConvertPasswordToSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public User AuthenticateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
