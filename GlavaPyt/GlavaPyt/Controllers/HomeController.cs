using Microsoft.AspNetCore.Mvc;

namespace GlavaPyt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
