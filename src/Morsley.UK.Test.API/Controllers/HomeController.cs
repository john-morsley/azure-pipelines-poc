using Microsoft.AspNetCore.Mvc;

namespace Morsley.UK.Test.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
