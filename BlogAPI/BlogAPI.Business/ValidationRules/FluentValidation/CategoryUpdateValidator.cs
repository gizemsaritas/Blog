using BlogAPI.DTO.DTOs.CategoryDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Business.ValidationRules.FluentValidation
{
    class CategoryUpdateValidator:AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(0, int.MaxValue).WithMessage("id alanı boş geçilemez");
            RuleFor(I => I.Name).NotEmpty().WithMessage("ad alanı boş geçilemez");                
        }
    }
}
