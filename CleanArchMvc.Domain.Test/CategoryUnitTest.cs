using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Test
{
    public class CategoryUnitTest
    {
        [Fact(DisplayName ="Criando uma categoria com estado valido")]
        public void CreateCategory_WithValidParameters_Result_ObjectValidState()
        {
            Action action = () => new Category(1, "name");
            action.Should()
                .NotThrow <CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criando uma categoria com ID negativo")]
        public void CreateCategoru_NegativeId_Value()
        {
            Action action = () => new Category(-1, "Name");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>().WithMessage("Invalid id value");
        }

        [Fact(DisplayName = "Criando uma categoria com name menor igual a 3 letras")]
        public void CreateCategory_ShortNameValue()
        {
            Action action = () => new Category(1, "Na");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criando Categoria com nome vazio")]
        public void CreateCategoru_MissinggNameValue()
        {
            Action action = () => new Category(1, "");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criando Categoria com nome null")]
        public void CreateCategoru_WithNullNameValue()
        {
            Action action = () => new Category(1, null);
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }


    }
}
