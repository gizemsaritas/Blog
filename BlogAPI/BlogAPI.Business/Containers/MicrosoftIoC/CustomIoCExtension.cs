
using BlogAPI.Business.Concrete;
using BlogAPI.Business.Interfaces;
using BlogAPI.Business.Tools.JWTTool;
using BlogAPI.Business.ValidationRules.FluentValidation;
using BlogAPI.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using BlogAPI.DataAccess.Interfaces;
using BlogAPI.DTO.DTOs.AppUserDtos;
using BlogAPI.DTO.DTOs.CategoryBlogDtos;
using BlogAPI.DTO.DTOs.CategoryDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BlogAPI.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal,EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<IJwtService, JwtManager>();

            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();


        }
    }
}
