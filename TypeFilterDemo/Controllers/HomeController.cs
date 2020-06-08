using Microsoft.AspNetCore.Mvc;
using TypeFilterDemo.Filters;

namespace TypeFilterDemo.Controllers
{
    public class HomeController : Controller
    {
        [AddRandomNumberHeader]
        [TypeFilter(typeof(AddRandomNumberHeaderFilter))]
        [AddRandomNumberHeader2]
        public IActionResult Index()
        {
            return Content("Hello world.");
        }
    }
}