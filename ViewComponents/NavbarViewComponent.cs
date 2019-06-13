using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalPersonnelSystem.Models;
using HospitalPersonnelSystem.Data;

namespace HospitalPersonnelSystem.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public NavbarViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _context.SysNavbarTypes.Include(t => t.SysNavbars).OrderBy(t => t.Sort).ToListAsync();
            if (ViewData["Controller"] != null && !string.IsNullOrWhiteSpace(ViewData["Controller"].ToString()))
            {
                var item = await _context.SysNavbars.Where(t => t.Controller == ViewData["Controller"].ToString()).FirstAsync();
                ViewData["SysNavbarType"] = item.SysNavbarType.Name;
            }
            return View(items);
        }
    }
}