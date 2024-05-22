using Microsoft.AspNetCore.Mvc;

namespace ASPCoreMiddlewares.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
