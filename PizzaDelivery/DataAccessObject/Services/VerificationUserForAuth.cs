using Microsoft.Data.SqlClient;
using PizzaDelivery.Entity;
using System;

namespace PizzaDelivery
{
    internal class VerificationUserForAuth
    {
        public bool CheckExistUser(User user)
        {
            SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

            try
            {
                sqlConnection.Open();

                string sqlQueryCheckExistUser = "SELECT * FROM Users WHERE login = @login AND password = @password";

                SqlCommand sqlCommandCheckExistUser = new SqlCommand(sqlQueryCheckExistUser, sqlConnection);

                sqlCommandCheckExistUser.Parameters.AddWithValue("@login", user.Login);
                sqlCommandCheckExistUser.Parameters.AddWithValue("@password", user.Password);

                int count = Convert.ToInt32(sqlCommandCheckExistUser.ExecuteScalar());

                return count == 0;
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
