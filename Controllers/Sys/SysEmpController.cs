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
    public class SysEmpController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SysEmpController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SysEmp
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SysEmps.Include(s => s.ComAdminDuty).Include(s => s.ComDegree).Include(s => s.ComEducation).Include(s => s.ComGender).Include(s => s.ComMarriage).Include(s => s.ComNation).Include(s => s.ComPolitical).Include(s => s.ComProfessionTitle).Include(s => s.ComProfessionTitleLevel).Include(s => s.ComProfessionTitleType).Include(s => s.SysDept).Include(s => s.SysEmpType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SysEmp/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysEmp = await _context.SysEmps
                .Include(s => s.ComAdminDuty)
                .Include(s => s.ComDegree)
                .Include(s => s.ComEducation)
                .Include(s => s.ComGender)
                .Include(s => s.ComMarriage)
                .Include(s => s.ComNation)
                .Include(s => s.ComPolitical)
                .Include(s => s.ComProfessionTitle)
                .Include(s => s.ComProfessionTitleLevel)
                .Include(s => s.ComProfessionTitleType)
                .Include(s => s.SysDept)
                .Include(s => s.SysEmpType)
                .FirstOrDefaultAsync(m => m.EmpCode == id);
            if (sysEmp == null)
            {
                return NotFound();
            }

            return View(sysEmp);
        }

        // GET: SysEmp/Create
        public IActionResult Create()
        {
            ViewData["AdminDutyCode"] = new SelectList(_context.ComAdminDutys, "Code", "Code");
            ViewData["DegreeCode"] = new SelectList(_context.ComDegrees, "Code", "Code");
            ViewData["EducationCode"] = new SelectList(_context.ComEducations, "Code", "Code");
            ViewData["GenderCode"] = new SelectList(_context.ComGenders, "Code", "Code");
            ViewData["MarriageCode"] = new SelectList(_context.ComMarriages, "Code", "Code");
            ViewData["NationCode"] = new SelectList(_context.ComNations, "Code", "Code");
            ViewData["PoliticalCode"] = new SelectList(_context.ComPoliticals, "Code", "Code");
            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles, "Code", "Code");
            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Code");
            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Code");
            ViewData["DeptCode"] = new SelectList(_context.SysDepts, "DeptCode", "DeptCode");
            ViewData["TypeCode"] = new SelectList(_context.SysEmpTypes, "Code", "Code");
            return View();
        }

        // POST: SysEmp/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpCode,EmpName,Spell,DeptCode,OldName,GenderCode,NationCode,BirthDate,Age,PoliticalCode,PoliticalDate,IdentityCard,ProfessionTitleTypeCode,ProfessionTitleLevelCode,ProfessionTitleCode,AdminDutyCode,IsPost,TypeCode,WorkDate,HospitalDate,WorkAge,HospitalAge,Practice,PracticeDate,OpenBank,BankCard,EducationCode,EducationDate,DegreeCode,School,SchoolMajor,GraduationDate,Telephone,MarriageCode,BirthAdd,HomeAdd,IdentityAdd,NativePlace,Photo,IsStop,Remark,CreateEmp,CreateDate")] SysEmp sysEmp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sysEmp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdminDutyCode"] = new SelectList(_context.ComAdminDutys, "Code", "Code", sysEmp.AdminDutyCode);
            ViewData["DegreeCode"] = new SelectList(_context.ComDegrees, "Code", "Code", sysEmp.DegreeCode);
            ViewData["EducationCode"] = new SelectList(_context.ComEducations, "Code", "Code", sysEmp.EducationCode);
            ViewData["GenderCode"] = new SelectList(_context.ComGenders, "Code", "Code", sysEmp.GenderCode);
            ViewData["MarriageCode"] = new SelectList(_context.ComMarriages, "Code", "Code", sysEmp.MarriageCode);
            ViewData["NationCode"] = new SelectList(_context.ComNations, "Code", "Code", sysEmp.NationCode);
            ViewData["PoliticalCode"] = new SelectList(_context.ComPoliticals, "Code", "Code", sysEmp.PoliticalCode);
            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles, "Code", "Code", sysEmp.ProfessionTitleCode);
            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Code", sysEmp.ProfessionTitleLevelCode);
            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Code", sysEmp.ProfessionTitleTypeCode);
            ViewData["DeptCode"] = new SelectList(_context.SysDepts, "DeptCode", "DeptCode", sysEmp.DeptCode);
            ViewData["TypeCode"] = new SelectList(_context.SysEmpTypes, "Code", "Code", sysEmp.TypeCode);
            return View(sysEmp);
        }

        // GET: SysEmp/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysEmp = await _context.SysEmps.FindAsync(id);
            if (sysEmp == null)
            {
                return NotFound();
            }
            ViewData["AdminDutyCode"] = new SelectList(_context.ComAdminDutys, "Code", "Code", sysEmp.AdminDutyCode);
            ViewData["DegreeCode"] = new SelectList(_context.ComDegrees, "Code", "Code", sysEmp.DegreeCode);
            ViewData["EducationCode"] = new SelectList(_context.ComEducations, "Code", "Code", sysEmp.EducationCode);
            ViewData["GenderCode"] = new SelectList(_context.ComGenders, "Code", "Code", sysEmp.GenderCode);
            ViewData["MarriageCode"] = new SelectList(_context.ComMarriages, "Code", "Code", sysEmp.MarriageCode);
            ViewData["NationCode"] = new SelectList(_context.ComNations, "Code", "Code", sysEmp.NationCode);
            ViewData["PoliticalCode"] = new SelectList(_context.ComPoliticals, "Code", "Code", sysEmp.PoliticalCode);
            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles, "Code", "Code", sysEmp.ProfessionTitleCode);
            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Code", sysEmp.ProfessionTitleLevelCode);
            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Code", sysEmp.ProfessionTitleTypeCode);
            ViewData["DeptCode"] = new SelectList(_context.SysDepts, "DeptCode", "DeptCode", sysEmp.DeptCode);
            ViewData["TypeCode"] = new SelectList(_context.SysEmpTypes, "Code", "Code", sysEmp.TypeCode);
            return View(sysEmp);
        }

        // POST: SysEmp/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("EmpCode,EmpName,Spell,DeptCode,OldName,GenderCode,NationCode,BirthDate,Age,PoliticalCode,PoliticalDate,IdentityCard,ProfessionTitleTypeCode,ProfessionTitleLevelCode,ProfessionTitleCode,AdminDutyCode,IsPost,TypeCode,WorkDate,HospitalDate,WorkAge,HospitalAge,Practice,PracticeDate,OpenBank,BankCard,EducationCode,EducationDate,DegreeCode,School,SchoolMajor,GraduationDate,Telephone,MarriageCode,BirthAdd,HomeAdd,IdentityAdd,NativePlace,Photo,IsStop,Remark,CreateEmp,CreateDate")] SysEmp sysEmp)
        {
            if (id != sysEmp.EmpCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysEmp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysEmpExists(sysEmp.EmpCode))
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
            ViewData["AdminDutyCode"] = new SelectList(_context.ComAdminDutys, "Code", "Code", sysEmp.AdminDutyCode);
            ViewData["DegreeCode"] = new SelectList(_context.ComDegrees, "Code", "Code", sysEmp.DegreeCode);
            ViewData["EducationCode"] = new SelectList(_context.ComEducations, "Code", "Code", sysEmp.EducationCode);
            ViewData["GenderCode"] = new SelectList(_context.ComGenders, "Code", "Code", sysEmp.GenderCode);
            ViewData["MarriageCode"] = new SelectList(_context.ComMarriages, "Code", "Code", sysEmp.MarriageCode);
            ViewData["NationCode"] = new SelectList(_context.ComNations, "Code", "Code", sysEmp.NationCode);
            ViewData["PoliticalCode"] = new SelectList(_context.ComPoliticals, "Code", "Code", sysEmp.PoliticalCode);
            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles, "Code", "Code", sysEmp.ProfessionTitleCode);
            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Code", sysEmp.ProfessionTitleLevelCode);
            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Code", sysEmp.ProfessionTitleTypeCode);
            ViewData["DeptCode"] = new SelectList(_context.SysDepts, "DeptCode", "DeptCode", sysEmp.DeptCode);
            ViewData["TypeCode"] = new SelectList(_context.SysEmpTypes, "Code", "Code", sysEmp.TypeCode);
            return View(sysEmp);
        }

        //// GET: SysEmp/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sysEmp = await _context.SysEmps
        //        .Include(s => s.ComAdminDuty)
        //        .Include(s => s.ComDegree)
        //        .Include(s => s.ComEducation)
        //        .Include(s => s.ComGender)
        //        .Include(s => s.ComMarriage)
        //        .Include(s => s.ComNation)
        //        .Include(s => s.ComPolitical)
        //        .Include(s => s.ComProfessionTitle)
        //        .Include(s => s.ComProfessionTitleLevel)
        //        .Include(s => s.ComProfessionTitleType)
        //        .Include(s => s.SysDept)
        //        .Include(s => s.SysEmpType)
        //        .FirstOrDefaultAsync(m => m.EmpCode == id);
        //    if (sysEmp == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sysEmp);
        //}

        //// POST: SysEmp/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var sysEmp = await _context.SysEmps.FindAsync(id);
        //    _context.SysEmps.Remove(sysEmp);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool SysEmpExists(string id)
        {
            return _context.SysEmps.Any(e => e.EmpCode == id);
        }
    }
}
