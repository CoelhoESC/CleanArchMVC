using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    internal sealed class Category : Entity
    {
        public string name { get; private set; }

        public Category(string name)
        {
            ValidationDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value");
            this.id = id;
            ValidationDomain(name);
        }
        public ICollection<Product> products { get; set; } // um para muitos

        private void ValidationDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name");
            DomainExceptionValidation.When(name.Length < 3, "too short, minimum 3 characters");
            this.name = name;
            
        }

        public void UpdateName(string name)
        {
            ValidationDomain(name);

        }
    }
}
