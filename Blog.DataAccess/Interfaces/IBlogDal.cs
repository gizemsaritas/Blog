using BlogAPI.DataAccess.Interfaces;
using BlogAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPI.Business.Interfaces
{
    public interface IBlogDal:IGenericDal<Blog>
    {
    }
}
