using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalPersonnelSystem.Data;
using HospitalPersonnelSystem.Models;

namespace HospitalPersonnelSystem.Controllers
{
    public class SysNavbarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SysNavbarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SysNavbar
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SysNavbars.Include(s => s.SysNavbarType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SysNavbar/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysNavbar = await _context.SysNavbars
                .Include(s => s.SysNavbarType)
                .FirstOrDefaultAsync(m => m.Code == id);
            if (sysNavbar == null)
            {
                return NotFound();
            }

            return View(sysNavbar);
        }

        // GET: SysNavbar/Create
        public IActionResult Create()
        {
            ViewData["TypeCode"] = new SelectList(_context.SysNavbarTypes, "Code", "Code");
            return View();
        }

        // POST: SysNavbar/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort,TypeCode,Controller,Action")] SysNavbar sysNavbar)
        {
            if (ModelState.IsValid)
            {
                sysNavbar.Code = Guid.NewGuid();
                _context.Add(sysNavbar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TypeCode"] = new SelectList(_context.SysNavbarTypes, "Code", "Code", sysNavbar.TypeCode);
            return View(sysNavbar);
        }

        // GET: SysNavbar/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysNavbar = await _context.SysNavbars.FindAsync(id);
            if (sysNavbar == null)
            {
                return NotFound();
            }
            ViewData["TypeCode"] = new SelectList(_context.SysNavbarTypes, "Code", "Code", sysNavbar.TypeCode);
            return View(sysNavbar);
        }

        // POST: SysNavbar/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort,TypeCode,Controller,Action")] SysNavbar sysNavbar)
        {
            if (id != sysNavbar.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysNavbar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysNavbarExists(sysNavbar.Code))
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
            ViewData["TypeCode"] = new SelectList(_context.SysNavbarTypes, "Code", "Code", sysNavbar.TypeCode);
            return View(sysNavbar);
        }

        //// GET: SysNavbar/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sysNavbar = await _context.SysNavbars
        //        .Include(s => s.SysNavbarType)
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (sysNavbar == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sysNavbar);
        //}

        //// POST: SysNavbar/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var sysNavbar = await _context.SysNavbars.FindAsync(id);
        //    _context.SysNavbars.Remove(sysNavbar);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool SysNavbarExists(Guid id)
        {
            return _context.SysNavbars.Any(e => e.Code == id);
        }
    }
}
