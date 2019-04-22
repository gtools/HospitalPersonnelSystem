//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using HospitalPersonnelSystem.Data;
//using HospitalPersonnelSystem.Models;

//namespace HospitalPersonnelSystem.Controllers
//{
//    public class SysEmpController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public SysEmpController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: SysEmp
//        public async Task<IActionResult> Index()
//        {
//            var applicationDbContext = _context.SysEmps.Include(s => s.ComAdminDuty).Include(s => s.ComDegree).Include(s => s.ComEducation).Include(s => s.ComGender).Include(s => s.ComMarriage).Include(s => s.ComNation).Include(s => s.ComPolitical).Include(s => s.ComPost).Include(s => s.ComPostLevel).Include(s => s.ComPostType).Include(s => s.ComProfessionTitle).Include(s => s.ComProfessionTitleLevel).Include(s => s.ComProfessionTitleType).Include(s => s.SysDept).Include(s => s.SysEmpAttribute).Include(s => s.SysEmpClass).Include(s => s.SysEmpType);
//            return View(await applicationDbContext.ToListAsync());
//        }

//        // GET: SysEmp/Details/5
//        public async Task<IActionResult> Details(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var sysEmp = await _context.SysEmps
//                .Include(s => s.ComAdminDuty)
//                .Include(s => s.ComDegree)
//                .Include(s => s.ComEducation)
//                .Include(s => s.ComGender)
//                .Include(s => s.ComMarriage)
//                .Include(s => s.ComNation)
//                .Include(s => s.ComPolitical)
//                .Include(s => s.ComPost)
//                .Include(s => s.ComPostLevel)
//                .Include(s => s.ComPostType)
//                .Include(s => s.ComProfessionTitle)
//                .Include(s => s.ComProfessionTitleLevel)
//                .Include(s => s.ComProfessionTitleType)
//                .Include(s => s.SysDept)
//                .Include(s => s.SysEmpAttribute)
//                .Include(s => s.SysEmpClass)
//                .Include(s => s.SysEmpType)
//                .FirstOrDefaultAsync(m => m.EmpCode == id);
//            if (sysEmp == null)
//            {
//                return NotFound();
//            }

//            return View(sysEmp);
//        }

//        // GET: SysEmp/Create
//        public IActionResult Create()
//        {
//            ViewData["AdminDutyCode"] = new SelectList(_context.ComAdminDutys, "Code", "Name","未选择", "Sort");
//            ViewData["DegreeCode"] = new SelectList(_context.ComDegrees, "Code", "Name", "------未选择------", "Sort");
//            ViewData["EducationCode"] = new SelectList(_context.ComEducations.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["GenderCode"] = new SelectList(_context.ComGenders.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["MarriageCode"] = new SelectList(_context.ComMarriages.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["NationCode"] = new SelectList(_context.ComNations.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["PoliticalCode"] = new SelectList(_context.ComPoliticals.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["PostCode"] = new SelectList(_context.ComPosts.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["PostLevelCode"] = new SelectList(_context.ComPostLevels.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["PostTypeCode"] = new SelectList(_context.ComPostTypes.OrderBy(t => t.Sort), "Code", "Name");
//            //ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["DeptCode"] = new SelectList(_context.SysDepts.OrderBy(t => t.Sort), "DeptCode", "DeptCode");
//            ViewData["AttributeCode"] = new SelectList(_context.SysEmpAttributes.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["ClassCode"] = new SelectList(_context.SysEmpClasss.OrderBy(t => t.Sort), "Code", "Name");
//            ViewData["TypeCode"] = new SelectList(_context.SysEmpTypes.OrderBy(t => t.Sort), "Code", "Name");
//            return View();
//        }

//        // POST: SysEmp/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("EmpCode,EmpName,Spell,DeptCode,OldName,GenderCode,NationCode,BirthDate,Age,PoliticalCode,PoliticalDate,IdentityCard,ProfessionTitleTypeCode,ProfessionTitleCode,ProfessionTitleLevelCode,AdminDutyCode,IsPost,TypeCode,ClassCode,AttributeCode,WorkDate,HospitalDate,PostCode,PostTypeCode,PostLevelCode,WorkAge,HospitalAge,Practice,PracticeDate,OpenBank,BankCard,EducationCode,EducationDate,DegreeCode,School,SchoolMajor,GraduationDate,Telephone,MarriageCode,BirthAdd,HomeAdd,IdentityAdd,NativePlace,Photo,IsStop,Remark,CreateEmp,CreateDate")] SysEmp sysEmp)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(sysEmp);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["AdminDutyCode"] = new SelectList(_context.ComAdminDutys, "Code", "Name", sysEmp.AdminDutyCode);
//            ViewData["DegreeCode"] = new SelectList(_context.ComDegrees, "Code", "Name", sysEmp.DegreeCode);
//            ViewData["EducationCode"] = new SelectList(_context.ComEducations, "Code", "Name", sysEmp.EducationCode);
//            ViewData["GenderCode"] = new SelectList(_context.ComGenders, "Code", "Name", sysEmp.GenderCode);
//            ViewData["MarriageCode"] = new SelectList(_context.ComMarriages, "Code", "Name", sysEmp.MarriageCode);
//            ViewData["NationCode"] = new SelectList(_context.ComNations, "Code", "Name", sysEmp.NationCode);
//            ViewData["PoliticalCode"] = new SelectList(_context.ComPoliticals, "Code", "Name", sysEmp.PoliticalCode);
//            ViewData["PostCode"] = new SelectList(_context.ComPosts, "Code", "Name", sysEmp.PostCode);
//            ViewData["PostLevelCode"] = new SelectList(_context.ComPostLevels, "Code", "Name", sysEmp.PostLevelCode);
//            ViewData["PostTypeCode"] = new SelectList(_context.ComPostTypes, "Code", "Name", sysEmp.PostTypeCode);
//            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles, "Code", "Name", sysEmp.ProfessionTitleCode);
//            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Name", sysEmp.ProfessionTitleLevelCode);
//            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Name", sysEmp.ProfessionTitleTypeCode);
//            ViewData["DeptCode"] = new SelectList(_context.SysDepts, "DeptCode", "DeptCode", sysEmp.DeptCode);
//            ViewData["AttributeCode"] = new SelectList(_context.SysEmpAttributes, "Code", "Name", sysEmp.AttributeCode);
//            ViewData["ClassCode"] = new SelectList(_context.SysEmpClasss, "Code", "Name", sysEmp.ClassCode);
//            ViewData["TypeCode"] = new SelectList(_context.SysEmpTypes, "Code", "Name", sysEmp.TypeCode);
//            return View(sysEmp);
//        }

//        // GET: SysEmp/Edit/5
//        public async Task<IActionResult> Edit(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var sysEmp = await _context.SysEmps.FindAsync(id);
//            if (sysEmp == null)
//            {
//                return NotFound();
//            }
//            ViewData["AdminDutyCode"] = new SelectList(_context.ComAdminDutys, "Code", "Name", sysEmp.AdminDutyCode);
//            ViewData["DegreeCode"] = new SelectList(_context.ComDegrees, "Code", "Name", sysEmp.DegreeCode);
//            ViewData["EducationCode"] = new SelectList(_context.ComEducations, "Code", "Name", sysEmp.EducationCode);
//            ViewData["GenderCode"] = new SelectList(_context.ComGenders, "Code", "Name", sysEmp.GenderCode);
//            ViewData["MarriageCode"] = new SelectList(_context.ComMarriages, "Code", "Name", sysEmp.MarriageCode);
//            ViewData["NationCode"] = new SelectList(_context.ComNations, "Code", "Name", sysEmp.NationCode);
//            ViewData["PoliticalCode"] = new SelectList(_context.ComPoliticals, "Code", "Name", sysEmp.PoliticalCode);
//            ViewData["PostCode"] = new SelectList(_context.ComPosts, "Code", "Name", sysEmp.PostCode);
//            ViewData["PostLevelCode"] = new SelectList(_context.ComPostLevels, "Code", "Name", sysEmp.PostLevelCode);
//            ViewData["PostTypeCode"] = new SelectList(_context.ComPostTypes, "Code", "Name", sysEmp.PostTypeCode);
//            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles, "Code", "Name", sysEmp.ProfessionTitleCode);
//            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Name", sysEmp.ProfessionTitleLevelCode);
//            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Name", sysEmp.ProfessionTitleTypeCode);
//            ViewData["DeptCode"] = new SelectList(_context.SysDepts, "DeptCode", "DeptCode", sysEmp.DeptCode);
//            ViewData["AttributeCode"] = new SelectList(_context.SysEmpAttributes, "Code", "Name", sysEmp.AttributeCode);
//            ViewData["ClassCode"] = new SelectList(_context.SysEmpClasss, "Code", "Name", sysEmp.ClassCode);
//            ViewData["TypeCode"] = new SelectList(_context.SysEmpTypes, "Code", "Name", sysEmp.TypeCode);
//            return View(sysEmp);
//        }

//        // POST: SysEmp/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(string id, [Bind("EmpCode,EmpName,Spell,DeptCode,OldName,GenderCode,NationCode,BirthDate,Age,PoliticalCode,PoliticalDate,IdentityCard,ProfessionTitleTypeCode,ProfessionTitleCode,ProfessionTitleLevelCode,AdminDutyCode,IsPost,TypeCode,ClassCode,AttributeCode,WorkDate,HospitalDate,PostCode,PostTypeCode,PostLevelCode,WorkAge,HospitalAge,Practice,PracticeDate,OpenBank,BankCard,EducationCode,EducationDate,DegreeCode,School,SchoolMajor,GraduationDate,Telephone,MarriageCode,BirthAdd,HomeAdd,IdentityAdd,NativePlace,Photo,IsStop,Remark,CreateEmp,CreateDate")] SysEmp sysEmp)
//        {
//            if (id != sysEmp.EmpCode)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(sysEmp);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!SysEmpExists(sysEmp.EmpCode))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["AdminDutyCode"] = new SelectList(_context.ComAdminDutys, "Code", "Name", sysEmp.AdminDutyCode);
//            ViewData["DegreeCode"] = new SelectList(_context.ComDegrees, "Code", "Name", sysEmp.DegreeCode);
//            ViewData["EducationCode"] = new SelectList(_context.ComEducations, "Code", "Name", sysEmp.EducationCode);
//            ViewData["GenderCode"] = new SelectList(_context.ComGenders, "Code", "Name", sysEmp.GenderCode);
//            ViewData["MarriageCode"] = new SelectList(_context.ComMarriages, "Code", "Name", sysEmp.MarriageCode);
//            ViewData["NationCode"] = new SelectList(_context.ComNations, "Code", "Name", sysEmp.NationCode);
//            ViewData["PoliticalCode"] = new SelectList(_context.ComPoliticals, "Code", "Name", sysEmp.PoliticalCode);
//            ViewData["PostCode"] = new SelectList(_context.ComPosts, "Code", "Name", sysEmp.PostCode);
//            ViewData["PostLevelCode"] = new SelectList(_context.ComPostLevels, "Code", "Name", sysEmp.PostLevelCode);
//            ViewData["PostTypeCode"] = new SelectList(_context.ComPostTypes, "Code", "Name", sysEmp.PostTypeCode);
//            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles, "Code", "Name", sysEmp.ProfessionTitleCode);
//            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels, "Code", "Name", sysEmp.ProfessionTitleLevelCode);
//            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes, "Code", "Name", sysEmp.ProfessionTitleTypeCode);
//            ViewData["DeptCode"] = new SelectList(_context.SysDepts, "DeptCode", "DeptCode", sysEmp.DeptCode);
//            ViewData["AttributeCode"] = new SelectList(_context.SysEmpAttributes, "Code", "Name", sysEmp.AttributeCode);
//            ViewData["ClassCode"] = new SelectList(_context.SysEmpClasss, "Code", "Name", sysEmp.ClassCode);
//            ViewData["TypeCode"] = new SelectList(_context.SysEmpTypes, "Code", "Name", sysEmp.TypeCode);
//            return View(sysEmp);
//        }

//        // GET: SysEmp/Delete/5
//        public async Task<IActionResult> Delete(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var sysEmp = await _context.SysEmps
//                .Include(s => s.ComAdminDuty)
//                .Include(s => s.ComDegree)
//                .Include(s => s.ComEducation)
//                .Include(s => s.ComGender)
//                .Include(s => s.ComMarriage)
//                .Include(s => s.ComNation)
//                .Include(s => s.ComPolitical)
//                .Include(s => s.ComPost)
//                .Include(s => s.ComPostLevel)
//                .Include(s => s.ComPostType)
//                .Include(s => s.ComProfessionTitle)
//                .Include(s => s.ComProfessionTitleLevel)
//                .Include(s => s.ComProfessionTitleType)
//                .Include(s => s.SysDept)
//                .Include(s => s.SysEmpAttribute)
//                .Include(s => s.SysEmpClass)
//                .Include(s => s.SysEmpType)
//                .FirstOrDefaultAsync(m => m.EmpCode == id);
//            if (sysEmp == null)
//            {
//                return NotFound();
//            }

//            return View(sysEmp);
//        }

//        // POST: SysEmp/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(string id)
//        {
//            var sysEmp = await _context.SysEmps.FindAsync(id);
//            _context.SysEmps.Remove(sysEmp);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool SysEmpExists(string id)
//        {
//            return _context.SysEmps.Any(e => e.EmpCode == id);
//        }

//        //获取集合
//        public IActionResult GetProfessionTitles(string code)
//        {
//            var ComProfessionTitles = _context.ComProfessionTitles.Where(t => t.TypeCode == Guid.Parse(code)).OrderBy(t => t.Sort).ToList();
//            return Json(ComProfessionTitles);
//        }


//        //[HttpPost]
//        //public IActionResult SDF1([FromBody]ParamModel param)
//        //{
//        //    return Json(_context.ComProfessionTitles.Where(t => t.TypeCode == Guid.Parse(param.Value)).OrderBy(t => t.Sort).ToList());
//        //}


//        //public IActionResult SDF2(string a)
//        //{
//        //    return Json(_context.ComProfessionTitles.Where(t => t.TypeCode == Guid.Parse(a)).OrderBy(t => t.Sort).ToList());
//        //}
//    }
//}
