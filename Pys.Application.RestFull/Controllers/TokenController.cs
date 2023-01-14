using PYS.Application.Business;
using PYS.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pys.Application.RestFull.Controllers
{
    public class TokenController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Post(TUser User)
        {
            IEnumerable<string> values;
            HttpResponseMessage Response = new HttpResponseMessage();

            bool GetSecretKey = Request.Headers.TryGetValues("SecretKey", out values);
            if (GetSecretKey)
            {


            }
            string SecretKey = values.First();

            KullaniciIslemleri Kullanici = new KullaniciIslemleri();
            TResult result = Kullanici.GetToken(User.Username, User.Password);

            if (!result.Success)
            {
                Response = Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                Response = Request.CreateResponse<TResult>(HttpStatusCode.OK, result);
            }


            return Response;


        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}