using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace coreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());


		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Index(Writer p)
		{
			p.WriterStatus = true;
			p.WriterAbout = "Deneme Test";
			wm.WriterAdd(p);
			return RedirectToAction("Index","Blog");
		}
	}
}

