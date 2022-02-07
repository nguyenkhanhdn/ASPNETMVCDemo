using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace Lab3.Controllers
{
    public class SendMailController : Controller
    {
        // GET: SendMail
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            return View();
        }
        public ActionResult Send(EmailInfo model)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;

            client.UseDefaultCredentials = true;
            client.Credentials = new NetworkCredential("khanhdsp@gmail.com", "jjjjjjjjjjjjjjjj");
           // client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            
            var msg = new MailMessage();
            msg.From = new MailAddress( model.From);
            msg.To.Add(new MailAddress(model.To));
            msg.Subject = model.Subject;
            msg.Body = model.Message;
            client.Send(msg);

            ViewBag.Status = "Send thanh cong";
            return View("Index");
        }
    }
}