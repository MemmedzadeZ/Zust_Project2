using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Zust_Project_MVC.Buisnes.Abstract;
using Zust_Project_MVC.Buisnes.Concrete;
using Zust_Project_MVC.Entity.Entities;
using Zust_Project_MVC.Models;

namespace Zust_Project_MVC.WebUI.Controllers
{
    public class AccountController : Controller
    {
      
        private readonly UserManager<CustomIdentityUser> _userManager;
        private readonly SignInManager<CustomIdentityUser> _signInManager;
		private readonly RoleManager<CustomIdentityRole> _roleManager;

		private readonly IUserServices _userServices;

		public AccountController(UserManager<CustomIdentityUser> userManager,
			SignInManager<CustomIdentityUser> signInManager,
			IUserServices userServices,
			RoleManager<CustomIdentityRole> roleManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_userServices = userServices;
			_roleManager = roleManager;
		}


		// GET: AccountController/Register
		[HttpGet]
        public ActionResult Register()
        {
            return View();
        }

		// GET: AccountController/LogIn
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


		// POST: AccountController/Register

		[HttpPost]
		public async Task<ActionResult> Register(RegisterViewModel model)
		{
			//if (ModelState.IsValid)
			//{
			//	return View(model);

			//}
			//var user = new CustomIdentityUser
			//{
			//	UserName = model.Username,
			//	Email = model.Email,

			//};

			//var result = await _userManager.CreateAsync(user , model.Password);
			//if(result.Succeeded)
			//{
			//	await _signInManager.SignInAsync(user,  isPersistent: false);
			//	return RedirectToAction("LogIn", "Account");
			//}


			if (ModelState.IsValid)
			{
				CustomIdentityUser user = new CustomIdentityUser
				{
					UserName = model.Username,
					Email = model.Email,
				};
				if (model.Password == model.ConfirmPassword)
				{
					IdentityResult result = await _userManager.CreateAsync(user, model.Password);
					if (result.Succeeded)
					{
							CustomIdentityRole role = new CustomIdentityRole
							{
								Id = Guid.NewGuid().ToString(),
								Name = "Admin"
							};

							IdentityResult roleResult = await _roleManager.CreateAsync(role);
							if (!roleResult.Succeeded)
							{
								return View(model);
							}
							await _userManager.AddToRoleAsync(user, "Admin");
							return RedirectToAction("LogIn", "Account");

					}

				}


			}
				return View(model);


			// POST: AccountController/LogIn

		}
			[HttpPost]

			public async Task<ActionResult> LogIn(LoginViewModel model)
			{
				if (!ModelState.IsValid)
				{
					return View(model);
				}

				var user = await _userManager.FindByNameAsync(model.Username);



				if (user != null)
				{
					var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
					if (result.Succeeded)
					{
						return RedirectToAction("Index", "Home");
					}
				}
				return View(model);
			}





	};
}
