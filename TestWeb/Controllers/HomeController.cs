using Microsoft.AspNetCore.Mvc;
using TestWeb.Models;

namespace TestWeb.Controllers
{
    public class BmiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BmiModel());
        }

        [HttpPost]
        public IActionResult Index(BmiModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Result", model);
            }

            return View(model);
        }

        public IActionResult Result(BmiModel model)
        {
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
