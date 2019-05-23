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
    public class ComPoliticalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComPoliticalController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComPolitical
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComPoliticals.ToListAsync());
        }

        // GET: ComPolitical/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comPolitical = await _context.ComPoliticals
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comPolitical == null)
            {
                return NotFound();
            }

            return View(comPolitical);
        }

        // GET: ComPolitical/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComPolitical/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComPolitical comPolitical)
        {
            if (ModelState.IsValid)
            {
                //comPolitical.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.ComPoliticals.Count() > 0)
                    comPolitical.Sort = _context.ComPoliticals.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(comPolitical.Spell))
                    comPolitical.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(comPolitical.Name);
                _context.Add(comPolitical);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comPolitical);
        }

        // GET: ComPolitical/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comPolitical = await _context.ComPoliticals.FindAsync(id);
            if (comPolitical == null)
            {
                return NotFound();
            }
            return View(comPolitical);
        }

        // POST: ComPolitical/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComPolitical comPolitical)
        {
            if (id != comPolitical.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comPolitical);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComPoliticalExists(comPolitical.Code))
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
            return View(comPolitical);
        }

        //// GET: ComPolitical/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comPolitical = await _context.ComPoliticals
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comPolitical == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comPolitical);
        //}

        //// POST: ComPolitical/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comPolitical = await _context.ComPoliticals.FindAsync(id);
        //    _context.ComPoliticals.Remove(comPolitical);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComPoliticalExists(Guid id)
        {
            return _context.ComPoliticals.Any(e => e.Code == id);
        }
    }
}
