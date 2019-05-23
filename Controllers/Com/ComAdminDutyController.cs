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
    /// <summary>
    /// 行政职务
    /// </summary>
    public class ComAdminDutyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComAdminDutyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComAdminDuty
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComAdminDutys.ToListAsync());
        }

        // GET: ComAdminDuty/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comAdminDuty = await _context.ComAdminDutys
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comAdminDuty == null)
            {
                return NotFound();
            }

            return View(comAdminDuty);
        }

        // GET: ComAdminDuty/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComAdminDuty/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComAdminDuty comAdminDuty)
        {
            if (ModelState.IsValid)
            {
                //comAdminDuty.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.ComAdminDutys.Count() > 0)
                    comAdminDuty.Sort = _context.ComAdminDutys.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(comAdminDuty.Spell))
                    comAdminDuty.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(comAdminDuty.Name);
                _context.Add(comAdminDuty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comAdminDuty);
        }

        // GET: ComAdminDuty/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comAdminDuty = await _context.ComAdminDutys.FindAsync(id);
            if (comAdminDuty == null)
            {
                return NotFound();
            }
            return View(comAdminDuty);
        }

        // POST: ComAdminDuty/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComAdminDuty comAdminDuty)
        {
            if (id != comAdminDuty.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comAdminDuty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComAdminDutyExists(comAdminDuty.Code))
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
            return View(comAdminDuty);
        }

        //// GET: ComAdminDuty/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comAdminDuty = await _context.ComAdminDutys
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comAdminDuty == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comAdminDuty);
        //}

        //// POST: ComAdminDuty/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comAdminDuty = await _context.ComAdminDutys.FindAsync(id);
        //    _context.ComAdminDutys.Remove(comAdminDuty);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComAdminDutyExists(Guid id)
        {
            return _context.ComAdminDutys.Any(e => e.Code == id);
        }
    }
}
