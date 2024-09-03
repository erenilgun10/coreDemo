using Microsoft.AspNetCore.Mvc;

namespace coreDemo.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
