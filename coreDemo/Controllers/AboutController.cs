using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace coreDemo.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm=new AboutManager(new EfAboutRepository()); 


        public IActionResult Index()
        {
            var values = abm.GetListAbouts();

            return View(values);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
        public PartialViewResult WriterLastBlog()
        {
            return PartialView();
        }

	}
}
