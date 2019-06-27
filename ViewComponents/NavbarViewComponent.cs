using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalPersonnelSystem.Models;
using HospitalPersonnelSystem.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace HospitalPersonnelSystem.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<HPSUser> _userManager;
        private readonly SignInManager<HPSUser> _signInManager;

        public NavbarViewComponent(ApplicationDbContext context, UserManager<HPSUser> userManager, SignInManager<HPSUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //用户是否登录
            var IsSignedIn  = _signInManager.IsSignedIn(UserClaimsPrincipal);
            ViewData["IsSignedIn"] = IsSignedIn;
            if (IsSignedIn)
            {
                var user = await _userManager.GetUserAsync(UserClaimsPrincipal);
                //用户名
                ViewData["EmpCode"] = user.EmpCode;
                ViewData["EmpName"] = _context.SysEmps.Where(t => t.EmpCode == user.EmpCode).First().EmpName;
                var sysNavbarTypes = await _context.SysNavbarTypes.Include(t => t.SysNavbars).OrderBy(t => t.Sort).ToListAsync();
                var claims = await _userManager.GetClaimsAsync(user);
                //管理员权限
                if (claims.Where(t => t.Value == "000000").Any())
                    return View(sysNavbarTypes);
                //一般权限
                foreach (var sysNavbar in sysNavbarTypes)
                {
                    foreach (var item in sysNavbar.SysNavbars)
                    {
                        if (!claims.Where(t => t.Value == item.Controller).Any())
                            sysNavbar.SysNavbars.Remove(item);
                    }
                    if (!sysNavbar.SysNavbars.Any())
                        sysNavbarTypes.Remove(sysNavbar);
                }
                return View(sysNavbarTypes);
            }
            else
            {
                return View(new List<SysNavbarType>());
            }
        }
    }
}