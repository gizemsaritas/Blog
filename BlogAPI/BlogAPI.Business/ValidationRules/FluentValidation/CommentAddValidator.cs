using BlogAPI.DTO.DTOs.CommentDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Business.ValidationRules.FluentValidation
{
    public class CommentAddValidator:AbstractValidator<CommentAddDto>
    {
        public CommentAddValidator()
        {
            RuleFor(I => I.AuthorName).NotEmpty().WithMessage("Ad alanı bış bırakılamaz");
            RuleFor(I => I.AuthorEmail).NotEmpty().WithMessage("Mail alanı bış bırakılamaz");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama alanı bış bırakılamaz");
        }
    }
}
