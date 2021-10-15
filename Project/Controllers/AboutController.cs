using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Models.Enums;
using System;
using System.Security.Claims;

namespace Project.Controllers
{
    [Authorize]
    public class AboutController : Controller
    {
        /// <summary>
        /// About Us main page
        /// </summary>
        /// <returns>View</returns>
        public IActionResult Index()
        {
            var userDetail = GetCliams();
            ViewBag.User = userDetail.Name;
            return View();
        }

        /// <summary>
        /// Checking the User Details
        /// </summary>
        /// <returns>{LoggedInDetails} User Details</returns>
        private LoggedInDetails GetCliams()
        {
            LoggedInDetails log = new LoggedInDetails();
            var identity = (ClaimsIdentity)User.Identity;
            var details = identity.Claims;
            foreach (var claim in details)
            {
                switch (claim.Type)
                {
                    case ClaimTypes.Name:
                        log.Name = claim.Value;
                        break;
                    case ClaimTypes.Email:
                        log.EmailId = claim.Value;
                        break;
                    case "Id":
                        log.Id = claim.Value;
                        break;
                    case ClaimTypes.Role:
                        log.Role = (LoginEnum)(Convert.ToInt32(claim.Value));
                        break;
                }
            }
            return log;
        }
    }
}
