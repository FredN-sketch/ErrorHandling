using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpGet("/throw")]
        public IActionResult Throw()
        {

            return View();
        }
    }
}
