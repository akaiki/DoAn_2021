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

        public IActionResult Search()
        {
            return View();
        }

        public async Task<IActionResult> SearchLesson(string searchString)
        {
            ViewData["ss"] = searchString;
            return View("Result_lesson", await _context.Lesson.Where(m => m.Name_Lesson.ToLower().Contains(searchString.ToLower())).ToListAsync());
        }

        public async Task<IActionResult> SearchExercise(string searchString)
        {
            ViewData["ss"] = searchString;
            return View("Result_exercise", await _context.Exercise.Where(m => m.Name_Exercise.ToLower().Contains(searchString.ToLower())).ToListAsync());
        }
        
        public async Task<IActionResult> Result_lesson()
        {
            return View(await _context.Lesson.ToListAsync());
        }

        public async Task<IActionResult> Result_exercise()
        {
            return View(await _context.Exercise.ToListAsync());
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

        public IActionResult I()
        {
            return View(Relate("I"));
        }

        public IActionResult I_2()
        {
            return View(Relate("I_2"));
        }

        public IActionResult I_3()
        {
            return View(Relate("I_3"));
        }

        public IActionResult I_4()
        {
            return View(Relate("I_4"));
        }

        public IActionResult I_5()
        {
            return View(Relate("I_5"));
        }

        public IActionResult I_6()
        {
            return View(Relate("I_6"));
        }
        public IActionResult I_7()
        {
            return View(Relate("I_7"));
        }
        public IActionResult I_2_4()
        {
            return View(Relate("I_2_4"));
        }

        public IActionResult II_5()
        {
            return View(Relate("II_5"));
        }

        
    }
}
