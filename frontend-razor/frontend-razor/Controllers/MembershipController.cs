using Microsoft.AspNetCore.Mvc;

namespace frontend.Controllers
{
    public class MembershipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Confirmation() 
        {
            return View();
        }

    }
}
