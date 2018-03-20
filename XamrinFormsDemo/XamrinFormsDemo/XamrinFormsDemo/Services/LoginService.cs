using JanlekhApp.MobileAppService.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamrinFormsDemo.Services
{
    class LoginService
    {
       
        public LoginService()
        {
           
        }
        // The Login function makes a call to the Auth0 REST API
        // and attempts to authenticate the user.
        public User Login(string username, string password)
        {
            HttpClient client = new HttpClient();
            LoginModel logineModel = new LoginModel();
            logineModel.UserName = username;
            logineModel.Password = password;

            var data = JsonConvert.SerializeObject(logineModel);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = client.PostAsync(Constants.ApiUrl + "login", content).Result;          
            if (response != null)
            {
                return JsonConvert.DeserializeObject<User>(response.Content.ReadAsStringAsync().Result);
            }
            return null;
        }
    }
}
