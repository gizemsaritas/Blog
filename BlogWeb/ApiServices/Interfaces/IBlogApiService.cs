using System.Collections.Generic;
using System.Threading.Tasks;
using BlogWeb.Models;

namespace BlogWeb.ApiServices.Interfaces
{
    public interface IBlogApiService
    {
         Task<List<BlogListModel>> GetAllAsync();
         Task<BlogListModel> GetByIdAsync(int id);
         Task<List<BlogListModel>> GetAllByCategoryIdAsync(int id);
         Task AddAsync(BlogAddModel model);
         Task UpdateAsync(BlogUpdateModel model);
         Task DeleteAsync(int id);
         Task<List<CommentListModel>> GetCommentsAsync(int blogId,int? parentCommentId);
    }
}