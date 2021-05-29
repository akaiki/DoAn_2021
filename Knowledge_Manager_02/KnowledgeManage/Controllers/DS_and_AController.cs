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
            return View(Relate("ContentView"));
        }
        public IActionResult Search()
        {
            return View(Relate("SearchView"));
        }

        /*Tìm kiếm chủ đề bài học*/
        public async Task<IActionResult> SearchLesson(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                ViewData["ss"] = "404_null";
                return View("Result_lesson", Relate(ViewData["ss"].ToString()));
            }
            else
            {
                ViewData["ss"] = searchString;
                return View("Result_lesson", await _context.Lesson.Where(m => m.Name_Lesson.ToLower().Contains(searchString.ToLower())).ToListAsync());
            }
           
        }

        public async Task<IActionResult> Result_lesson()
        {
            return View(await _context.Lesson.ToListAsync());
        }

        /*Tìm kiếm bài tập*/
        public async Task<IActionResult> SearchExercise(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                ViewData["ss"] = "404_null";
                return View("Result_exercise");
            }
            else
            {
                ViewData["ss"] = searchString;
                return View("Result_exercise", await _context.Exercise.Where(m => m.Name_Exercise.ToLower().Contains(searchString.ToLower())).ToListAsync());
            }
        }
        public async Task<IActionResult> Result_exercise()
        {
            return View(await _context.Exercise.ToListAsync());
        }


        /*Tìm kiếm khái niệm*/
        public async Task<IActionResult> SearchConcept(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                ViewData["ss"] = "404_null";
                return View("Result_concept");
            }
            else
            {
                ViewData["ss"] = searchString;
                return View("Result_concept", await _context.Concept.Where(m => m.Name_Concept.ToLower().Contains(searchString.ToLower())).ToListAsync());
            }
        }
        public async Task<IActionResult> Result_concept()
        {
            return View(await _context.Concept.ToListAsync());
        }

        /*Tìm kiếm cách biểu diễn/ cài đặt*/
        public async Task<IActionResult> SearchConstruct(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                ViewData["ss"] = "404_null";
                return View("Result_construct");
            }
            else
            {
                ViewData["ss"] = searchString;
                return View("Result_construct", await _context.Construct.Where(m => m.Name_Construct.ToLower().Contains(searchString.ToLower())).ToListAsync());
            }
        }
        public async Task<IActionResult> Result_construct()
        {
            return View(await _context.Construct.ToListAsync());
        }

        /*Tìm kiếm toán tử*/
        public async Task<IActionResult> SearchOperator(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                ViewData["ss"] = "404_null";
                return View("Result_operator");
            }
            else
            {
                ViewData["ss"] = searchString;
                return View("Result_operator", await _context.Operator.Where(m => m.Name_Operator.ToLower().Contains(searchString.ToLower())).ToListAsync());
            }
        }
        public async Task<IActionResult> Result_operator()
        {
            return View(await _context.Operator.ToListAsync());
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
        public IActionResult I_6_4()
        {
            return View(Relate("I_6_4"));
        }
        public IActionResult I_6_5()
        {
            return View(Relate("I_6_5"));
        }
        public IActionResult I_7()
        {
            return View(Relate("I_7"));
        }
        public IActionResult I_7_3_1()
        {
            return View(Relate("I_7_3_1"));
        }
        public IActionResult I_7_3_2()
        {
            return View(Relate("I_7_3_2"));
        }
        public IActionResult III_1()
        {
            return View(Relate("III_1"));
        }
        public IActionResult III_2()
        {
            return View(Relate("III_2"));
        }
        public IActionResult III_3()
        {
            return View(Relate("III_3"));
        }
        public IActionResult III_4()
        {
            return View(Relate("III_4"));
        }
        public IActionResult III_5()
        {
            return View(Relate("III_5"));
        }
        public IActionResult III_6()
        {
            return View(Relate("III_6"));
        }
        public IActionResult III_7()
        {
            return View(Relate("III_7"));
        }
        public IActionResult III_8()
        {
            return View(Relate("III_8"));
        }
    }
}
