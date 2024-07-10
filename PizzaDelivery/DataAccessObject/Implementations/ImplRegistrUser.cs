using Microsoft.Data.SqlClient;
using PizzaDelivery.Dao.inreface;
using PizzaDelivery.Entity;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery.DataAccessObject.Implementations
{
    internal class ImplRegistrUser : IUserDAO
    {
        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public void RegisterUser(User user, Address address)
        {
            string passwordHash = ConvertPasswordToSha256Hash(user.Password);

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
                command.Parameters.AddWithValue("@CityID", address.CityID);
                command.Parameters.AddWithValue("@StreetID", address.StreetID);
                command.Parameters.AddWithValue("@HouseNumber", address.HouseNumber);
                command.Parameters.AddWithValue("@ApartmentNumber", address.ApartmentNumber);
                command.Parameters.AddWithValue("@PostalCode", address.PostalCode);

                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        public async Task<int> GetOrCreateCityID (string cityName)
        {
            int cityID;

            using (SqlCommand command = new SqlCommand("SELECT id FROM Cities WHERE name = @CityName", sqlConnection))
            {
                command.Parameters.AddWithValue("@CityName", cityName);

                sqlConnection.Open();
                var result = await command.ExecuteScalarAsync();
                sqlConnection.Close();

                if (result != null)
                {
                    cityID = Convert.ToInt32(result);
                }
                else
                {
                    using (SqlCommand insertCommand = new SqlCommand("BEGIN TRANSACTION " +
                                                                     "INSERT INTO Cities (name) VALUES (@CityName) " +
                                                                     "SELECT id FROM Cities WHERE name = @CityName " +
                                                                     "COMMIT TRANSACTION", sqlConnection))
                    {                                                 
                        insertCommand.Parameters.AddWithValue("@CityName", cityName);

                        sqlConnection.Open();
                        cityID = Convert.ToInt32(await insertCommand.ExecuteScalarAsync());
                        sqlConnection.Close();
                    }
                }
            }

            return cityID;
        }

        public async Task<int> GetOrCreateStreetID(string streetName)
        {
            int streetID;

            using (SqlCommand command = new SqlCommand("SELECT id FROM Streets WHERE name = @StreetName", sqlConnection))
            {
                command.Parameters.AddWithValue("@StreetName", streetName);

                sqlConnection.Open();
                var result = await command.ExecuteScalarAsync();
                sqlConnection.Close();

                if (result != null)
                {
                    streetID = Convert.ToInt32(result);
                }
                else
                {
                    using (SqlCommand insertCommand = new SqlCommand("BEGIN TRANSACTION " +
                                                                     "INSERT INTO Streets (name) VALUES (@StreetName) " +
                                                                     "SELECT id FROM Streets WHERE name = @StreetName " +
                                                                     "COMMIT TRANSACTION", sqlConnection))
                    {
                        insertCommand.Parameters.AddWithValue("@StreetName", streetName);

                        sqlConnection.Open();
                        streetID = Convert.ToInt32(await insertCommand.ExecuteScalarAsync());
                        sqlConnection.Close();
                    }
                }
            }

            return streetID;
        }

        public static string ConvertPasswordToSha256Hash(string rawData)
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
