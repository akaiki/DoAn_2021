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
    public class RelationshipsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RelationshipsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Relationships
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Relationship.Include(r => r.Lesson_A).Include(r => r.Lesson_B);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Relationships/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relationship = await _context.Relationship
                .Include(r => r.Lesson_A)
                .Include(r => r.Lesson_B)
                .FirstOrDefaultAsync(m => m.Id_Relationship == id);
            if (relationship == null)
            {
                return NotFound();
            }

            return View(relationship);
        }

        // GET: Relationships/Create
        public IActionResult Create()
        {
            ViewData["Id_Lesson_A"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson");
            ViewData["Id_Lesson_B"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson");
            return View();
        }

        // POST: Relationships/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Relationship,Id_Lesson_A,Id_Lesson_B")] Relationship relationship)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relationship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Lesson_A"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", relationship.Id_Lesson_A);
            ViewData["Id_Lesson_B"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", relationship.Id_Lesson_B);
            return View(relationship);
        }

        // GET: Relationships/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relationship = await _context.Relationship.FindAsync(id);
            if (relationship == null)
            {
                return NotFound();
            }
            ViewData["Id_Lesson_A"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", relationship.Id_Lesson_A);
            ViewData["Id_Lesson_B"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", relationship.Id_Lesson_B);
            return View(relationship);
        }

        // POST: Relationships/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Relationship,Id_Lesson_A,Id_Lesson_B")] Relationship relationship)
        {
            if (id != relationship.Id_Relationship)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relationship);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelationshipExists(relationship.Id_Relationship))
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
            ViewData["Id_Lesson_A"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", relationship.Id_Lesson_A);
            ViewData["Id_Lesson_B"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", relationship.Id_Lesson_B);
            return View(relationship);
        }

        // GET: Relationships/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relationship = await _context.Relationship
                .Include(r => r.Lesson_A)
                .Include(r => r.Lesson_B)
                .FirstOrDefaultAsync(m => m.Id_Relationship == id);
            if (relationship == null)
            {
                return NotFound();
            }

            return View(relationship);
        }

        // POST: Relationships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var relationship = await _context.Relationship.FindAsync(id);
            _context.Relationship.Remove(relationship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelationshipExists(int id)
        {
            return _context.Relationship.Any(e => e.Id_Relationship == id);
        }
    }
}
