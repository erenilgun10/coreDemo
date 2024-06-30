using Microsoft.AspNetCore.Mvc;

namespace coreDemo.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
