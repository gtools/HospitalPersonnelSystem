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
    public class ComDegreeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComDegreeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComDegree
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComDegrees.ToListAsync());
        }

        // GET: ComDegree/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comDegree = await _context.ComDegrees
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comDegree == null)
            {
                return NotFound();
            }

            return View(comDegree);
        }

        // GET: ComDegree/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComDegree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComDegree comDegree)
        {
            if (ModelState.IsValid)
            {
                //comDegree.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.ComDegrees.Count() > 0)
                    comDegree.Sort = _context.ComDegrees.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(comDegree.Spell))
                    comDegree.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(comDegree.Name);
                _context.Add(comDegree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comDegree);
        }

        // GET: ComDegree/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comDegree = await _context.ComDegrees.FindAsync(id);
            if (comDegree == null)
            {
                return NotFound();
            }
            return View(comDegree);
        }

        // POST: ComDegree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComDegree comDegree)
        {
            if (id != comDegree.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comDegree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComDegreeExists(comDegree.Code))
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
            return View(comDegree);
        }

        //// GET: ComDegree/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comDegree = await _context.ComDegrees
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comDegree == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comDegree);
        //}

        //// POST: ComDegree/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comDegree = await _context.ComDegrees.FindAsync(id);
        //    _context.ComDegrees.Remove(comDegree);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComDegreeExists(Guid id)
        {
            return _context.ComDegrees.Any(e => e.Code == id);
        }
    }
}
