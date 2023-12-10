using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace frontend.Controllers
{
    [Authorize]
    public class MemberController : Controller
    {
        public IActionResult Index()
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var username = User.FindFirstValue(ClaimTypes.Name);
            return View();
        }
    }
}
