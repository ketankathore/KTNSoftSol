using EasyCareSoft.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyCareSoft.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin(UserLogins userlogin)
        {


            return RedirectToAction("Index", "Home");
        }
    }
}
