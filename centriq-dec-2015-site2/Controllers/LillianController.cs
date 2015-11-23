using centriq_dec_2015_site2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace centriq_dec_2015_site.Controllers
{
    public class LillianController : Controller
    {
        // GET: Lillian

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bio()
        {
            return View();
        }




        public ActionResult ContactUs()
        {
            ViewBag.Message = "Our Contact Page";
            return View();
        }






        public ActionResult ReallyThankYou()
        {
            return View();
        }





    }
}