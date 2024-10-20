using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Product: Entity
    {
        public string name { get; private set; }
        public string description { get; private set; }
        public decimal price { get; private set; }
        public int stock {  get; private set; }
        public string image { get; private set; }

        public int categoryId { get; set; } // foreign-key
        public Category category { get; set; }


        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name. Too Short, minimum 3 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid description");
            DomainExceptionValidation.When(description.Length < 5, "Invalid description. Too Short, minimum 5 characters");

            DomainExceptionValidation.When(price < 0, "Invalid price. negative value");

            DomainExceptionValidation.When(stock < 0, "Invalid stock. negative value");


            /*
             Operador ?. Null Condicional 
            - Estou permitindo que a imgem possa ser salva null ao banco de dado, para não levantar exceções e quebrar meu codigo, estou usando operador ?.
             */
            DomainExceptionValidation.When(image?.Length >  250, "Invalid image name, too long, maximum 250 characters");
            
            this.name = name;
            this.description = description;
            this.price = price;
            this.stock = stock;
            this.image = image;
            
        }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
        }
        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id, zero value");
            this.id = id;
            ValidateDomain(name, description, price, stock, image);
        }

        public void UpdateData(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidateDomain(name, description, price, stock, image);
            this.categoryId = categoryId;
        }
    }
}
