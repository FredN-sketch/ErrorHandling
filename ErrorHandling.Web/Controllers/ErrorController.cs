using ErrorHandling.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers
{
    public class ErrorController : Controller
    {
        static SlowService slowService = new SlowService();

            
        [HttpGet("error/exception")]
        public async Task <IActionResult> ServerError()
        {
          await slowService.DoSlowWork();
            return View();
        }
        [HttpGet("error/http/{statusCode}")]
        public IActionResult HttpError(int statusCode)
        {
            return View(statusCode);
        }
    }
}
