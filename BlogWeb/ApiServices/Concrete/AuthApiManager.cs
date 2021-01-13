using System.Text;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlogWeb.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using BlogWeb.ApiServices.Interfaces;

namespace BlogWeb.ApiServices.Concrete
{
    public class AuthApiManager:IAuthApiService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly HttpClient _httpClient;

        public AuthApiManager(HttpClient httpClient,IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor=httpContextAccessor;
            _httpClient=httpClient;
            _httpClient.BaseAddress=new Uri("http://localhost:61056/api/Auth/");
        }
        public async Task<bool> SignIn(AppUserLoginModel model){
            var jsonData=JsonConvert.SerializeObject(model);
            var content=new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage= await _httpClient.PostAsync("SignIn",content);
            if(responseMessage.IsSuccessStatusCode){
                var accessToken=JsonConvert.DeserializeObject<AccessToken>( await responseMessage.Content.ReadAsStringAsync());
                _httpContextAccessor.HttpContext.Session.SetString("token",accessToken.Token);
                return true;
            }
            return false;
            
        }
    }
}