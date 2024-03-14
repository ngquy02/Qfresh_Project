using Microsoft.AspNetCore.Mvc;

namespace Qfresh_Project.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
