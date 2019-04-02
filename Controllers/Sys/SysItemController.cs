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
    public class SysItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SysItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SysItem
        public async Task<IActionResult> Index()
        {
            return View(await _context.SysItems.ToListAsync());
        }

        // GET: SysItem/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysItem = await _context.SysItems
                .FirstOrDefaultAsync(m => m.ItemCode == id);
            if (sysItem == null)
            {
                return NotFound();
            }

            return View(sysItem);
        }

        // GET: SysItem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SysItem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemCode,ItemName,Spell")] SysItem sysItem)
        {
            if (ModelState.IsValid)
            {
                //sysItem.ItemCode = Guid.NewGuid();
                _context.Add(sysItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sysItem);
        }

        // GET: SysItem/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysItem = await _context.SysItems.FindAsync(id);
            if (sysItem == null)
            {
                return NotFound();
            }
            return View(sysItem);
        }

        // POST: SysItem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ItemCode,ItemName,Spell")] SysItem sysItem)
        {
            if (id != sysItem.ItemCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysItemExists(sysItem.ItemCode))
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
            return View(sysItem);
        }

        // GET: SysItem/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysItem = await _context.SysItems
                .FirstOrDefaultAsync(m => m.ItemCode == id);
            if (sysItem == null)
            {
                return NotFound();
            }

            return View(sysItem);
        }

        // POST: SysItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sysItem = await _context.SysItems.FindAsync(id);
            _context.SysItems.Remove(sysItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SysItemExists(Guid id)
        {
            return _context.SysItems.Any(e => e.ItemCode == id);
        }
        
    }
}
