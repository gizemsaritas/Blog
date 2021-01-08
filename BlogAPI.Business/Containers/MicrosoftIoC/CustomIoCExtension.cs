using BlogAPI.Business.Concrete;
using BlogAPI.Business.Interfaces;
using BlogAPI.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using BlogAPI.DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BlogAPI.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

        }
    }
}
