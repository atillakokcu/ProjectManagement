using PYS.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PYS.Application.Business;

namespace Pys.Application.RestFull.Controllers
{
    public class UserController : ApiController
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
        public HttpResponseMessage Post(TKullaniciKisiIletisim KisiBilgileri)
        {
            KullaniciIslemleri Kullanici = new KullaniciIslemleri();
            TResult result = Kullanici.Register(KisiBilgileri);

            var Response =  Request.CreateResponse<TResult>(HttpStatusCode.OK,result);

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