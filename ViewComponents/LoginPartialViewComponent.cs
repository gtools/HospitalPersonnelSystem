using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalPersonnelSystem.Models;
using HospitalPersonnelSystem.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace HospitalPersonnelSystem.ViewComponents
{
    public class LoginPartialViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<HPSUser> _signInManager;
        private readonly UserManager<HPSUser> _userManager;
        private readonly ILogger<LoginPartialViewComponent> _logger;

        public LoginPartialViewComponent(ApplicationDbContext context, SignInManager<HPSUser> signInManager, UserManager<HPSUser> userManager, ILogger<LoginPartialViewComponent> logger)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //判断用户是否登录
            ViewData["IsSignedIn"] = _signInManager.IsSignedIn(UserClaimsPrincipal);
            if ((bool)ViewData["IsSignedIn"])
            {
                var user = await _userManager.GetUserAsync(UserClaimsPrincipal);
                ViewData["UserId"] = user.Id;
                ViewData["UserName"] = user.UserName;
                ViewData["EmpName"] = user.SysEmp != null ? user.SysEmp.EmpName : "";
            }
            return View();
        }
    }
}