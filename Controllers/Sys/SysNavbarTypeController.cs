using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalPersonnelSystem.Data;
using HospitalPersonnelSystem.Models;
using Microsoft.AspNetCore.Authorization;

namespace HospitalPersonnelSystem.Controllers
{
    [Authorize(Roles = "SysNavbarType")]
    public class SysNavbarTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SysNavbarTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SysNavbarType
        public async Task<IActionResult> Index()
        {
            return View(await _context.SysNavbarTypes.ToListAsync());
        }

        // GET: SysNavbarType/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysNavbarType = await _context.SysNavbarTypes
                .FirstOrDefaultAsync(m => m.Code == id);
            if (sysNavbarType == null)
            {
                return NotFound();
            }

            return View(sysNavbarType);
        }

        // GET: SysNavbarType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SysNavbarType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] SysNavbarType sysNavbarType)
        {
            if (ModelState.IsValid)
            {
                //sysNavbarType.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.SysNavbarTypes.Count() > 0)
                    sysNavbarType.Sort = _context.SysNavbarTypes.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(sysNavbarType.Spell))
                    sysNavbarType.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(sysNavbarType.Name);
                _context.Add(sysNavbarType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sysNavbarType);
        }

        // GET: SysNavbarType/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysNavbarType = await _context.SysNavbarTypes.FindAsync(id);
            if (sysNavbarType == null)
            {
                return NotFound();
            }
            return View(sysNavbarType);
        }

        // POST: SysNavbarType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] SysNavbarType sysNavbarType)
        {
            if (id != sysNavbarType.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysNavbarType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysNavbarTypeExists(sysNavbarType.Code))
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
            return View(sysNavbarType);
        }

        //// GET: SysNavbarType/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sysNavbarType = await _context.SysNavbarTypes
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (sysNavbarType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sysNavbarType);
        //}

        //// POST: SysNavbarType/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var sysNavbarType = await _context.SysNavbarTypes.FindAsync(id);
        //    _context.SysNavbarTypes.Remove(sysNavbarType);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool SysNavbarTypeExists(Guid id)
        {
            return _context.SysNavbarTypes.Any(e => e.Code == id);
        }
    }
}
