using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Zust_Project_MVC.Buisnes.Abstract;
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
        public ActionResult Register()
        {
            return View();
        }

        // GET: RegisterController/LogIn
        public ActionResult LogIn()
        {
            return View();
        }

        // GET: RegisterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegisterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterController/Register

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registervm)
        {
            return View(registervm);
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel loginvm)
        {
            return View(loginvm);
        }



      




    }
}
