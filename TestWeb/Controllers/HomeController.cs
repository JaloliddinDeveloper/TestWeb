using Microsoft.AspNetCore.Mvc;

namespace TestWeb.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
    }
}
