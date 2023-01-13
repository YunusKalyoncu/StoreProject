using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StoreProject.DTOLayer.AppUserDtos;
using StoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserLoginDtos p)
        {
            var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Category");
            }
            else
            {
                return View();
            }
        }
    }
}
