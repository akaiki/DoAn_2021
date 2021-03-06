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
    public class OperatorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OperatorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Operators
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Operator.Include(a => a.Lesson);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Operators/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @operator = await _context.Operator
                .Include(a => a.Lesson)
                .FirstOrDefaultAsync(m => m.Id_Operator == id);
            if (@operator == null)
            {
                return NotFound();
            }

            return View(@operator);
        }

        // GET: Operators/Create
        public IActionResult Create()
        {
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson");
            return View();
        }

        // POST: Operators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Operator,Link_Operator,Name_Operator,LessonId_Lesson")] Operator @operator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@operator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", @operator.LessonId_Lesson);
            return View(@operator);
        }

        // GET: Operators/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @operator = await _context.Operator.FindAsync(id);
            if (@operator == null)
            {
                return NotFound();
            }
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", @operator.LessonId_Lesson);
            return View(@operator);
        }

        // POST: Operators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Operator,Link_Operator,Name_Operator,LessonId_Lesson")] Operator @operator)
        {
            if (id != @operator.Id_Operator)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@operator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperatorExists(@operator.Id_Operator))
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
            ViewData["LessonId_Lesson"] = new SelectList(_context.Lesson, "Id_Lesson", "Id_Lesson", @operator.LessonId_Lesson);
            return View(@operator);
        }

        // GET: Operators/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @operator = await _context.Operator
                .Include(a => a.Lesson)
                .FirstOrDefaultAsync(m => m.Id_Operator == id);
            if (@operator == null)
            {
                return NotFound();
            }

            return View(@operator);
        }

        // POST: Operators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @operator = await _context.Operator.FindAsync(id);
            _context.Operator.Remove(@operator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperatorExists(int id)
        {
            return _context.Operator.Any(e => e.Id_Operator == id);
        }
    }
}
