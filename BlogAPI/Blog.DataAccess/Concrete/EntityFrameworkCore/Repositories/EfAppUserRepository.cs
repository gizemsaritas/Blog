using BlogAPI.Business.Interfaces;
using BlogAPI.DataAccess.Concrete.EntityFrameworkCore.Context;
using BlogAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserRepository(BlogContext context) : base(context)
        {
        }
    }
}
