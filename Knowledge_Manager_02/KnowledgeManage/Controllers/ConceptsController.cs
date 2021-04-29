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
    public class ConceptsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConceptsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Concepts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Concept.Include(c => c.Lesson);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Concepts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concept = await _context.Concept
                .Include(c => c.Lesson)
                .FirstOrDefaultAsync(m => m.Id_Concept == id);
            if (concept == null)
            {
                return NotFound();
            }

            return View(concept);
        }

        // GET: Concepts/Create
        public IActionResult Create()
        {
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson");
            return View();
        }

        // POST: Concepts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Concept,Link_Concept,Name_Concept,LessonId_Lesson")] Concept concept)
        {
            if (ModelState.IsValid)
            {
                _context.Add(concept);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", concept.LessonId_Lesson);
            return View(concept);
        }

        // GET: Concepts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concept = await _context.Concept.FindAsync(id);
            if (concept == null)
            {
                return NotFound();
            }
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", concept.LessonId_Lesson);
            return View(concept);
        }

        // POST: Concepts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Concept,Link_Concept,Name_Concept,LessonId_Lesson")] Concept concept)
        {
            if (id != concept.Id_Concept)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(concept);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConceptExists(concept.Id_Concept))
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
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", concept.LessonId_Lesson);
            return View(concept);
        }

        // GET: Concepts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concept = await _context.Concept
                .Include(c => c.Lesson)
                .FirstOrDefaultAsync(m => m.Id_Concept == id);
            if (concept == null)
            {
                return NotFound();
            }

            return View(concept);
        }

        // POST: Concepts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var concept = await _context.Concept.FindAsync(id);
            _context.Concept.Remove(concept);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConceptExists(int id)
        {
            return _context.Concept.Any(e => e.Id_Concept == id);
        }
    }
}
