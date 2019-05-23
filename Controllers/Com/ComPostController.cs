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
    public class ComPostController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComPostController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComPost
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComPosts.ToListAsync());
        }

        // GET: ComPost/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comPost = await _context.ComPosts
                .FirstOrDefaultAsync(m => m.Code == id);
            if (comPost == null)
            {
                return NotFound();
            }

            return View(comPost);
        }

        // GET: ComPost/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComPost/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Spell,Sort")] ComPost comPost)
        {
            if (ModelState.IsValid)
            {
                //comPost.Code = Guid.NewGuid();
                //排序MAX加1
                if (_context.ComPosts.Count() > 0)
                    comPost.Sort = _context.ComPosts.Max(t => t.Sort) + 1;
                //拼音码没有
                if (string.IsNullOrWhiteSpace(comPost.Spell))
                    comPost.Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(comPost.Name);
                _context.Add(comPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comPost);
        }

        // GET: ComPost/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comPost = await _context.ComPosts.FindAsync(id);
            if (comPost == null)
            {
                return NotFound();
            }
            return View(comPost);
        }

        // POST: ComPost/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Code,Name,Spell,Sort")] ComPost comPost)
        {
            if (id != comPost.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComPostExists(comPost.Code))
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
            return View(comPost);
        }

        //// GET: ComPost/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var comPost = await _context.ComPosts
        //        .FirstOrDefaultAsync(m => m.Code == id);
        //    if (comPost == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(comPost);
        //}

        //// POST: ComPost/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var comPost = await _context.ComPosts.FindAsync(id);
        //    _context.ComPosts.Remove(comPost);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ComPostExists(Guid id)
        {
            return _context.ComPosts.Any(e => e.Code == id);
        }
    }
}
