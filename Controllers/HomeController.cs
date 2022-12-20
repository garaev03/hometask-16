using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hometask_16.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
    }
}
