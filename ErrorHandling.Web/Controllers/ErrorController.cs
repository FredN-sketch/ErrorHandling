using ErrorHandling.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
        public async Task<IActionResult> HttpErrorAsync(int statusCode)
        {
            var timer = Stopwatch.StartNew();
            await slowService.DoSlowWork();
            timer.Stop();
            Console.WriteLine($"Total: {timer.Elapsed.TotalSeconds}");
            return View(statusCode);
        }
    }
}
