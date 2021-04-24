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
            var applicationDbContext = _context.Relationship.Include(r => r.Knowledge_A).Include(r => r.Knowledge_B);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Relationships/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relationship = await _context.Relationship
                .Include(r => r.Knowledge_A)
                .Include(r => r.Knowledge_B)
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
            ViewData["Id_Knowledge_A"] = new SelectList(_context.Knowledge, "Id_Knowledge", "Id_Knowledge");
            ViewData["Id_Knowledge_B"] = new SelectList(_context.Knowledge, "Id_Knowledge", "Id_Knowledge");
            return View();
        }

        // POST: Relationships/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Relationship,Id_Knowledge_A,Id_Knowledge_B")] Relationship relationship)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relationship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Knowledge_A"] = new SelectList(_context.Knowledge, "Id_Knowledge", "Id_Knowledge", relationship.Id_Knowledge_A);
            ViewData["Id_Knowledge_B"] = new SelectList(_context.Knowledge, "Id_Knowledge", "Id_Knowledge", relationship.Id_Knowledge_B);
            return View(relationship);
        }

        // GET: Relationships/Edit/5
        public async Task<IActionResult> Edit(string id)
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
            ViewData["Id_Knowledge_A"] = new SelectList(_context.Knowledge, "Id_Knowledge", "Id_Knowledge", relationship.Id_Knowledge_A);
            ViewData["Id_Knowledge_B"] = new SelectList(_context.Knowledge, "Id_Knowledge", "Id_Knowledge", relationship.Id_Knowledge_B);
            return View(relationship);
        }

        // POST: Relationships/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id_Relationship,Id_Knowledge_A,Id_Knowledge_B")] Relationship relationship)
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
            ViewData["Id_Knowledge_A"] = new SelectList(_context.Knowledge, "Id_Knowledge", "Id_Knowledge", relationship.Id_Knowledge_A);
            ViewData["Id_Knowledge_B"] = new SelectList(_context.Knowledge, "Id_Knowledge", "Id_Knowledge", relationship.Id_Knowledge_B);
            return View(relationship);
        }

        // GET: Relationships/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relationship = await _context.Relationship
                .Include(r => r.Knowledge_A)
                .Include(r => r.Knowledge_B)
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
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var relationship = await _context.Relationship.FindAsync(id);
            _context.Relationship.Remove(relationship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelationshipExists(string id)
        {
            return _context.Relationship.Any(e => e.Id_Relationship == id);
        }
    }
}
