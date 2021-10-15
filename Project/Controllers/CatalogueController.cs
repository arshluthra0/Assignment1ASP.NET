using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.DatabaseContext.Services;
using Project.Models;
using Project.Models.Enums;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Authorize]
    public class CatalogueController : Controller
    {
        //Product Service
        ProductService _productService;
        public CatalogueController()
        {
            _productService = new ProductService();
        }

        /// <summary>
        /// Catalogue View
        /// </summary>
        /// <returns>View</returns>
        public async Task<IActionResult> Index()
        {
            var userDetail = GetCliams();
            ViewBag.User = userDetail.Name;
            ViewBag.Role = userDetail.Role;
            var products = await _productService.GetProducts(userDetail.Id);
            if (!products.Status)
                return View(null);
            return View(products.Result);
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

        public IActionResult AddProduct()
        {
            if (GetCliams().Role != LoginEnum.Admin)
                return RedirectToAction("Index");
            return View();
        }

        /// <summary>
        /// Add New Product
        /// </summary>
        /// <param name="product">Product details</param>
        /// <param name="save">Save Button</param>
        /// <param name="clear">Clear Button</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductModel product, string save, string clear)
        {
            if (!string.IsNullOrEmpty(clear))
            {
                return RedirectToAction("AddProduct");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            var userDetail = GetCliams();
            if (string.IsNullOrEmpty(userDetail?.Id))
            {
                return RedirectToAction("Logout", "Login");
            }
            var result = await _productService.SaveProductAsync(product, userDetail.Id);
            if (!result.Status)
            {
                TempData["Error"] = result.Result;
                return View();
            }
            TempData["Error"] = "Record saved successfully";
            return RedirectToAction("AddProduct");
        }

        /// <summary>
        /// Detail for product record
        /// </summary>
        /// <param name="Id">Selected Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Detail(string Id)
        {
            if (GetCliams().Role != LoginEnum.Admin)
                return RedirectToAction("Index");
            var userDetail = GetCliams();
            if (string.IsNullOrEmpty(userDetail?.Id))
            {
                return RedirectToAction("Logout", "Login");
            }
            if (string.IsNullOrEmpty(Id))
            {
                TempData["Error"] = "Record not selected properly";
                return View("Index");
            }
            var result = await _productService.GetProduct(Id, userDetail.Id);
            if (!result.Status)
            {
                TempData["Error"] = result.Result;
                return View("Index");
            }
            return View(result.Result);
        }

        /// <summary>
        /// Delete Record
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Delete(string Id)
        {
            if (GetCliams().Role != LoginEnum.Admin)
                return RedirectToAction("Index");
            var userDetail = GetCliams();
            if (string.IsNullOrEmpty(userDetail?.Id))
            {
                return RedirectToAction("Logout", "Login");
            }
            if (string.IsNullOrEmpty(Id))
            {
                TempData["Error"] = "Record not selected properly";
                return RedirectToAction("Index");
            }
            var result = await _productService.DeleteProduct(Id, userDetail.Id);
            if (!result.Status)
            {
                TempData["Error"] = result.Result;
                return RedirectToAction("Index");
            }

            TempData["Error"] = "Record deleted successfully";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string Id)
        {
            if (GetCliams().Role != LoginEnum.Admin)
                return RedirectToAction("Index");
            var userDetail = GetCliams();
            if (string.IsNullOrEmpty(userDetail?.Id))
            {
                return RedirectToAction("Logout", "Login");
            }
            if (string.IsNullOrEmpty(Id))
            {
                TempData["Error"] = "Record not selected properly";
                return View("Index");
            }
            var result = await _productService.GetProduct(Id, userDetail.Id);
            if (!result.Status)
            {
                TempData["Error"] = result.Result;
                return View("Index");
            }
            return View(result.Result);
        }

        /// <summary>
        /// Edit Product Record
        /// </summary>
        /// <param name="product">Product Detail</param>
        /// <param name="save">Save Button</param>
        /// <param name="clear">Clear Button</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Edit(ProductModel product, string save, string clear)
        {
            if (GetCliams().Role != LoginEnum.Admin)
                return RedirectToAction("Index");
            if (!string.IsNullOrEmpty(clear))
            {
                return RedirectToAction("Index");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            var userDetail = GetCliams();
            if (string.IsNullOrEmpty(userDetail?.Id))
            {
                return RedirectToAction("Logout", "Login");
            }
            var result = await _productService.UpdateProductAsync(product, userDetail.Id);
            if (!result.Status)
            {
                TempData["Error"] = result.Result;
                return View();
            }
            TempData["Error"] = "Record updated successfully";
            return RedirectToAction("Index");
        }
    }
}
