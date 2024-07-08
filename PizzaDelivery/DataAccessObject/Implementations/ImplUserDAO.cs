using Dadata.Model;
using Microsoft.Data.SqlClient;
using PizzaDelivery.Dao.inreface;
using PizzaDelivery.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery.DataAccessObject.Implementations
{
    internal class ImplUserDAO : IUserDAO
    {
        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public User FindUserById(User user)
        {
            throw new NotImplementedException();
        }

        public User FindUserByLoginAndPassword(User user)
        {
            throw new NotImplementedException();
        }

        //public User FindUserByLoginAndPassword(User user)
        //{
        //    sqlConnection.Open();

        //    string sqlQueryFindUser = "SELECT * FROM Users WHERE login = @login AND password = @password";

        //    SqlCommand sqlCommandFindUser = new SqlCommand(sqlQueryFindUser, sqlConnection);

        //    sqlCommandFindUser.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.Login;
        //    sqlCommandFindUser.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.Password;

        //    SqlDataReader sqlDataReader = sqlCommandFindUser.ExecuteReader();

        //    if (sqlDataReader.HasRows)
        //    {

        //        User findedUser = new User();

        //        while (sqlDataReader.Read())
        //        {
        //            findedUser.ID = (long)sqlDataReader.GetValue(0);
        //            findedUser.Surname = (int)sqlDataReader.GetValue(1);
        //            findedUser.CityId = (long)sqlDataReader.GetValue(2);
                    
        //            findedUser.FullName = new FullName
        //            {
        //                Surname = (string)sqlDataReader.GetValue(3),
        //                Name = (string)sqlDataReader.GetValue(4),
        //                Patronymic = (string)sqlDataReader.GetValue(5)
        //            };
        //            findedUser.DateOfBirth = (DateTime)sqlDataReader.GetValue(6);
        //            findedUser.Login = (string)sqlDataReader.GetValue(7);
        //            findedUser.Password = (string)sqlDataReader.GetValue(8);
        //            findedUser.PhoneNumber = (string)sqlDataReader.GetValue(9);
        //            findedUser.Email = (string)sqlDataReader.GetValue(10);
        //        }

        //        sqlConnection.Close();
        //        return findedUser;
        //    }
        //}

        public void SaveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
