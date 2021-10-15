using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.DatabaseContext.Services;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class LoginController : Controller
    {
        //Login Service
        readonly LoginService _login;
        public LoginController()
        {
            _login = new LoginService();
        }

        /// <summary>
        /// Login View
        /// </summary>
        /// <returns>View</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Checking the Login Information
        /// </summary>
        /// <param name="model">Username And Password</param>
        /// <returns>View</returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            var result = await _login.LoginAccountAsync(model.UserName, model.Password);
            if (!result.Status)
            {
                TempData["Error"] = string.Join("\n", result.Errors);
                return View("Index");
            }
            var userClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, result.Result.Name),
                new Claim(ClaimTypes.Email, result.Result.Username),
                new Claim("Id", result.Result.Id),
                new Claim(ClaimTypes.Role, (Convert.ToInt32(result.Result.Role)).ToString())
            };

            var userIdentity = new ClaimsIdentity(userClaims, "UserDetails");
            var userPrincipal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(userPrincipal);

            return RedirectToAction("Index", "Catalogue");
        }

        /// <summary>
        /// Logout User
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return View("Index");
        }
    }
}
