using Microsoft.AspNetCore.Mvc;
using QuickMaster_Core3.Models;

namespace QuickMaster_Core3.Controllers
{
    public class HelloController : Controller
    {
        private readonly MyContext _context;

        public HelloController(MyContext context)
        {
            this._context = context;
        }

        [Route("Hoge/Foo")]
        public IActionResult Index()
        {
            return Content("Hello World!");
        }

        public IActionResult Greet()
        {
            ViewBag.Message = "<h1>Hello, World!!!</h1>";
            return View();
        }

        public IActionResult List()
        {
            return View(this._context.Book);
        }
    }
}