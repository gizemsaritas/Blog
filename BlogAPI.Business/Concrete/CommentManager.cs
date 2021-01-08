using BlogAPI.Business.Interfaces;
using BlogAPI.DataAccess.Interfaces;
using BlogAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Business.Concrete
{
    public class CommentManager:GenericManager<Comment>,ICommentService
    {
        private readonly IGenericDal<Comment> _genericDal;
        public CommentManager(IGenericDal<Comment> genericDal):base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
