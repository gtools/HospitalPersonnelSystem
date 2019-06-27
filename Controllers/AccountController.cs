using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using HospitalPersonnelSystem.Data;
using HospitalPersonnelSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using GTSharp;

//区域匹配机制
//Areas/<Area-Name>/Views/<Controller-Name>/<Action-Name>.cshtml
//Areas/<Area-Name>/Views/Shared/<Action-Name>.cshtml
//Views/Shared/<Action-Name>.cshtml
//Pages/Shared/<Action-Name>.cshtml
//<a asp-area="Products" asp-controller="Home" asp-action="About">
//Products/Home/About
//</a>

namespace HospitalPersonnelSystem.Areas.Admin.Controllers
{
    /// <summary>
    /// 账号管理权限管理
    /// </summary>
    //[Authorize(Roles = "Account")]//权限
    //[Area("Admin")]//区域
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<HPSUser> _userManager;
        private readonly RoleManager<HPSRole> _roleManager;
        private readonly ILogger<AccountController> _logger;

        public AccountController(ApplicationDbContext context, UserManager<HPSUser> userManager, RoleManager<HPSRole> roleManager, ILogger<AccountController> logger)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        // GET: Admin/User/Index 账号管理
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.Include(t => t.SysEmp).OrderBy(t => t.EmpCode).ToListAsync());
        }

        // GET: Admin/User/Register 注册
        public IActionResult Register()
        {
            ViewData["EmpCode"] = new SelectList(_context.SysEmps.OrderBy(t => t.EmpCode).ToList(), "EmpCode", "EmpName");
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View();
        }

        // POST: Admin/User/Register 注册
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("UserName,Password,ConfirmPassword,EmpCode")] RegisterModel register)
        {
            //判断模型是否正确
            if (ModelState.IsValid)
            {
                //用户模型
                var user = new HPSUser { UserName = register.UserName, EmpCode = register.EmpCode };
                //注册用户
                var result = await _userManager.CreateAsync(user, register.Password);
                //登录用户信息
                var createuser = await _userManager.GetUserAsync(User);
                //判断注册用户是否成功
                if (result.Succeeded)
                {
                    _logger.LogInformation($"创建用户 {register.UserName} 成功，操作员 {createuser.UserName} ,操作时间 {DateTime.Now.ToString()} 。");

                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var callbackUrl = Url.Page(
                    //    "/Account/ConfirmEmail",
                    //    pageHandler: null,
                    //    values: new { userId = user.Id, code = code },
                    //    protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    //登录用户，无密码
                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    //return LocalRedirect(returnUrl);

                    //返回用户列表
                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            ViewData["EmpCode"] = new SelectList(_context.SysEmps.OrderBy(t => t.EmpCode).ToList(), "EmpCode", "EmpName");
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View(register);
        }

        // GET: Admin/User/ResetPassword 密码重置
        public async Task<IActionResult> ResetPassword(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            //用户名
            ViewData["EmpCode"] = user.EmpCode;
            ViewData["EmpName"] = _context.SysEmps.Where(t => t.EmpCode == user.EmpCode).First().EmpName;
            //密码重置口令
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            if (user == null)
            {
                return NotFound();
            }
            return View(new ResetPasswordModel { Id = user.Id, UserName = user.UserName, Code = code });
        }

        // GET: Admin/User/ResetPassword 密码重置
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(Guid id, [Bind("Id,UserName,Password,ConfirmPassword,Code")] ResetPasswordModel reset)
        {
            if (id != reset.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _context.Users.FindAsync(id);
                    //用户名
                    ViewData["EmpCode"] = user.EmpCode;
                    ViewData["EmpName"] = _context.SysEmps.Where(t => t.EmpCode == user.EmpCode).First().EmpName;
                    //重置密码
                    var result = await _userManager.ResetPasswordAsync(user, reset.Code, reset.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(Index));
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(reset.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reset);
        }

        // GET: Admin/Role/Details 权限详情
        public async Task<IActionResult> RoleDetails(Guid? id)
        {
            //var user = await _userManager.GetUserAsync(User);
            //var s = await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "MyRole"));

            var user = await _context.Users.FindAsync(id);
            ViewData["Claims"] = await _userManager.GetClaimsAsync(user);
            //用户名
            ViewData["EmpCode"] = user.EmpCode;
            ViewData["EmpName"] = _context.SysEmps.Where(t => t.EmpCode == user.EmpCode).First().EmpName;
            return View();
        }

        // GET: Admin/Role/Edit 权限编辑
        public async Task<IActionResult> RoleEdit(Guid? id)
        {
            //查询菜单
            RoleCreateModel model = new RoleCreateModel() { UserId = id, SysNavbarTypes = await _context.SysNavbarTypes.Include(t => t.SysNavbars).ToListAsync() };
            var user = await _context.Users.FindAsync(id);
            //用户名
            ViewData["EmpCode"] = user.EmpCode;
            ViewData["EmpName"] = _context.SysEmps.Where(t => t.EmpCode == user.EmpCode).First().EmpName;
            var claims = await _userManager.GetClaimsAsync(user);
            foreach (var itemtype in model.SysNavbarTypes)
            {
                foreach (var item in itemtype.SysNavbars)
                {
                    if (claims.Any(t=> t.Value == item.Controller))
                        item.Checked = true;
                }
            }
            return View(model);
        }

        // POST: Admin/Role/Create 权限创建
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleCreateModel data)
        {
            var user = await _context.Users.FindAsync(data.UserId);
            //管理员不更改权限
            if (user.EmpCode == "000000")
                return RedirectToAction(nameof(Index));
            await _userManager.RemoveClaimsAsync(user, await _userManager.GetClaimsAsync(user));
            List<Claim> claims = new List<Claim>();
            if (data.Claims == null || data.Claims.Count == 0)
                return RedirectToAction(nameof(RoleEdit), new { id = data.UserId });
            foreach (var item in data.Claims)
            {
                claims.Add(new Claim(ClaimTypes.Role, item));
            }
            await _userManager.AddClaimsAsync(user, claims);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(RoleEdit), new { id = data.UserId });
        }

        private bool UserExists(Guid id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        /// <summary>
        /// 验证用户名
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyUserName(string username)
        {
            if (_context.Users.Any(t => t.UserName == username))
                return Json($"账号 {username} 已经存在.");
            return Json(true);
        }







        //public IActionResult Register()
        //{
        //    return Redirect("~/Identity/Account/Register");
        //}


        

        //public IActionResult Index()
        //{
            





        //    var user = _context.Users.ToList();
        //    //HPSRole role = new HPSRole();
        //    //role.Name = "test";


        //    //var result1 = await _roleManager.CreateAsync(role);
        //    //var result = await _userManager.AddToRoleAsync(user, "test");

        //    return View(user);
        //}
    }
}