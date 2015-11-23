using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace centriq_dec_2015_site.Controllers
{
    public class RichardController : Controller
    {

        public  ActionResult Bio()
        {
            return View();
        }


        // GET: Richard
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BurritoConverter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BurritoConverter(string itemBought, decimal itemCost)
        {
            ViewBag.itemBought = itemBought;
            ViewBag.itemCost = itemCost;
            decimal chickenBurrito = 6.50M;
            decimal chickBurritoAddGuac = 8.45M;
            decimal bigBurritoConverstion = itemCost / chickenBurrito;
            decimal bigBurritoAddGuacConversion = itemCost / chickBurritoAddGuac;
            int burritoWithGuacConversion = (int)bigBurritoAddGuacConversion;
            int burritoConversion = (int)bigBurritoConverstion;
            ViewBag.burritoConversion = burritoConversion;
            ViewBag.burritoWithGuacConversion = burritoWithGuacConversion;

            return View("BurritoConversion");
        }
    }
}