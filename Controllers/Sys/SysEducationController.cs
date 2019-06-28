using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalPersonnelSystem.Data;
using HospitalPersonnelSystem.Models;
using GTSharp;
using Microsoft.AspNetCore.Authorization;

namespace HospitalPersonnelSystem.Controllers
{
    //学历评定
    [Authorize(Roles = "000000,SysEducation")]
    public class SysEducationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SysEducationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SysEducation
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SysEducations.Include(s => s.SysEmp);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SysEducation/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysEducation = await _context.SysEducations
                .Include(s => s.SysEmp)
                .FirstOrDefaultAsync(m => m.EmpCode == id);
            if (sysEducation == null)
            {
                return NotFound();
            }

            return View(sysEducation);
        }

        // GET: SysEducation/Create
        public IActionResult Create()
        {
            ViewData["EmpCode"] = new SelectList(_context.SysEmps, "EmpCode", "EmpName");
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View();
        }

        // POST: SysEducation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpCode,MaxEducation,MaxSys,MaxForm,MaxSubject,MaxDate,MaxSchool,FirstEducation,FirstSys,FirstForm,FirstSubject,FirstDate,FirstSchool,SecondEducation,SecondSys,SecondForm,SecondSubject,SecondDate,SecondSchool,Remark")] SysEducation sysEducation)
        {
            if (ModelState.IsValid)
            {
                if (SysEducationExists(sysEducation.EmpCode))
                {
                    return Json($"工号 {sysEducation.EmpCode} 已存在。");
                }
                _context.Add(sysEducation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpCode"] = new SelectList(_context.SysEmps, "EmpCode", "EmpName", sysEducation.EmpCode);
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View(sysEducation);
        }

        // GET: SysEducation/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysEducation = await _context.SysEducations.FindAsync(id);
            if (sysEducation == null)
            {
                return NotFound();
            }
            ViewData["EmpCode"] = new SelectList(_context.SysEmps, "EmpCode", "EmpName", sysEducation.EmpCode);
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View(sysEducation);
        }

        // POST: SysEducation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("EmpCode,MaxEducation,MaxSys,MaxForm,MaxSubject,MaxDate,MaxSchool,FirstEducation,FirstSys,FirstForm,FirstSubject,FirstDate,FirstSchool,SecondEducation,SecondSys,SecondForm,SecondSubject,SecondDate,SecondSchool,Remark")] SysEducation sysEducation)
        {
            if (id != sysEducation.EmpCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysEducation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysEducationExists(sysEducation.EmpCode))
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
            ViewData["EmpCode"] = new SelectList(_context.SysEmps, "EmpCode", "EmpName", sysEducation.EmpCode);
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View(sysEducation);
        }

        // GET: SysEducation/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysEducation = await _context.SysEducations
                .Include(s => s.SysEmp)
                .FirstOrDefaultAsync(m => m.EmpCode == id);
            if (sysEducation == null)
            {
                return NotFound();
            }

            return View(sysEducation);
        }

        // POST: SysEducation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sysEducation = await _context.SysEducations.FindAsync(id);
            _context.SysEducations.Remove(sysEducation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SysEducationExists(string id)
        {
            return _context.SysEducations.Any(e => e.EmpCode == id);
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyEmpCode(string empcode)
        {
            if (SysEducationExists(empcode))
            {
                return Json($"工号 {empcode} 已存在。");
            }
            return Json(true);
        }
    }
}
