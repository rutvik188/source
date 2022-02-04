using Microsoft.AspNetCore.Mvc;

namespace TestApplication.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
