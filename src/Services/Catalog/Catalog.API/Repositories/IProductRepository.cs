using Catalog.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts(); // must use List<>, IEnumerable<> causes bugs
        Task<Product> GetProduct(string id);
        Task<List<Product>> GetProductByName(string name);
        Task<List<Product>> GetProductByCategroy(string categoryName);
        Task CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(string id);
    }
}
