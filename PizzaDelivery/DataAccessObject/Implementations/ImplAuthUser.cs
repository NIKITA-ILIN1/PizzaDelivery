using Microsoft.Data.SqlClient;
using PizzaDelivery.Dao.inreface;
using PizzaDelivery.Entity;
using System;
using Address = PizzaDelivery.Entity.Address;

namespace PizzaDelivery.DataAccessObject.Implementations
{
    internal class ImplAuthUser : IUserDAO
    {
        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public User AuthUser(User user)
        {
            User findedUser = new User();

            sqlConnection.Open();

            using (SqlCommand sqlCommandFindUser = new SqlCommand("SELECT * FROM Users WHERE login = @Login AND password_hash = @Password", sqlConnection))
            {
                sqlCommandFindUser.Parameters.AddWithValue("@Login", System.Data.SqlDbType.VarChar).Value = user.Login;
                sqlCommandFindUser.Parameters.AddWithValue("@Password", System.Data.SqlDbType.VarChar).Value = user.Password;

                SqlDataReader sqlDataReader = sqlCommandFindUser.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        findedUser.ID = (long)sqlDataReader.GetValue(0);
                        findedUser.Surname= (string)sqlDataReader.GetValue(1);
                        findedUser.Name = (string)sqlDataReader.GetValue(2);
                        findedUser.Patronymic = (string)sqlDataReader.GetValue(3);
                        findedUser.DateOfBirth = (DateTime)sqlDataReader.GetValue(4);
                        findedUser.Email = (string)sqlDataReader.GetValue(5);
                        findedUser.Login = (string)sqlDataReader.GetValue(6);
                        findedUser.Password = (string)sqlDataReader.GetValue(7);
                        findedUser.PhoneNumber = (string)sqlDataReader.GetValue(8);
                        findedUser.UserCreationTime = (DateTime)sqlDataReader.GetValue(9);
                    }
                }
                sqlConnection.Close();
            }

            return findedUser;
        }

        public void RegisterUser(User user, Address address)
        {
            throw new NotImplementedException();
        }
    }
}
