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

        public string GetToken(string Username, string Password)
        {
            TApiUser user = new TApiUser();
            user.Username = Username;
            user.Password = Password;

            string result = "";
            Client = new RestClient(TSiteSettings.ApiUrl + "//Token");
            var request = new RestRequest();
            request.AddJsonBody<TApiUser>(user);
            var response = Client.Post(request);
            TResult ResultData = JsonConvert.DeserializeObject<TResult>(response.Content);
            if (ResultData.Success)
            {
                result = ResultData.Data[0].ToString();
                
            }
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