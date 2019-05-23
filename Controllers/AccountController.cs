using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HospitalPersonnelSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return Redirect("~/Identity/Account/Register");
        }
        public IActionResult Login()
        {
            return Redirect("~/Identity/Account/Login");
        }
    }
}