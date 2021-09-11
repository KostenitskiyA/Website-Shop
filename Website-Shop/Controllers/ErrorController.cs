using Microsoft.AspNetCore.Mvc;
using Website_Shop.Models;

namespace Website_Shop.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet]
        public IActionResult Index(Error error)
        {
            return View(error);
        }
    }
}
