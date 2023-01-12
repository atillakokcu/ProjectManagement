using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using static System.Net.WebRequestMethods;
using PYS.Application.Data;
using Newtonsoft.Json;

namespace PYS.Application.Web.Models
{
    public class TRestClient
    {
        private RestClient Client;


        public string Test()
        {
            Client = new RestClient(TSiteSettings.ApiUrl + "//Token/");

            var request = new RestRequest();
            var response = Client.Get(request);
            return response.Content;
        }

        public TResult GetToken(string Username, string Password)
        {
            TResult result= new TResult();
            TApiUser ApiUser = new TApiUser();
            ApiUser.Username = Username;
            ApiUser.Password = Password;

            Client = new RestClient(TSiteSettings.ApiUrl+"//Token");
            var request= new RestRequest();
            request.AddJsonBody<TApiUser>(ApiUser);
            var response = Client.Get(request); 
            result = JsonConvert.DeserializeObject<TResult>(response.Content);
            return result;
        }



        public TResult Register(TKullaniciKisiIletisim KisiBilgileri)
        {
            TResult result = new TResult();
            
            Client = new RestClient(TSiteSettings.ApiUrl + "//User");

            var request = new RestRequest();
            request.AddJsonBody(KisiBilgileri);
            var Response= Client.Post(request);
            result = JsonConvert.DeserializeObject<TResult>(Response.Content);



            return result;
        }





    }
}