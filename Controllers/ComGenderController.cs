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
    public class ComGenderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComGenderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComGender
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComGenders.ToListAsync());
        }

        // GET: ComGender/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comGender = await _context.ComGenders
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comGender == null)
            {
                return NotFound();
            }

            return View(comGender);
        }

        // GET: ComGender/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComGender/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComGender comGender)
        {
            if (ModelState.IsValid)
            {
                comGender.Code = Guid.NewGuid();
                _context.Add(comGender);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comGender);
        }

        // GET: ComGender/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comGender = await _context.ComGenders.FindAsync(id);
            if (comGender == null)
            {
                return NotFound();
            }
            return View(comGender);
        }

        // POST: ComGender/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComGender comGender)
        {
            if (id != comGender.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comGender);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComGenderExists(comGender.Code))
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
            return View(comGender);
        }

        // GET: ComGender/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comGender = await _context.ComGenders
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comGender == null)
            {
                return NotFound();
            }

            return View(comGender);
        }

        // POST: ComGender/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var comGender = await _context.ComGenders.FindAsync(id);
            _context.ComGenders.Remove(comGender);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComGenderExists(Guid id)
        {
            return _context.ComGenders.Any(e => e.Code == id);
        }
    }
}
