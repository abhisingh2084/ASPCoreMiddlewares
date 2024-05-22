using Microsoft.AspNetCore.Mvc;

namespace ASPCoreMiddlewares.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            //ViewData["data1"] = "programer";
            //ViewData["data2"] = "25";
            //ViewData["data3"] = DateTime.Now.ToLongDateString();

            //string[] arr = { "abhishek", "kumar", "aryan" };

            //ViewData["data4"] = arr;

            //ViewData["Data5"] = new List<string>()
            //{
            //    "Cricket","Football", "Hockey"
            //};

            return View();
        }

        [Route("Home/About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Home/Details/{id?}")]
        public int Details(int? id)
        {
            return id ?? 1;
        }
    }
}
 