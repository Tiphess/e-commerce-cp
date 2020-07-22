using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce_cp.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce_cp.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult RegisterNewUser(User user)
        {
            return RedirectToAction("Index", "Home");
        }


    }
}
