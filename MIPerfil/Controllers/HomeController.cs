using Microsoft.AspNetCore.Mvc;

namespace MIPerfil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MiPerfil()
        {
            return View();
        }
    }
}
