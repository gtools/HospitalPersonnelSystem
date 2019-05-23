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
    public class ComProfessionRegisterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComProfessionRegisterController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComProfessionRegister
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComProfessionRegisters.ToListAsync());
        }

        // GET: ComProfessionRegister/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionRegister = await _context.ComProfessionRegisters
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comProfessionRegister == null)
            {
                return NotFound();
            }

            return View(comProfessionRegister);
        }

        // GET: ComProfessionRegister/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComProfessionRegister/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComProfessionRegister comProfessionRegister)
        {
            if (ModelState.IsValid)
            {
                //comProfessionRegister.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.ComProfessionRegisters.Count() > 0)
                    comProfessionRegister.Sort = _context.ComProfessionRegisters.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(comProfessionRegister.Spell))
                    comProfessionRegister.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(comProfessionRegister.Name);
                _context.Add(comProfessionRegister);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comProfessionRegister);
        }

        // GET: ComProfessionRegister/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comProfessionRegister = await _context.ComProfessionRegisters.FindAsync(id);
            if (comProfessionRegister == null)
            {
                return NotFound();
            }
            return View(comProfessionRegister);
        }

        // POST: ComProfessionRegister/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComProfessionRegister comProfessionRegister)
        {
            if (id != comProfessionRegister.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comProfessionRegister);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComProfessionRegisterExists(comProfessionRegister.Code))
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
            return View(comProfessionRegister);
        }

        //// GET: ComProfessionRegister/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comProfessionRegister = await _context.ComProfessionRegisters
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comProfessionRegister == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comProfessionRegister);
        //}

        //// POST: ComProfessionRegister/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comProfessionRegister = await _context.ComProfessionRegisters.FindAsync(id);
        //    _context.ComProfessionRegisters.Remove(comProfessionRegister);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComProfessionRegisterExists(Guid id)
        {
            return _context.ComProfessionRegisters.Any(e => e.Code == id);
        }
    }
}
