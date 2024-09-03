using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace coreDemo.Controllers
{
    public class ContactController : Controller
    {

        ContactManager cm = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact c)
        {
			//if (string.IsNullOrWhiteSpace(c.ContactMessage))
			//{
			//	ModelState.AddModelError("ContactMessage", "Mesaj içeriğiniz boş olamaz...");
			//	return View(c);  
			//}
   //         else
   //         {
			c.ContactDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            c.ContactStatus = true;
            cm.ContactAdd(c);
            return RedirectToAction("Index","Blog");

			//}
		}

    }
}
