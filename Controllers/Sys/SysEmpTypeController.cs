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

    [Authorize]
    public class SysEmpTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SysEmpTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SysEmpType
        public async Task<IActionResult> Index()
        {
            return View(await _context.SysEmpTypes.ToListAsync());
        }

        // GET: SysEmpType/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysEmpType = await _context.SysEmpTypes
                .FirstOrDefaultAsync(m => m.Code == id);
            if (sysEmpType == null)
            {
                return NotFound();
            }

            return View(sysEmpType);
        }

        // GET: SysEmpType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SysEmpType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] SysEmpType sysEmpType)
        {
            if (ModelState.IsValid)
            {
                //sysEmpType.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.SysEmpTypes.Count() > 0)
                    sysEmpType.Sort = _context.SysEmpTypes.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(sysEmpType.Spell))
                    sysEmpType.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(sysEmpType.Name);
                _context.Add(sysEmpType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sysEmpType);
        }

        // GET: SysEmpType/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysEmpType = await _context.SysEmpTypes.FindAsync(id);
            if (sysEmpType == null)
            {
                return NotFound();
            }
            return View(sysEmpType);
        }

        // POST: SysEmpType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] SysEmpType sysEmpType)
        {
            if (id != sysEmpType.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysEmpType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysEmpTypeExists(sysEmpType.Code))
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
            return View(sysEmpType);
        }

        //// GET: SysEmpType/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sysEmpType = await _context.SysEmpTypes
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (sysEmpType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sysEmpType);
        //}

        //// POST: SysEmpType/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var sysEmpType = await _context.SysEmpTypes.FindAsync(id);
        //    _context.SysEmpTypes.Remove(sysEmpType);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool SysEmpTypeExists(Guid id)
        {
            return _context.SysEmpTypes.Any(e => e.Code == id);
        }
    }
}
