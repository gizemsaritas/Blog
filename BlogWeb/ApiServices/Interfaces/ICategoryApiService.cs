using System.Collections.Generic;
using System.Threading.Tasks;
using BlogWeb.Models;

namespace BlogWeb.ApiServices.Interfaces
{
    public interface ICategoryApiService
    {
         Task<List<CategoryListModel>> GetAllAsync();
    }
}