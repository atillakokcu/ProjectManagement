using PYS.Application.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PYS.Application.Web.Controllers
{
    public class ApiController : Controller
    {


        [HttpPost]
        public ActionResult Login(string Username,string Password)
        {
            TRestClient client= new TRestClient();
            string resultdata = client.GetToken(Username, Password);
            return Json(resultdata,JsonRequestBehavior.AllowGet);



        }


    }
}