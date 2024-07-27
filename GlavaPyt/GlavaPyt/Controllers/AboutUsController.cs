using Microsoft.AspNetCore.Mvc;

namespace GlavaPyt.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
