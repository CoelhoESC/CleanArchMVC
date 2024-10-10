using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    internal class Product
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int stock {  get; set; }
        public string image { get; set; }

        public int categoryId { get; set; } // foreign-key
        public Category category { get; set; }
    }
}
