using centriq_dec_2015_site2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace centriq_dec_2015_site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult Bios()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactUs(ContactViewModel cvw)
        {       
            if (!ModelState.IsValid)
            {
                return View(cvw);
            }

          
            string body = string.Format("{0} has sent you a message with a subject of: {1}. <br/> The message is {2}. <br/>" +
                                        "You can contact them at {3}.", cvw.Name, cvw.Subject, cvw.Message, cvw.Email);

                       
            MailMessage msg = new MailMessage(
                "resources@lillianfleming.net", //From:
                "lillian@lillianfleming.net", //To:
                "New Message from website", //Subject:
                body); //body is the message constructed above

            msg.Priority = MailPriority.High;
            msg.IsBodyHtml = true;

            using (SmtpClient client = new SmtpClient())
            {
                //Settings to use Centriq Gmail Relay
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(
                    "centriqRelay@gmail.com", "c3ntriQc3ntriQ");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(msg);

            }

                        
            //using (SmtpClient client = new SmtpClient("relay-hosting.secureserver.net"))
            //{
            //    client.Send(msg);
            //}

                        
            return RedirectToAction("ReallyThankYou");

        }

        public ActionResult ReallyThankYou()
        {
            return View();
        }

        public ActionResult Resources()
        {
            return View();
        }
        public ActionResult ThankYou() 
        { 
            return View(); 
        }
    }
}