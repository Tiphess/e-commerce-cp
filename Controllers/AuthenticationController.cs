using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using e_commerce_cp.Data;
using e_commerce_cp.Data.Interfaces;
using e_commerce_cp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace e_commerce_cp.Controllers
{
    public class AuthenticationController : Controller
    {
        private IAuthenticationRepository _repo;

        public AuthenticationController(IAuthenticationRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Login(User user = null)
        {
            if (user != null) ViewBag.RegisterSuccess = "You succesfully registered. You can now log in.";

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult RegisterNewUser(User user)
        {
            var registeredUser = _repo.Save(user);
            return RedirectToAction("Login", "Authentication", registeredUser);
        }

        public async Task<IActionResult> SignInUser(User user)
        {

            var userFromRepo = _repo.AuthenticateUser(user);
            if (userFromRepo == null)
            {
                ViewBag.ErrorMessage = "Your email or password is incorrect.";
                return View("Login");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, userFromRepo.Email),
                new Claim("FirstName", userFromRepo.FirstName),
                new Claim("LastName", userFromRepo.LastName),
                new Claim(ClaimTypes.Role, "User"),
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
