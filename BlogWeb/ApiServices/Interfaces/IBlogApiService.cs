using System.Collections.Generic;
using System.Threading.Tasks;
using BlogWeb.Models;

namespace BlogWeb.ApiServices.Interfaces
{
    public interface IBlogApiService
    {
         Task<List<BlogListModel>> GetAllAsync();
         Task<BlogListModel> GetByIdAsync(int id);
    }
}