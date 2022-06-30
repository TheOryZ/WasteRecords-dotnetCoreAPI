using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WasteRecords.WebUI.ApiServices.Interfaces;
using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.UserModels;

namespace WasteRecords.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAuthApiService _authApiService;

        public HomeController(ILogger<HomeController> logger, IAuthApiService authApiService)
        {
            _logger = logger;
            _authApiService = authApiService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(SignInViewModel model)
        {
            TempData["message"] = "Email or Password is wrong";
            TempData["status"] = "error";
            if (_authApiService.SignIn(model))
            {
                TempData["status"] = "success";
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}