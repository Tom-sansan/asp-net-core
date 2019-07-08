using Microsoft.AspNetCore.Mvc;
using QuickMaster.Models;

namespace QuickMaster.Controllers
{
    public class HelloController : Controller
    {
        private readonly MyContext _context;

        public HelloController(MyContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return Content("Hello, World!");
        }

        public IActionResult Greet()
        {
            ViewBag.Message = "Hello, World!";
            return View();
        }

        public IActionResult List()
        {
            return View(this._context.Book);
        }
    }
}