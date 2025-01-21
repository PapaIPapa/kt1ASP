using Microsoft.AspNetCore.Mvc;

namespace kt1ASP.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }

        [HttpGet]
        [Route("Page/Greet/{name}")]
        public IActionResult Greet(string name)
        {
            return View("Greet", name);
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(string message)
        {
            ViewBag.Message = message; 
            return View("EditConfirmed");
        }
    }
}
