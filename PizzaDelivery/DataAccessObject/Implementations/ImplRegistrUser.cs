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

            using (SqlCommand sqlCommandRegisterUser = new SqlCommand("RegisterUser", sqlConnection))
            {
                sqlCommandRegisterUser.CommandType = CommandType.StoredProcedure;

                sqlCommandRegisterUser.Parameters.AddWithValue("@Surname", user.Surname);
                sqlCommandRegisterUser.Parameters.AddWithValue("@Name", user.Name);
                sqlCommandRegisterUser.Parameters.AddWithValue("@Patronymic", user.Patronymic);
                sqlCommandRegisterUser.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                sqlCommandRegisterUser.Parameters.AddWithValue("@Email", user.Email);
                sqlCommandRegisterUser.Parameters.AddWithValue("@Login", user.Login);
                sqlCommandRegisterUser.Parameters.AddWithValue("@PasswordHash", passwordHash);
                sqlCommandRegisterUser.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                sqlCommandRegisterUser.Parameters.AddWithValue("@CityID", address.CityID);
                sqlCommandRegisterUser.Parameters.AddWithValue("@StreetID", address.StreetID);
                sqlCommandRegisterUser.Parameters.AddWithValue("@HouseNumber", address.HouseNumber);
                sqlCommandRegisterUser.Parameters.AddWithValue("@ApartmentNumber", address.ApartmentNumber);
                sqlCommandRegisterUser.Parameters.AddWithValue("@PostalCode", address.PostalCode);

                sqlConnection.Open();
                sqlCommandRegisterUser.ExecuteNonQuery();
            }
        }

        public async Task<int> GetOrCreateCityIDAsync(string cityName)
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

        public async Task<int> GetOrCreateStreetIDAsync(string streetName)
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

        public User AuthUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
