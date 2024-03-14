using Microsoft.AspNetCore.Mvc;

namespace Qfresh_Project.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
