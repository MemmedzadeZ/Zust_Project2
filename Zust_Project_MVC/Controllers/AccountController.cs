using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Zust_Project_MVC.Buisnes.Abstract;
using Zust_Project_MVC.Buisnes.Concrete;
using Zust_Project_MVC.Entity.Entities;
using Zust_Project_MVC.Models;

namespace Zust_Project_MVC.WebUI.Controllers
{
    public class AccountController : Controller
    {


        private readonly UserManager<CustomIdentityUser> _userManager;
        private readonly RoleManager<CustomIdentityRole> _roleManager;
        private readonly SignInManager<CustomIdentityUser> _signInManager;
        private readonly IUserServices _userServices;

        public AccountController(UserManager<CustomIdentityUser> userManager,
            RoleManager<CustomIdentityRole> roleManager,
            SignInManager<CustomIdentityUser> signInManager,
            IUserServices userServices)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _userServices = userServices;
        }

        // GET: RegisterController/Register
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // GET: RegisterController/LogIn
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        //// GET: RegisterController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: RegisterController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: RegisterController/Register

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registervm)
        {
            if (ModelState.IsValid)
            {
                CustomIdentityUser user = new CustomIdentityUser
                {
                    UserName = registervm.Username,
                    Email = registervm.Email,
                    City = registervm.City,
                };

                IdentityResult result = await _userManager.CreateAsync(user, registervm.Password);
                if (result.Succeeded)
                {
                    CustomIdentityRole role = new CustomIdentityRole
                    {
                        Name = "Admin"
                    };
                    IdentityResult roleResult = await _roleManager.CreateAsync(role);
                    if (!roleResult.Succeeded)
                    {
                        ModelState.AddModelError("", "We can not add the role!");
                    }
                }
                await _userManager.AddToRoleAsync(user, "Admin");
                return RedirectToAction("LogIn", "Account");


            }
            return View(registervm);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LoginViewModel loginvm)
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(
                    loginvm.Username,
                    loginvm.Password,
                    loginvm.RememberMe,
                  false
                );

                if (result.Succeeded)
                {
                    var user = await _userServices.GetAsync(u => u.UserName == loginvm.Username);
                    user.IsOnline = true;
                    await _userServices.UpdateAsync(user);

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid LogIn");
            }

            return View(loginvm);
        }








    };
}
