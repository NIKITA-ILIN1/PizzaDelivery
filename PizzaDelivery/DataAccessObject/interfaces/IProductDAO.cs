using PizzaDelivery.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaDelivery.DataAccessObject.Interfaces
{
    internal interface IProductDAO
    {
        Task<List<Product>> GetProductsFromDatabaseAsync();
    }
}
