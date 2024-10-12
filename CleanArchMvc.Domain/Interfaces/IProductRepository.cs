using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository 
    {
        Task<IEnumerable<Product>> GetProduct();
        Task<Product> GetByID(int? id);
        Task<Product> GetProductCategory(int? id);
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<Product> RemmoveProduct(Product product);

        Task DeleteProduct(int id);
    }
}
