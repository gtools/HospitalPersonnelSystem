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

namespace HospitalPersonnelSystem.Controllers
{
    public class SysProfessionInfoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SysProfessionInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SysProfessionInfo
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SysProfessionInfos.Include(s => s.ComProfessionExtent).Include(s => s.ComProfessionRegister).Include(s => s.ComProfessionTitle).Include(s => s.ComProfessionTitleLevel).Include(s => s.ComProfessionTitleType).Include(s => s.ComProfessionType).Include(s => s.SysEmp);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SysProfessionInfo/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysProfessionInfo = await _context.SysProfessionInfos
                .Include(s => s.ComProfessionExtent)
                .Include(s => s.ComProfessionRegister)
                .Include(s => s.ComProfessionTitle)
                .Include(s => s.ComProfessionTitleLevel)
                .Include(s => s.ComProfessionTitleType)
                .Include(s => s.ComProfessionType)
                .Include(s => s.SysEmp)
                .FirstOrDefaultAsync(m => m.Code == id);
            if (sysProfessionInfo == null)
            {
                return NotFound();
            }

            return View(sysProfessionInfo);
        }

        // GET: SysProfessionInfo/Create
        public IActionResult Create()
        {
            ViewData["ProfessionTypeCode"] = new SelectList(_context.ComProfessionExtents.OrderBy(t => t.Sort).ToList(), "Code", "Name");
            ViewData["ProfessionRegisterCode"] = new SelectList(_context.ComProfessionRegisters.OrderBy(t => t.Sort).ToList(), "Code", "Name");
            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles.OrderBy(t => t.Sort).ToList(), "Code", "Name");
            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels.OrderBy(t => t.Sort).ToList(), "Code", "Name");
            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes.OrderBy(t => t.Sort).ToList(), "Code", "Name", "b9bbcf12-f2c7-48e1-9ece-12068ac58768");
            ViewData["ProfessionTypeCode"] = new SelectList(_context.ComProfessionTypes.OrderBy(t => t.Sort).ToList(), "Code", "Name");
            ViewData["EmpCode"] = new SelectList(_context.SysEmps.OrderBy(t => t.EmpCode).ToList(), "EmpCode", "EmpName");
            ViewData["ProfessionExtentCode"] = new SelectList(_context.ComProfessionExtents.OrderBy(t => t.Sort).ToList(), "Code", "Name");
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View();
        }

        // POST: SysProfessionInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,EmpCode,ProfessionRegisterCode,TypeCode,ExtentCode,ProfessionTitleTypeCode,ProfessionTitleLevelCode,ProfessionTitleCode,IsEngage,EngageDate,ProfessionTypeCode,ProfessionalName,UpDate,No1,No2,No3,No4,No5,Remark,CreateEmp,CreateDate")] SysProfessionInfo sysProfessionInfo)
        {
            if (ModelState.IsValid)
            {
                //sysProfessionInfo.Code = Guid.NewGuid();
                _context.Add(sysProfessionInfo);
                //更新SysEmps数据
                var sysEmps = await _context.SysEmps.FindAsync(sysProfessionInfo.EmpCode);
                sysEmps.ProfessionTitleCode = sysProfessionInfo.ProfessionTitleCode;
                sysEmps.ProfessionTitleLevelCode = sysProfessionInfo.ProfessionTitleLevelCode;
                sysEmps.ProfessionTitleTypeCode = sysProfessionInfo.ProfessionTitleTypeCode;
                _context.Update(sysEmps);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProfessionTypeCode"] = new SelectList(_context.ComProfessionExtents.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTypeCode);
            ViewData["ProfessionRegisterCode"] = new SelectList(_context.ComProfessionRegisters.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionRegisterCode);
            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTitleCode);
            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTitleLevelCode);
            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTitleTypeCode);
            ViewData["ProfessionTypeCode"] = new SelectList(_context.ComProfessionTypes.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTypeCode);
            ViewData["EmpCode"] = new SelectList(_context.SysEmps.OrderBy(t => t.EmpCode).ToList(), "EmpCode", "EmpName", sysProfessionInfo.EmpCode);
            ViewData["ProfessionExtentCode"] = new SelectList(_context.ComProfessionExtents.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionExtentCode);
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View(sysProfessionInfo);
        }

        // GET: SysProfessionInfo/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysProfessionInfo = await _context.SysProfessionInfos.FindAsync(id);
            if (sysProfessionInfo == null)
            {
                return NotFound();
            }
            ViewData["ProfessionTypeCode"] = new SelectList(_context.ComProfessionExtents.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTypeCode);
            ViewData["ProfessionRegisterCode"] = new SelectList(_context.ComProfessionRegisters.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionRegisterCode);
            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTitleCode);
            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTitleLevelCode);
            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTitleTypeCode);
            ViewData["ProfessionTypeCode"] = new SelectList(_context.ComProfessionTypes.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTypeCode);
            ViewData["EmpCode"] = new SelectList(_context.SysEmps.OrderBy(t => t.EmpCode).ToList(), "EmpCode", "EmpName", sysProfessionInfo.EmpCode);
            ViewData["ProfessionExtentCode"] = new SelectList(_context.ComProfessionExtents.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionExtentCode);
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View(sysProfessionInfo);
        }

        // POST: SysProfessionInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,EmpCode,ProfessionRegisterCode,TypeCode,ExtentCode,ProfessionTitleTypeCode,ProfessionTitleLevelCode,ProfessionTitleCode,IsEngage,EngageDate,ProfessionTypeCode,ProfessionalName,UpDate,No1,No2,No3,No4,No5,Remark,CreateEmp,CreateDate")] SysProfessionInfo sysProfessionInfo)
        {
            if (id != sysProfessionInfo.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysProfessionInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysProfessionInfoExists(sysProfessionInfo.Code))
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
            ViewData["ProfessionTypeCode"] = new SelectList(_context.ComProfessionExtents.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTypeCode);
            ViewData["ProfessionRegisterCode"] = new SelectList(_context.ComProfessionRegisters.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionRegisterCode);
            ViewData["ProfessionTitleCode"] = new SelectList(_context.ComProfessionTitles.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTitleCode);
            ViewData["ProfessionTitleLevelCode"] = new SelectList(_context.ComProfessionTitleLevels.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTitleLevelCode);
            ViewData["ProfessionTitleTypeCode"] = new SelectList(_context.ComProfessionTitleTypes.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTitleTypeCode);
            ViewData["ProfessionTypeCode"] = new SelectList(_context.ComProfessionTypes.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionTypeCode);
            ViewData["EmpCode"] = new SelectList(_context.SysEmps.OrderBy(t => t.EmpCode).ToList(), "EmpCode", "EmpName", sysProfessionInfo.EmpCode);
            ViewData["ProfessionExtentCode"] = new SelectList(_context.ComProfessionExtents.OrderBy(t => t.Sort).ToList(), "Code", "Name", sysProfessionInfo.ProfessionExtentCode);
            ViewData["EmpCode"] = ((SelectList)ViewData["EmpCode"]).ToList().GetSelectList();
            return View(sysProfessionInfo);
        }

        //// GET: SysProfessionInfo/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sysProfessionInfo = await _context.SysProfessionInfos
        //        .Include(s => s.ComProfessionExtent)
        //        .Include(s => s.ComProfessionRegister)
        //        .Include(s => s.ComProfessionTitle)
        //        .Include(s => s.ComProfessionTitleLevel)
        //        .Include(s => s.ComProfessionTitleType)
        //        .Include(s => s.ComProfessionType)
        //        .Include(s => s.SysEmp)
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (sysProfessionInfo == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sysProfessionInfo);
        //}

        //// POST: SysProfessionInfo/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var sysProfessionInfo = await _context.SysProfessionInfos.FindAsync(id);
        //    _context.SysProfessionInfos.Remove(sysProfessionInfo);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool SysProfessionInfoExists(Guid id)
        {
            return _context.SysProfessionInfos.Any(e => e.Code == id);
        }

        ///// <summary>
        ///// 聘任验证
        ///// </summary>
        ///// <param name="isEngage">是否聘用</param>
        ///// <param name="engageDate">聘用日期</param>
        ///// <returns></returns>
        //[AcceptVerbs("Get", "Post")]
        //public IActionResult VerifyEngage(bool isEngage, DateTime engageDate)
        //{
        //    if (isEngage && DateTime.MinValue == engageDate)
        //        return Json(data: $"【聘任日期】不能为空。");
        //    return Json(data: true);
        //}
    }
}
