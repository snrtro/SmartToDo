using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index() 
        {
            return View();
        }
    }
}
