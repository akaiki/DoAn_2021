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
    public class ConstructsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConstructsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Constructs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Construct.Include(c => c.Lesson);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Constructs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var construct = await _context.Construct
                .Include(c => c.Lesson)
                .FirstOrDefaultAsync(m => m.Id_Construct == id);
            if (construct == null)
            {
                return NotFound();
            }

            return View(construct);
        }

        // GET: Constructs/Create
        public IActionResult Create()
        {
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson");
            return View();
        }

        // POST: Constructs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Construct,Link_Construct,Name_Construct,LessonId_Lesson")] Construct construct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(construct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", construct.LessonId_Lesson);
            return View(construct);
        }

        // GET: Constructs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var construct = await _context.Construct.FindAsync(id);
            if (construct == null)
            {
                return NotFound();
            }
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", construct.LessonId_Lesson);
            return View(construct);
        }

        // POST: Constructs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Construct,Link_Construct,Name_Construct,LessonId_Lesson")] Construct construct)
        {
            if (id != construct.Id_Construct)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(construct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConstructExists(construct.Id_Construct))
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
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", construct.LessonId_Lesson);
            return View(construct);
        }

        // GET: Constructs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var construct = await _context.Construct
                .Include(c => c.Lesson)
                .FirstOrDefaultAsync(m => m.Id_Construct == id);
            if (construct == null)
            {
                return NotFound();
            }

            return View(construct);
        }

        // POST: Constructs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var construct = await _context.Construct.FindAsync(id);
            _context.Construct.Remove(construct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConstructExists(int id)
        {
            return _context.Construct.Any(e => e.Id_Construct == id);
        }
    }
}
