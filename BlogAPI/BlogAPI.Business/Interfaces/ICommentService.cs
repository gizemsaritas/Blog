using BlogAPI.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogAPI.Business.Interfaces
{
    public interface ICommentService:IGenericService<Comment>
    {
        Task<List<Comment>> GetAllWithsubCommentsAsync(int blogId, int? parentId);
    }
}
