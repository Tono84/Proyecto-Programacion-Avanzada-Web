﻿using Microsoft.AspNetCore.Mvc;

namespace frontend.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
