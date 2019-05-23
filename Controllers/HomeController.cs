using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HospitalPersonnelSystem.Models;
using HospitalPersonnelSystem.Data;
using Microsoft.AspNetCore.Authorization;

namespace HospitalPersonnelSystem.Controllers
{
    //权限
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

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
