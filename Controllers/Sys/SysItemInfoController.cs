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
    public class SysItemInfoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SysItemInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SysItemInfo
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SysItemInfos.Include(s => s.SysItem);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SysItemInfo/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysItemInfo = await _context.SysItemInfos
                .Include(s => s.SysItem)
                .FirstOrDefaultAsync(m => m.ItemKey == id);
            if (sysItemInfo == null)
            {
                return NotFound();
            }

            return View(sysItemInfo);
        }

        // GET: SysItemInfo/Create
        public IActionResult Create()
        {
            ViewData["ItemCode"] = new SelectList(_context.SysItems, "ItemCode", "ItemName");
            return View();
        }

        // POST: SysItemInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemKey,ItemValue,Spell,ItemCode")] SysItemInfo sysItemInfo)
        {
            if (ModelState.IsValid)
            {
                //sysItemInfo.ItemKey = Guid.NewGuid();
                _context.Add(sysItemInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItemCode"] = new SelectList(_context.SysItems, "ItemCode", "ItemName", sysItemInfo.ItemCode);
            return View(sysItemInfo);
        }

        // GET: SysItemInfo/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysItemInfo = await _context.SysItemInfos.FindAsync(id);
            if (sysItemInfo == null)
            {
                return NotFound();
            }
            ViewData["ItemCode"] = new SelectList(_context.SysItems, "ItemCode", "ItemName", sysItemInfo.ItemCode);
            return View(sysItemInfo);
        }

        // POST: SysItemInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ItemKey,ItemValue,Spell,ItemCode")] SysItemInfo sysItemInfo)
        {
            if (id != sysItemInfo.ItemKey)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysItemInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysItemInfoExists(sysItemInfo.ItemKey))
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
            ViewData["ItemCode"] = new SelectList(_context.SysItems, "ItemCode", "ItemName", sysItemInfo.ItemCode);
            return View(sysItemInfo);
        }

        // GET: SysItemInfo/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysItemInfo = await _context.SysItemInfos
                .Include(s => s.SysItem)
                .FirstOrDefaultAsync(m => m.ItemKey == id);
            if (sysItemInfo == null)
            {
                return NotFound();
            }

            return View(sysItemInfo);
        }

        // POST: SysItemInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sysItemInfo = await _context.SysItemInfos.FindAsync(id);
            _context.SysItemInfos.Remove(sysItemInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SysItemInfoExists(Guid id)
        {
            return _context.SysItemInfos.Any(e => e.ItemKey == id);
        }
    }
}
