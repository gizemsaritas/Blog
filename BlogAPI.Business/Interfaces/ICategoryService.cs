using BlogAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.Business.Interfaces
{
    public interface ICategoryService:IGenericService<Category>
    {
        Task<List<Category>> GetAllSortedById();

    }
}
