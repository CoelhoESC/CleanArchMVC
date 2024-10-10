using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    internal class Category
    {
        public int id {  get; set; }
        public string name { get; set; }
        public ICollection<Product> products { get; set; } // um para muitos
    }
}
