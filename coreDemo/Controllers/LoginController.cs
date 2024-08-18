using Microsoft.AspNetCore.Mvc;

namespace coreDemo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
