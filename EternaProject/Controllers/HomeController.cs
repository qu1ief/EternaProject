using Microsoft.AspNetCore.Mvc;

namespace EternaProject.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
