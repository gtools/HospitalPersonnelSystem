using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HospitalPersonnelSystem.Models;
using HospitalPersonnelSystem.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace HospitalPersonnelSystem.Controllers
{
    //任何经过身份验证的用户
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<HPSUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<HPSUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        //允许未经身份验证的用户
        [AllowAnonymous]
        [Route("Initialize")]
        [Route("Home/Initialize")]
        public IActionResult Initialize()
        {
            return View();
        }

        [Route("Initialize")]
        [Route("Home/Initialize")]
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Initialize(bool clear)
        {
            if (clear)
                SeedData.Clear(_context, _userManager);
            else
                SeedData.Initialize(_context, _userManager);
            return Json("OK");
        }

        [Route("Login")]
        [Route("Home/Login")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return Redirect("~/Identity/Account/Login");
        }

        [Route("Logout")]
        [Route("Home/Logout")]
        [AllowAnonymous]
        public IActionResult Logout()
        {
            return Redirect("~/Identity/Account/Logout");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// 拼音码
        /// </summary>
        /// <param name="chinese">参数</param>
        /// <returns></returns>
        public IActionResult GetSpell(string chinese)
        {
            //chinese = HttpUtility.UrlDecode(chinese);
            //chinese = HtmlEncoder.Default.Encode(chinese);
            return Json(GTSharp.Core.PinYinHelper.GetFirstPinyin(chinese));
        }
    }
}
