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
    //基础信息管理
    [Authorize]
    public class BasicController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<HPSUser> _userManager;

        public BasicController(ApplicationDbContext context, UserManager<HPSUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
