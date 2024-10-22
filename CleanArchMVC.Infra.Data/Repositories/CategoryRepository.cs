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
    public class CategoryRepository: ICategoryRepository
    {

        readonly ApplicationDbContext dbcontext_;
        public CategoryRepository(ApplicationDbContext context)
        {
            dbcontext_ = context;   
        }


        public async Task<Category> CreateCategory(Category category)
        {
            dbcontext_.Add(category); // Sem save, os dados ficam na memoria.
            await dbcontext_.SaveChangesAsync();
            return category;
        }

        public async Task DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetByID(int? id)
        {
            return await dbcontext_.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetCatories()
        {
            return await dbcontext_.Categories.ToListAsync();
        }

        public async Task<Category> RemmoveCategory(Category category)
        {
            dbcontext_.Remove(category); 
            await dbcontext_.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            dbcontext_.Update(category);
            await dbcontext_.SaveChangesAsync();
            return category;
        }
    }
}
