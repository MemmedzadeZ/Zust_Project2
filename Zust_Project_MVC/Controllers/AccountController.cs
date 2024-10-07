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

      




    };
}
