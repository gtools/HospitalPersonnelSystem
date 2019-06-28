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
    [Authorize(Roles = "000000,Basic,ComProfessionTitleLevel")]
    public class ComProfessionTitleLevelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComProfessionTitleLevelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComProfessionTitleLevel
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComProfessionTitleLevels.ToListAsync());
        }

        // GET: ComProfessionTitleLevel/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionTitleLevel = await _context.ComProfessionTitleLevels
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comProfessionTitleLevel == null)
            {
                return NotFound();
            }

            return View(comProfessionTitleLevel);
        }

        // GET: ComProfessionTitleLevel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComProfessionTitleLevel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComProfessionTitleLevel comProfessionTitleLevel)
        {
            if (ModelState.IsValid)
            {
                //comProfessionTitleLevel.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.ComProfessionTitleLevels.Count() > 0)
                    comProfessionTitleLevel.Sort = _context.ComProfessionTitleLevels.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(comProfessionTitleLevel.Spell))
                    comProfessionTitleLevel.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(comProfessionTitleLevel.Name);
                _context.Add(comProfessionTitleLevel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comProfessionTitleLevel);
        }

        // GET: ComProfessionTitleLevel/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionTitleLevel = await _context.ComProfessionTitleLevels.FindAsync(id);
            if (comProfessionTitleLevel == null)
            {
                return NotFound();
            }
            return View(comProfessionTitleLevel);
        }

        // POST: ComProfessionTitleLevel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComProfessionTitleLevel comProfessionTitleLevel)
        {
            if (id != comProfessionTitleLevel.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comProfessionTitleLevel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComProfessionTitleLevelExists(comProfessionTitleLevel.Code))
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
            return View(comProfessionTitleLevel);
        }

        //// GET: ComProfessionTitleLevel/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comProfessionTitleLevel = await _context.ComProfessionTitleLevels
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comProfessionTitleLevel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comProfessionTitleLevel);
        //}

        //// POST: ComProfessionTitleLevel/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comProfessionTitleLevel = await _context.ComProfessionTitleLevels.FindAsync(id);
        //    _context.ComProfessionTitleLevels.Remove(comProfessionTitleLevel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComProfessionTitleLevelExists(Guid id)
        {
            return _context.ComProfessionTitleLevels.Any(e => e.Code == id);
        }
    }
}
