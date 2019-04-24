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
    public class ComNationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComNationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComNation
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComNations.ToListAsync());
        }

        // GET: ComNation/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comNation = await _context.ComNations
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comNation == null)
            {
                return NotFound();
            }

            return View(comNation);
        }

        // GET: ComNation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComNation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComNation comNation)
        {
            if (ModelState.IsValid)
            {
                comNation.Code = Guid.NewGuid();
                _context.Add(comNation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comNation);
        }

        // GET: ComNation/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comNation = await _context.ComNations.FindAsync(id);
            if (comNation == null)
            {
                return NotFound();
            }
            return View(comNation);
        }

        // POST: ComNation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComNation comNation)
        {
            if (id != comNation.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comNation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComNationExists(comNation.Code))
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
            return View(comNation);
        }

        //// GET: ComNation/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comNation = await _context.ComNations
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comNation == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comNation);
        //}

        //// POST: ComNation/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comNation = await _context.ComNations.FindAsync(id);
        //    _context.ComNations.Remove(comNation);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComNationExists(Guid id)
        {
            return _context.ComNations.Any(e => e.Code == id);
        }
    }
}
