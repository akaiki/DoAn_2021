using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KnowledgeManage.Data;
using KnowledgeManage.Models;

namespace KnowledgeManage.Controllers
{
    public class ChaptersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChaptersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Chapters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chapter.ToListAsync());
        }

        // GET: Chapters/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chapter = await _context.Chapter
                .FirstOrDefaultAsync(m => m.Id_Chap == id);
            if (chapter == null)
            {
                return NotFound();
            }

            return View(chapter);
        }

        // GET: Chapters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chapters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Chap,Name_Chap,Key_Chap,Link_Chap")] Chapter chapter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chapter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chapter);
        }

        // GET: Chapters/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chapter = await _context.Chapter.FindAsync(id);
            if (chapter == null)
            {
                return NotFound();
            }
            return View(chapter);
        }

        // POST: Chapters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id_Chap,Name_Chap,Key_Chap,Link_Chap")] Chapter chapter)
        {
            if (id != chapter.Id_Chap)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chapter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChapterExists(chapter.Id_Chap))
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
            return View(chapter);
        }

        // GET: Chapters/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chapter = await _context.Chapter
                .FirstOrDefaultAsync(m => m.Id_Chap == id);
            if (chapter == null)
            {
                return NotFound();
            }

            return View(chapter);
        }

        // POST: Chapters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chapter = await _context.Chapter.FindAsync(id);
            _context.Chapter.Remove(chapter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChapterExists(string id)
        {
            return _context.Chapter.Any(e => e.Id_Chap == id);
        }
    }
}
