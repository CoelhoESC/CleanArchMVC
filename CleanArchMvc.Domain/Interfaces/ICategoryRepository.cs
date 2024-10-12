using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCatories();
        Task<Category> GetByID(int? id);

        Task<Category> CreateCategory(Category category);

        Task<Category> UpdateCategory(Category category);
        Task<Category> RemmoveCategory(Category category);

        Task DeleteCategory(int id);

    }
}
