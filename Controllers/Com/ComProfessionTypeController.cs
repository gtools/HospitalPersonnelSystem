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
    public class ComProfessionTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComProfessionTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComProfessionType
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComProfessionTypes.ToListAsync());
        }

        // GET: ComProfessionType/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionType = await _context.ComProfessionTypes
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comProfessionType == null)
            {
                return NotFound();
            }

            return View(comProfessionType);
        }

        // GET: ComProfessionType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComProfessionType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComProfessionType comProfessionType)
        {
            if (ModelState.IsValid)
            {
                //comProfessionType.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.ComProfessionTypes.Count() > 0)
                    comProfessionType.Sort = _context.ComProfessionTypes.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(comProfessionType.Spell))
                    comProfessionType.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(comProfessionType.Name);
                _context.Add(comProfessionType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comProfessionType);
        }

        // GET: ComProfessionType/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionType = await _context.ComProfessionTypes.FindAsync(id);
            if (comProfessionType == null)
            {
                return NotFound();
            }
            return View(comProfessionType);
        }

        // POST: ComProfessionType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComProfessionType comProfessionType)
        {
            if (id != comProfessionType.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comProfessionType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComProfessionTypeExists(comProfessionType.Code))
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
            return View(comProfessionType);
        }

        //// GET: ComProfessionType/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comProfessionType = await _context.ComProfessionTypes
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comProfessionType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comProfessionType);
        //}

        //// POST: ComProfessionType/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comProfessionType = await _context.ComProfessionTypes.FindAsync(id);
        //    _context.ComProfessionTypes.Remove(comProfessionType);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComProfessionTypeExists(Guid id)
        {
            return _context.ComProfessionTypes.Any(e => e.Code == id);
        }
    }
}
