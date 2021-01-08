using BlogAPI.Business.Interfaces;
using BlogAPI.DataAccess.Interfaces;
using BlogAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Business.Concrete
{
    public class CategoryManager:GenericManager<Category>,ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;
        public CategoryManager(IGenericDal<Category> genericDal):base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
