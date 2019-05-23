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
using GTSharp;

namespace HospitalPersonnelSystem.Controllers
{
    [Authorize]
    public class SysContractController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SysContractController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SysContract
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SysContracts.Include(s => s.SysEmp);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SysContract/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysContract = await _context.SysContracts
                .Include(s => s.SysEmp)
                .FirstOrDefaultAsync(m => m.EmpCode == id);
            if (sysContract == null)
            {
                return NotFound();
            }

            return View(sysContract);
        }

        // GET: SysContract/Create
        public IActionResult Create()
        {
            ViewData["EmpCode"] = new SelectList(_context.SysEmps, "EmpCode", "EmpName");
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View();
        }

        // POST: SysContract/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,EmpCode,YearLimit,EndDate,SN,Remark,CreateEmp,CreateDate")] SysContract sysContract)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sysContract);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpCode"] = new SelectList(_context.SysEmps, "EmpCode", "EmpName", sysContract.EmpCode);
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View(sysContract);
        }

        // GET: SysContract/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysContract = await _context.SysContracts.FindAsync(id);
            if (sysContract == null)
            {
                return NotFound();
            }
            ViewData["EmpCode"] = new SelectList(_context.SysEmps, "EmpCode", "EmpName", sysContract.EmpCode);
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View(sysContract);
        }

        // POST: SysContract/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Code,EmpCode,YearLimit,EndDate,SN,Remark,CreateEmp,CreateDate")] SysContract sysContract)
        {
            if (id != sysContract.EmpCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysContract);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysContractExists(sysContract.EmpCode))
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
            ViewData["EmpCode"] = new SelectList(_context.SysEmps, "EmpCode", "EmpName", sysContract.EmpCode);
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View(sysContract);
        }

        //// GET: SysContract/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sysContract = await _context.SysContracts
        //        .Include(s => s.SysEmp)
        //        .FirstOrDefaultAsync(m => m.EmpCode == id);
        //    if (sysContract == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sysContract);
        //}

        //// POST: SysContract/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var sysContract = await _context.SysContracts.FindAsync(id);
        //    _context.SysContracts.Remove(sysContract);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool SysContractExists(string id)
        {
            return _context.SysContracts.Any(e => e.EmpCode == id);
        }
    }
}
