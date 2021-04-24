using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KnowledgeSearching.Data;
using KnowledgeSearching.Models;

namespace KnowledgeSearching.Controllers
{
    public class KnowledgesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KnowledgesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Knowledges
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Knowledge.ToListAsync());
        }

        // GET: Knowledges/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knowledge = await _context.Knowledge
                .FirstOrDefaultAsync(m => m.ID == id);
            if (knowledge == null)
            {
                return NotFound();
            }

            return View(knowledge);
        }

        // GET: Knowledges/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Knowledges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,KeyWords,Link")] Knowledge knowledge)
        {
            if (ModelState.IsValid)
            {
                _context.Add(knowledge);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(knowledge);
        }

        // GET: Knowledges/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knowledge = await _context.Knowledge.FindAsync(id);
            if (knowledge == null)
            {
                return NotFound();
            }
            return View(knowledge);
        }

        // POST: Knowledges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Title,KeyWords,Link")] Knowledge knowledge)
        {
            if (id != knowledge.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(knowledge);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KnowledgeExists(knowledge.ID))
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
            return View(knowledge);
        }

        // GET: Knowledges/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knowledge = await _context.Knowledge
                .FirstOrDefaultAsync(m => m.ID == id);
            if (knowledge == null)
            {
                return NotFound();
            }

            return View(knowledge);
        }

        // POST: Knowledges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var knowledge = await _context.Knowledge.FindAsync(id);
            _context.Knowledge.Remove(knowledge);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KnowledgeExists(string id)
        {
            return _context.Knowledge.Any(e => e.ID == id);
        }

        public IActionResult Search()
        {
            return View();
        }

        public async Task<IActionResult> SearchResult(string searchString)
        {
            ViewData["ss"] = searchString;
            return View("Result", await _context.Knowledge.Where(m => m.KeyWords.Contains(searchString)).ToListAsync());
        }

        public async Task<IActionResult> SearchResult_toIndex_ByTitle(string searchString)
        {
            ViewData["ss"] = searchString;
            return View("Index", await _context.Knowledge.Where(m => m.Title.Contains(searchString)).ToListAsync());
        }

        public async Task<IActionResult> SearchResult_toIndex_ByID(string searchString)
        {
            ViewData["ss"] = searchString;
            return View("Index", await _context.Knowledge.Where(m => m.ID.Contains(searchString)).ToListAsync());
        }

        public async Task<IActionResult> Result()
        {
            return View(await _context.Knowledge.ToListAsync());
        }
    }
}
