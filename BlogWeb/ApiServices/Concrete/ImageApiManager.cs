using System;
using System.Net.Http;
namespace BlogWeb.ApiServices.Concrete
{
    public class ImageApiManager
    {
        private readonly HttpClient _httpClient;

        public ImageApiManager(HttpClient httpClient)
        {
            _httpClient=httpClient;
            _httpClient.BaseAddress=new Uri("http://localhost:61056/api/images/");
        }
        public Task<string> GetBlogImageByIdAsync(int id){
            _httpClient.GetAsync($"GetBlogImageById/{id}");

        }
    }
}