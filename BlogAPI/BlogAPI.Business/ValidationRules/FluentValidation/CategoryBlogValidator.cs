using BlogAPI.DTO.DTOs.CategoryBlogDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Business.ValidationRules.FluentValidation
{
    public class CategoryBlogValidator:AbstractValidator<CategoryBlogDto>
    {
        public CategoryBlogValidator()
        {
            RuleFor(I => I.CategoryId).InclusiveBetween(0, int.MaxValue).WithMessage("categoryId boş geçilemez");
            RuleFor(I => I.BlogId).InclusiveBetween(0, int.MaxValue).WithMessage("BlogId boş geçilemez");

        }
    }
}
