using BlogAPI.DTO.DTOs.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Business.ValidationRules.FluentValidation
{
    public class AppUserLoginValidator:AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("kullanıcı adı boş geçilemez");
            RuleFor(I => I.Password).NotEmpty().WithMessage("parola alanı boş geçilemez");
        }
    }
}
