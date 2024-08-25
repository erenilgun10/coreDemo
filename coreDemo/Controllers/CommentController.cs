using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace coreDemo.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}


		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}

        public JsonResult PartialAddComment(Comment p, int BlogId)
        {
            // Debug: BlogId'yi kontrol et
            Console.WriteLine($"BlogId: {BlogId}");

            p.CommentDateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogId = BlogId;

            // Veritabanına kayıt işlemi
            cm.CommentAdd(p);

            return Json(new { success = true });
        }

        public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.GetList(id);
			return PartialView(values);
		}
	}
}
