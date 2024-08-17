using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace coreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            var values = bm.GetBlockListWithCategory();
            return View(values);
        }

		public IActionResult BlogReadAll(int id)
		{

            
            ViewBag.i=id;
            var values = bm.GetBlogById(id);
			
            return View(values);
		}

	}
}
