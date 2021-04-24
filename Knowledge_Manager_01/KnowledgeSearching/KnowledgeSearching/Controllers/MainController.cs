using KnowledgeSearching.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeSearching.Controllers
{
    public class MainController : Controller
    {

        private readonly ApplicationDbContext _db;
        
        public MainController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult ViewContent()
        {
            return View();
        }

        public async Task<IActionResult> Menu()
        {
            return View(await _db.Knowledge.ToListAsync());
        }


        private bool KnowledgeExists(string id)
        {
            return _db.Knowledge.Any(e => e.ID == id);
        }

        public async Task<IActionResult> WelcomePage()
        {
            return View(await _db.Knowledge.ToListAsync());
        }


        public async Task<IActionResult> SearhcResult(string searchString)
        {
            return View("WelcomePage", await _db.Knowledge.Where(m => m.KeyWords.Contains(searchString)).ToListAsync());
        }

        public IActionResult I()
        {
            return View();
        }

        public IActionResult I_1()
        {
            return View();
        }

        public IActionResult I_2()
        {
            return View();
        }

        public IActionResult I_3()
        {
            return View();
        }

        public IActionResult I_3_1()
        {
            return View();
        }

        public IActionResult I_3_2()
        {
            return View();
        }

        public IActionResult I_3_3()
        {
            return View();
        }

        public IActionResult I_3_4()
        {
            return View();
        }

        public IActionResult I_3_5()
        {
            return View();
        }

        public IActionResult II()
        {
            return View();
        }

        public IActionResult II_1()
        {
            return View();
        }

        public IActionResult II_2()
        {
            return View();
        }


        public IActionResult II_3()
        {
            return View();
        }

        public IActionResult II_4()
        {
            return View();
        }

        public IActionResult II_4_1()
        {
            return View();
        }

        public IActionResult II_4_2()
        {
            return View();
        }

        public IActionResult II_4_3()
        {
            return View();
        }

        public IActionResult II_4_4()
        {
            return View();
        }

        public IActionResult II_5()
        {
            return View();
        }
    }
}
