using Microsoft.AspNetCore.Mvc;

namespace Routing12.Controllers
{

    //[Route("Home")]
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]
        //[Route("Index")]
        //[Route("[action]")]
        [Route("~/")]
        [Route("~/Home")]
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Data1()
        //{
        //    return View("~/Views/Home/Index.cshtml");
        //}

        //[Route("About")]
        //[Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        //[Route("(Details)/{id?}")]
        //[Route("[action]/{id?}")]
         [Route("{id?}")]
        public int Details(int? id)
        {
            return id ?? 1;
        }
    }
}
