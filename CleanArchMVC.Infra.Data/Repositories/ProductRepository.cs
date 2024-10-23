using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMVC.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly ApplicationDbContext dbcontext;
        public ProductRepository(ApplicationDbContext context)
        {
            dbcontext = context;
        }

        public async Task<Product> CreateProduct(Product product)
        {
            dbcontext.Add(product);
            await dbcontext.SaveChangesAsync();
            return product;
        }

        public async Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetByID(int? id)
        {
            return await dbcontext.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await dbcontext.Products.ToListAsync();
        }

        public async Task<Product> GetProductCategory(int? id)
        {
            return await dbcontext.Products.Include(c => c.category).SingleOrDefaultAsync(p => p.id == id); // carregamento adiantado
        }

        public async Task<Product> RemmoveProduct(Product product)
        {
            dbcontext.Remove(product);
            await dbcontext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            dbcontext.Update(product);
            await dbcontext.SaveChangesAsync();
            return product;
        }
    }
}
