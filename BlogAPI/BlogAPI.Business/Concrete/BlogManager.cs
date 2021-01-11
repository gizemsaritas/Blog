using BlogAPI.Business.Interfaces;
using BlogAPI.DataAccess.Interfaces;
using BlogAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.Business.Concrete
{
    public class BlogManager:GenericManager<Blog>,IBlogService
    {
        private readonly IGenericDal<Blog> _genericDal;
        public BlogManager(IGenericDal<Blog> genericDal):base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<Blog>> GetAllSortedByPostedTimeAsync()
        {
            return await _genericDal.GetAllAsync(I=>I.PostedTime);
        }
    }
}
