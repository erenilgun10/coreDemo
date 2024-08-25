using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace coreDemo.Controllers
{
    public class NewsLetterController : Controller
    {

        NewsLetterManager nm = new NewsLetterManager(new EFNewsLetterRepository());


        [HttpGet]

        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }


        [HttpPost]
        public JsonResult SubscribeMail(NewsLetter p)
        {

            if (nm.IsEmailExists(p.Mail))
            {
                return Json(new { success = false, message = "Bu e-posta adresi zaten mevcut." });
            }
            p.MailStatus = true;
            nm.AddNewsLetter(p);
            return Json(new { success = true });
        }
    }
}
