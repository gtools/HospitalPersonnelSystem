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
    public class SysDeptController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SysDeptController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SysDept
        public async Task<IActionResult> Index()
        {
            return View(await _context.SysDepts.ToListAsync());
        }

        // GET: SysDept/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysDept = await _context.SysDepts
                .FirstOrDefaultAsync(m => m.DeptCode == id);
            if (sysDept == null)
            {
                return NotFound();
            }

            return View(sysDept);
        }

        // GET: SysDept/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SysDept/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeptCode,DeptName,Spell,Sort")] SysDept sysDept)
        {
            if (ModelState.IsValid)
            {
                //排序MAX加1
                if (_context.SysDepts.Count() > 0)
                    sysDept.Sort = _context.SysDepts.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(sysDept.Spell))
                    sysDept.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(sysDept.DeptName);
                _context.Add(sysDept);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sysDept);
        }

        // GET: SysDept/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysDept = await _context.SysDepts.FindAsync(id);
            if (sysDept == null)
            {
                return NotFound();
            }
            return View(sysDept);
        }

        // POST: SysDept/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DeptCode,DeptName,Spell,Sort")] SysDept sysDept)
        {
            if (id != sysDept.DeptCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysDept);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysDeptExists(sysDept.DeptCode))
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
            return View(sysDept);
        }

        //// GET: SysDept/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sysDept = await _context.SysDepts
        //        .FirstOrDefaultAsync(m => m.DeptCode == id);
        //    if (sysDept == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sysDept);
        //}

        //// POST: SysDept/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var sysDept = await _context.SysDepts.FindAsync(id);
        //    _context.SysDepts.Remove(sysDept);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool SysDeptExists(string id)
        {
            return _context.SysDepts.Any(e => e.DeptCode == id);
        }
    }
}
