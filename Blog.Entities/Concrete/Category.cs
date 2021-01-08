using BlogAPI.Entities.Interfaces;
using System.Collections.Generic;
namespace BlogAPI.Entities.Concrete
{
    public class Category:ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}