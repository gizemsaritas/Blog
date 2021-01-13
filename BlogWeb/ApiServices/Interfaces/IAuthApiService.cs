using System.Threading.Tasks;
using BlogWeb.Models;

namespace BlogWeb.ApiServices.Interfaces
{
    public interface IAuthApiService
    {
         Task<bool> SignIn(AppUserLoginModel model);
    }
}