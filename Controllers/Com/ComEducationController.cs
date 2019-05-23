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
    public class ComEducationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComEducationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComEducation
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComEducations.ToListAsync());
        }

        // GET: ComEducation/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comEducation = await _context.ComEducations
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comEducation == null)
            {
                return NotFound();
            }

            return View(comEducation);
        }

        // GET: ComEducation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComEducation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComEducation comEducation)
        {
            if (ModelState.IsValid)
            {
                //comEducation.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.ComEducations.Count() > 0)
                    comEducation.Sort = _context.ComEducations.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(comEducation.Spell))
                    comEducation.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(comEducation.Name);
                _context.Add(comEducation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comEducation);
        }

        // GET: ComEducation/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comEducation = await _context.ComEducations.FindAsync(id);
            if (comEducation == null)
            {
                return NotFound();
            }
            return View(comEducation);
        }

        // POST: ComEducation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComEducation comEducation)
        {
            if (id != comEducation.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comEducation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComEducationExists(comEducation.Code))
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
            return View(comEducation);
        }

        //// GET: ComEducation/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comEducation = await _context.ComEducations
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comEducation == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comEducation);
        //}

        //// POST: ComEducation/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comEducation = await _context.ComEducations.FindAsync(id);
        //    _context.ComEducations.Remove(comEducation);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComEducationExists(Guid id)
        {
            return _context.ComEducations.Any(e => e.Code == id);
        }
    }
}
