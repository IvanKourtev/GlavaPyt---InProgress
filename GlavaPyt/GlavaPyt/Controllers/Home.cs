using Microsoft.AspNetCore.Mvc;

namespace GlavaPyt.Controllers
{
    public class Home : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
