using Microsoft.Data.SqlClient;
using PizzaDelivery.DataAccessObject.Interfaces;
using PizzaDelivery.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaDelivery.DataAccessObject.Implementations
{
    internal class ImplProduct : IProductDAO
    {
        private SqlConnection sqlConnection = ConnectorDataBaseMicrosoftSQL.StartConnection().SqlConnection;

        public async Task<List<Product>> GetProductsFromDatabaseAsync()
        {
            List<Product> products = new List<Product>(); 

            await sqlConnection.OpenAsync();

            using (SqlCommand sqlCommandFindUser = new SqlCommand("SELECT * FROM Products", sqlConnection))
            {
                using (SqlDataReader sqlDataReader = await sqlCommandFindUser.ExecuteReaderAsync())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (await sqlDataReader.ReadAsync())
                        {
                            //Product product = new Product
                            //{

                            foreach (var product in products)
                            {
                                product.ID = (int)sqlDataReader.GetInt32(0);
                                product.Name = (string)sqlDataReader.GetString(1);
                                product.Category = (string)sqlDataReader.GetString(2);
                                product.Price = (decimal)sqlDataReader.GetDecimal(3);
                                product.ImageUrl = (string)sqlDataReader.GetString(4);

                            //};

                            products.Add(product);
                            }
                        }
                    }
                }
            }

            return products;
        }
    }
}
