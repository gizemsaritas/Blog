using System.Threading.Tasks;

namespace BlogWeb.ApiServices.Interfaces
{
    public interface IImageApiService
    {
         Task<string> GetBlogImageByIdAsync(int id);
    }
}