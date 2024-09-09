using Microsoft.AspNetCore.Mvc;

namespace GlavaPyt.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
