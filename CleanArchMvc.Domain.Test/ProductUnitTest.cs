using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Test
{
    public class ProductUnitTest
    {
        [Fact(DisplayName = "Criando um Produto valido")]
        public void CreatProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Name", "Description", 30.00m, 3, "Image");
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criando um Produto com id negativo")]
        public void CreatProduct_NegativeIdValue()
        {
            Action action = () => new Product(-1, "Name", "Description", 30.00m, 3, "Image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criando um Produto com nome menor que 3 caracteres")]
        public void CreatProduct_ShortNameChacacters()
        {
            Action action = () => new Product(1, "Na", "Description", 30.00m, 3, "Image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();

        }

        [Fact(DisplayName = "Criando um Produto com nome null")]
        public void CreatProduct_NullOrEmptyName()
        {
            Action action = () => new Product(1, null, "Description", 30.00m, 3, "Image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();

        }

        [Fact(DisplayName = "Criando um Produto com descrição menor que 5 caracteres")]
        public void CreatProduct_ShortDescriptionChacacters()
        {
            Action action = () => new Product(1, "Name", "Desc", 30.00m, 3, "Image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();

        }

        [Fact(DisplayName = "Criando um Produto com descrição null")]
        public void CreatProduct_NullOrEmptyDescription()
        {
            Action action = () => new Product(1, "Name", null, 30.00m, 3, "Image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();

        }

        [Fact(DisplayName = "Criando um Produto com image maior que 250")]
        public void CreatProduct_MaximumImage()
        {
            Action action = () => new Product(1, "Name", "Description", 99, 10, "Image LOOOONNNGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();

        }

        [Fact(DisplayName = "Criando um Produto com preço negativo")]
        public void CreatProduct_ValueMegativePrice()
        {
            Action action = () => new Product(1, "Name", "Description", -30.00m, 3, "Image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();

        }

        [Fact(DisplayName = "Criando um Produto com Stock negativo")]
        public void CreatProduct_ValueMegativeStock()
        {
            Action action = () => new Product(1, "Name", "Description", 30.00m, -3, "Image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();

        }


    }
}
