using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlogWeb.ApiServices.Interfaces;
using BlogWeb.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using BlogWeb.Extensions;
using System.IO;

namespace BlogWeb.ApiServices.Concrete
{
    public class BlogApiManager : IBlogApiService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly HttpClient _httpClient;

        public BlogApiManager(HttpClient httpClient,IHttpContextAccessor httpContextAccessor )
        {
            _httpContextAccessor=httpContextAccessor;
            _httpClient=httpClient;
            _httpClient.BaseAddress=new Uri("http://localhost:61056/api/blogs/");
        }
        public async Task<List<BlogListModel>> GetAllAsync()
        {
            var responseMessage=await _httpClient.GetAsync("");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<List<BlogListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<BlogListModel> GetByIdAsync(int id)
        {
            var responseMessage=await _httpClient.GetAsync($"{id}");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<BlogListModel>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<List<BlogListModel>> GetAllByCategoryIdAsync(int id){
            var responseMessage=await _httpClient.GetAsync($"GetAllByCategoryId/{id}");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<List<BlogListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task AddAsync(BlogAddModel model){
            
           MultipartFormDataContent formData = new MultipartFormDataContent();
            if (model.Image != null)
            {
                var bytes = await File.ReadAllBytesAsync(model.Image.FileName);
                ByteArrayContent byteContent = new ByteArrayContent(bytes);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue(model.Image.ContentType);

                formData.Add(byteContent, nameof(BlogAddModel.Image), model.Image.FileName);
            }

            var user= _httpContextAccessor.HttpContext.Session.GetObject<AppUserViewModel>("activeUser");
            model.AppUserId=user.Id;

            formData.Add(new StringContent(model.AppUserId.ToString()), nameof(BlogAddModel.AppUserId));
           
            formData.Add(new StringContent(model.ShortDescription), nameof(BlogAddModel.ShortDescription));

            formData.Add(new StringContent(model.Description),nameof(BlogAddModel.Description));

            formData.Add(new StringContent(model.Title),nameof(BlogAddModel.Title));

            _httpClient.DefaultRequestHeaders.Authorization= new AuthenticationHeaderValue("Bearer",_httpContextAccessor.HttpContext.Session.GetString("token"));

            await _httpClient.PostAsync("",formData);
        }
    }
}