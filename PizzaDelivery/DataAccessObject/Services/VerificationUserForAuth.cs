using Microsoft.Data.SqlClient;
using PizzaDelivery.Entity;
using System;

namespace PizzaDelivery
{
    internal class VerificationUserForAuth
    {
        static SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public static bool CheckExistUser(User user)
        {
            try
            {
                sqlConnection.Open();

                string sqlQueryCheckExistUser = "SELECT * FROM Users WHERE login = @Login AND password_hash = @Password";

                SqlCommand sqlCommandCheckExistUser = new SqlCommand(sqlQueryCheckExistUser, sqlConnection);

                sqlCommandCheckExistUser.Parameters.AddWithValue("@Login", user.Login);
                sqlCommandCheckExistUser.Parameters.AddWithValue("@Password", user.Password);

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
