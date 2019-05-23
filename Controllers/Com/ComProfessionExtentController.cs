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
    public class ComProfessionExtentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComProfessionExtentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComProfessionExtent
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComProfessionExtents.ToListAsync());
        }

        // GET: ComProfessionExtent/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionExtent = await _context.ComProfessionExtents
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comProfessionExtent == null)
            {
                return NotFound();
            }

            return View(comProfessionExtent);
        }

        // GET: ComProfessionExtent/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComProfessionExtent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComProfessionExtent comProfessionExtent)
        {
            if (ModelState.IsValid)
            {
                //comProfessionExtent.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.ComProfessionExtents.Count() > 0)
                    comProfessionExtent.Sort = _context.ComProfessionExtents.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(comProfessionExtent.Spell))
                    comProfessionExtent.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(comProfessionExtent.Name);
                _context.Add(comProfessionExtent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comProfessionExtent);
        }

        // GET: ComProfessionExtent/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionExtent = await _context.ComProfessionExtents.FindAsync(id);
            if (comProfessionExtent == null)
            {
                return NotFound();
            }
            return View(comProfessionExtent);
        }

        // POST: ComProfessionExtent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComProfessionExtent comProfessionExtent)
        {
            if (id != comProfessionExtent.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comProfessionExtent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComProfessionExtentExists(comProfessionExtent.Code))
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
            return View(comProfessionExtent);
        }

        //// GET: ComProfessionExtent/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comProfessionExtent = await _context.ComProfessionExtents
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comProfessionExtent == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comProfessionExtent);
        //}

        //// POST: ComProfessionExtent/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comProfessionExtent = await _context.ComProfessionExtents.FindAsync(id);
        //    _context.ComProfessionExtents.Remove(comProfessionExtent);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComProfessionExtentExists(Guid id)
        {
            return _context.ComProfessionExtents.Any(e => e.Code == id);
        }
    }
}
