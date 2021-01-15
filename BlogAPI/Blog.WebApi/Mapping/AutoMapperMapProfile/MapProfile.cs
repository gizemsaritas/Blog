using AutoMapper;
using BlogAPI.DTO.DTOs.CategoryDtos;
using BlogAPI.DTO.DTOs.CommentDtos;
using BlogAPI.DTOs.DTO.BlogDtos;
using BlogAPI.Entities.Concrete;
using BlogAPI.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.WebApi.Mapping.AutoMapperMapProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Blog, BlogListDto>().ReverseMap();
            CreateMap<Blog, BlogUpdateModel>().ReverseMap();
            CreateMap<Blog, BlogAddModel>().ReverseMap();
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            CreateMap<Category, CategoryListDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
            CreateMap<Comment, CommentListDto>().ReverseMap();
            CreateMap<Comment, CommentAddDto>().ReverseMap();
        }
    }
}
