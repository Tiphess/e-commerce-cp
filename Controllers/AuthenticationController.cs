using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using e_commerce_cp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
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

        public async Task<IActionResult> SignInUser(User user)
        {
            //Logic to get the user's role and see if he exists.. hard code for now
            user.FirstName = "Guillaume";
            user.LastName = "Cadieux";

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim("FirstName", user.FirstName),
                new Claim("LastName", user.LastName),
                new Claim(ClaimTypes.Role, "Administrator"),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30),
                IsPersistent = true,
                RedirectUri = "/Home/Index"
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> SignOutUser()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

    }
}
