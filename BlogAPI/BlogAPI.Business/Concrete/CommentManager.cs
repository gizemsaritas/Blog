using BlogAPI.Business.Interfaces;
using BlogAPI.DataAccess.Interfaces;
using BlogAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.Business.Concrete
{
    public class CommentManager:GenericManager<Comment>,ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(IGenericDal<Comment> genericDal,ICommentDal commentDal):base(genericDal)
        {
            _commentDal = commentDal;
        }

        public async Task<List<Comment>> GetAllWithsubCommentsAsync(int blogId, int? parentId)
        {
            return await _commentDal.GetAllWithsubCommentsAsync(blogId,parentId);
            
        }
    }
}
