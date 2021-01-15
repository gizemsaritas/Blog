using BlogAPI.DataAccess.Interfaces;
using BlogAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.Business.Interfaces
{
    public interface ICommentDal:IGenericDal<Comment>
    {
        Task<List<Comment>> GetAllWithsubCommentsAsync(int blogId, int? parentId);
    }
}
