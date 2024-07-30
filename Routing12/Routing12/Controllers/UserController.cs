using Microsoft.AspNetCore.Mvc;

namespace Routing12.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
       
    }
}
