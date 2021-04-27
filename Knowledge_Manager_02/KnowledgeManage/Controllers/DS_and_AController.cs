using KnowledgeManage.Data;
using KnowledgeManage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManage.Controllers
{
    public class DS_and_AController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DS_and_AController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Content()
        {  

            return View(Relate("Content"));
        }

        public async Task<IActionResult> Test()
        {
            return View(await _context.Lesson.ToListAsync());
        }

        public async Task<IActionResult> Search(string searchstring)
        {
            return View("Test", await _context.Lesson.Where(m => m.Name_Lesson.Contains(searchstring)).ToListAsync());
        }

        public IActionResult I_2()
        {
            return View(Relate("I_2"));
        }

        public IActionResult I_2_4()
        {
            return View(Relate("I_2_4"));
        }

        public IActionResult II_5()
        {
            return View(Relate("II_5"));
        }

        public List<Lesson> Relate(string link)
        {

            var r = from i in _context.Relationship
                    where i.Id_Lesson_A == link
                    select i;
            var kq = from ls in _context.Lesson
                     join rel in r on ls.Id_Lesson equals rel.Id_Lesson_B
                     select ls;
            
            return kq.ToList();
        }
    }
}
