using BlogAPI.Business.Interfaces;
using BlogAPI.DataAccess.Interfaces;
using BlogAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Business.Concrete
{
    public class BlogManager:GenericManager<Blog>,IBlogService
    {
        private readonly IGenericDal<Blog> _genericDal;
        public BlogManager(IGenericDal<Blog> genericDal):base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
