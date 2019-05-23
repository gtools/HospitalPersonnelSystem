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
    public class ComProfessionTitleTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComProfessionTitleTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComProfessionTitleType
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComProfessionTitleTypes.ToListAsync());
        }

        // GET: ComProfessionTitleType/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionTitleType = await _context.ComProfessionTitleTypes
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comProfessionTitleType == null)
            {
                return NotFound();
            }

            return View(comProfessionTitleType);
        }

        // GET: ComProfessionTitleType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComProfessionTitleType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComProfessionTitleType comProfessionTitleType)
        {
            if (ModelState.IsValid)
            {
                //comProfessionTitleType.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.ComProfessionTitleTypes.Count() > 0)
                    comProfessionTitleType.Sort = _context.ComProfessionTitleTypes.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(comProfessionTitleType.Spell))
                    comProfessionTitleType.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(comProfessionTitleType.Name);
                _context.Add(comProfessionTitleType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comProfessionTitleType);
        }

        // GET: ComProfessionTitleType/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionTitleType = await _context.ComProfessionTitleTypes.FindAsync(id);
            if (comProfessionTitleType == null)
            {
                return NotFound();
            }
            return View(comProfessionTitleType);
        }

        // POST: ComProfessionTitleType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComProfessionTitleType comProfessionTitleType)
        {
            if (id != comProfessionTitleType.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comProfessionTitleType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComProfessionTitleTypeExists(comProfessionTitleType.Code))
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
            return View(comProfessionTitleType);
        }

        //// GET: ComProfessionTitleType/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comProfessionTitleType = await _context.ComProfessionTitleTypes
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comProfessionTitleType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comProfessionTitleType);
        //}

        //// POST: ComProfessionTitleType/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comProfessionTitleType = await _context.ComProfessionTitleTypes.FindAsync(id);
        //    _context.ComProfessionTitleTypes.Remove(comProfessionTitleType);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComProfessionTitleTypeExists(Guid id)
        {
            return _context.ComProfessionTitleTypes.Any(e => e.Code == id);
        }
    }
}
