using BlogAPI.Business.Interfaces;
using BlogAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBlogRepository:EfGenericRepository<Blog>,IBlogDal
    {
    }
}
