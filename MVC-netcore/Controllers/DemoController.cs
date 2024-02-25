using Microsoft.AspNetCore.Mvc;

namespace MVC_netcore.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
