using JoPostFinalPro.Data;
using JoPostFinalPro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoPostFinalPro.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext db;
        public AccountController(ApplicationDbContext _db)
        {
            db = _db;
        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var chkUse = db.Users.Where(x => x.UName.Equals(user.UName) &&
            x.Password.Equals(user.Password));
            if (chkUse.Any())
            {
                // do to dashboard
                HttpContext.Session.SetString("uName", user.UName);
                if (chkUse.FirstOrDefault().RoleId == 1)
                {
                    return RedirectToAction("Index", "Home", new { area = "Dashboard" });
                }

            };
            ViewBag.error = "Invalid user/password";
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
