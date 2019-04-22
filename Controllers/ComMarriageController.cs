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
    public class ComMarriageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComMarriageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComMarriage
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComMarriages.ToListAsync());
        }

        // GET: ComMarriage/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comMarriage = await _context.ComMarriages
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comMarriage == null)
            {
                return NotFound();
            }

            return View(comMarriage);
        }

        // GET: ComMarriage/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComMarriage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComMarriage comMarriage)
        {
            if (ModelState.IsValid)
            {
                comMarriage.Code = Guid.NewGuid();
                _context.Add(comMarriage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comMarriage);
        }

        // GET: ComMarriage/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comMarriage = await _context.ComMarriages.FindAsync(id);
            if (comMarriage == null)
            {
                return NotFound();
            }
            return View(comMarriage);
        }

        // POST: ComMarriage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComMarriage comMarriage)
        {
            if (id != comMarriage.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comMarriage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComMarriageExists(comMarriage.Code))
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
            return View(comMarriage);
        }

        // GET: ComMarriage/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comMarriage = await _context.ComMarriages
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comMarriage == null)
            {
                return NotFound();
            }

            return View(comMarriage);
        }

        // POST: ComMarriage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var comMarriage = await _context.ComMarriages.FindAsync(id);
            _context.ComMarriages.Remove(comMarriage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComMarriageExists(Guid id)
        {
            return _context.ComMarriages.Any(e => e.Code == id);
        }
    }
}
