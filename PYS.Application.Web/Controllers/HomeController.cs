using PYS.Application.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PYS.Application.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult GetTest()
        {

            return Json("selam", JsonRequestBehavior.AllowGet);
        }


        //public ActionResult Register()
        //{
        //    TRestClient client= new TRestClient();
        //    //client.Register()
        //}


    }
}