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
    public class ComProfessionTitleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComProfessionTitleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComProfessionTitle
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ComProfessionTitles.Include(c => c.ComProfessionTitleLevel).Include(c => c.ComProfessionTitleType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ComProfessionTitle/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionTitle = await _context.ComProfessionTitles
                .Include(c => c.ComProfessionTitleLevel)
                .Include(c => c.ComProfessionTitleType)
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comProfessionTitle == null)
            {
                return NotFound();
            }

            return View(comProfessionTitle);
        }

        // GET: ComProfessionTitle/Create
        public IActionResult Create()
        {
            ViewData["LevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Code");
            ViewData["TypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Code");
            return View();
        }

        // POST: ComProfessionTitle/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort,TypeCode,LevelCode")] ComProfessionTitle comProfessionTitle)
        {
            if (ModelState.IsValid)
            {
                comProfessionTitle.Code = Guid.NewGuid();
                _context.Add(comProfessionTitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Code", comProfessionTitle.LevelCode);
            ViewData["TypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Code", comProfessionTitle.TypeCode);
            return View(comProfessionTitle);
        }

        // GET: ComProfessionTitle/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionTitle = await _context.ComProfessionTitles.FindAsync(id);
            if (comProfessionTitle == null)
            {
                return NotFound();
            }
            ViewData["LevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Code", comProfessionTitle.LevelCode);
            ViewData["TypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Code", comProfessionTitle.TypeCode);
            return View(comProfessionTitle);
        }

        // POST: ComProfessionTitle/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort,TypeCode,LevelCode")] ComProfessionTitle comProfessionTitle)
        {
            if (id != comProfessionTitle.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comProfessionTitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComProfessionTitleExists(comProfessionTitle.Code))
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
            ViewData["LevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Code", comProfessionTitle.LevelCode);
            ViewData["TypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Code", comProfessionTitle.TypeCode);
            return View(comProfessionTitle);
        }

        //// GET: ComProfessionTitle/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comProfessionTitle = await _context.ComProfessionTitles
        //        .Include(c => c.ComProfessionTitleLevel)
        //        .Include(c => c.ComProfessionTitleType)
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comProfessionTitle == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comProfessionTitle);
        //}

        //// POST: ComProfessionTitle/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comProfessionTitle = await _context.ComProfessionTitles.FindAsync(id);
        //    _context.ComProfessionTitles.Remove(comProfessionTitle);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComProfessionTitleExists(Guid id)
        {
            return _context.ComProfessionTitles.Any(e => e.Code == id);
        }
    }
}
