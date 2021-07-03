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
                ViewData["ss"] = searchString;
            var les = from l in _context.Lesson
                      where l.Key_Lesson.ToLower().Contains(searchString.ToLower())
                      select l;
            return View("Result_lesson", await les.ToListAsync());
        }

        public async Task<IActionResult> Result_lesson()
        {
            return View(await _context.Lesson.ToListAsync());
        }

        /*Tìm kiếm bài tập*/
        public async Task<IActionResult> SearchExercise(string searchString)
        {
            ViewData["ss"] = searchString;
            var les = from l in _context.Lesson
                      where l.Key_Lesson.ToLower().Contains(searchString.ToLower())
                      select l;

            var ans = from item in _context.Exercise
                      from l in les
                      where item.LessonId_Lesson.Equals(l.Id_Lesson)
                      select item;
            return View("Result_exercise", await ans.ToListAsync());
        }
        public async Task<IActionResult> Result_exercise()
        {
            return View(await _context.Exercise.ToListAsync());
        }


        /*Tìm kiếm khái niệm*/
        public async Task<IActionResult> SearchConcept(string searchString)
        {
            ViewData["ss"] = searchString;
            var les = from l in _context.Lesson
                      where l.Key_Lesson.ToLower().Contains(searchString.ToLower())
                      select l;

            var ans = from item in _context.Concept
                      from l in les
                      where item.LessonId_Lesson.Equals(l.Id_Lesson)
                      select item;
            return View("Result_concept", await ans.ToListAsync());
        }
        public async Task<IActionResult> Result_concept()
        {
            return View(await _context.Concept.ToListAsync());
        }

        /*Tìm kiếm cách biểu diễn/ cài đặt*/
        public async Task<IActionResult> SearchConstruct(string searchString)
        {
            ViewData["ss"] = searchString;
            var les = from l in _context.Lesson
                      where l.Key_Lesson.ToLower().Contains(searchString.ToLower())
                      select l;

            var ans = from item in _context.Construct
                      from l in les
                      where item.LessonId_Lesson.Equals(l.Id_Lesson)
                      select item;
            return View("Result_construct", await ans.ToListAsync());
        }
        public async Task<IActionResult> Result_construct()
        {
            return View(await _context.Construct.ToListAsync());
        }

        /*Tìm kiếm toán tử*/
        public async Task<IActionResult> SearchOperator(string searchString)
        {
            ViewData["ss"] = searchString;
            var les = from l in _context.Lesson
                      where l.Key_Lesson.ToLower().Contains(searchString.ToLower())
                      select l;

            var ans = from item in _context.Operator
                           from l in les
                           where item.LessonId_Lesson.Equals(l.Id_Lesson)
                           select item;
            return View("Result_operator", await ans.ToListAsync());

        }
        public async Task<IActionResult> Result_operator()
        {
            return View(await _context.Operator.ToListAsync());
        }

        public IActionResult Result_Multy(string searchString)
        {
            ViewData["ss"] = searchString;
            return View(Result_Something(searchString));
        }

        public List<Result_Lesson> Result_Something(string searchString)
        {
            Result_Lesson reles = new Result_Lesson() { };
            var les = from l in _context.Lesson
                      where l.Key_Lesson.ToLower().Contains(searchString.ToLower())
                      select new
                      {
                          l.Name_Lesson,
                          l.Id_Lesson
                      };

            var les_conc = from cc in _context.Concept
                           from l in les
                           where cc.LessonId_Lesson.Equals(l.Id_Lesson)
                           select new
                           {
                               l.Name_Lesson,
                               l.Id_Lesson,
                               cc.Name_Concept,
                               cc.Link_Concept
                           };

            var les_cons = from cs in _context.Construct
                           from l in les
                           where cs.LessonId_Lesson.Equals(l.Id_Lesson)
                           select new
                           {
                               l.Name_Lesson,
                               l.Id_Lesson,
                               cs.Name_Construct,
                               cs.Link_Construct
                           };

            var les_oper = from op in _context.Operator
                           from l in les
                           where op.LessonId_Lesson.Equals(l.Id_Lesson)
                           select new
                           {
                               l.Name_Lesson,
                               l.Id_Lesson,
                               op.Name_Operator,
                               op.Link_Operator
                           };

            var les_exer = from ex in _context.Exercise
                           from l in les
                           where ex.LessonId_Lesson.Equals(l.Id_Lesson)
                           select new
                           {
                               l.Name_Lesson,
                               l.Id_Lesson,
                               ex.Name_Exercise,
                               ex.Link_Exercise
                           };

            //Construct join in Concept-Lesson
            var leftjoin1 = from lcc in les_conc
                            join lcs in les_cons
                            on lcc.Id_Lesson equals lcs.Id_Lesson into left_1
                            from l_1 in left_1.DefaultIfEmpty()
                            select new
                            {
                                lcc.Name_Lesson,
                                lcc.Id_Lesson,

                                lcc.Name_Concept,
                                lcc.Link_Concept,

                                l_1.Name_Construct,
                                l_1.Link_Construct
                            };

            //Opperator join in leftjoin1
            var leftjoin2 = from left_1 in leftjoin1
                            join loper in les_oper
                            on left_1.Id_Lesson equals loper.Id_Lesson into left_2
                            from l_2 in left_2.DefaultIfEmpty()
                            select new
                            {
                                left_1.Name_Lesson,
                                left_1.Id_Lesson,

                                left_1.Name_Concept,
                                left_1.Link_Concept,

                                left_1.Name_Construct,
                                left_1.Link_Construct,

                                l_2.Name_Operator,
                                l_2.Link_Operator
                            };

            //Exercise join in leftjoin2
            var leftjoin3 = from left_2 in leftjoin2
                            join lexer in les_exer
                            on left_2.Id_Lesson equals lexer.Id_Lesson into left_3
                            from l_3 in left_3.DefaultIfEmpty()
                            select new
                            {
                                left_2.Name_Lesson,
                                left_2.Id_Lesson,

                                left_2.Name_Concept,
                                left_2.Link_Concept,

                                left_2.Name_Construct,
                                left_2.Link_Construct,

                                left_2.Name_Operator,
                                left_2.Link_Operator,

                                l_3.Name_Exercise,
                                l_3.Link_Exercise
                            };
            var result = from all in leftjoin3
                         select new Result_Lesson()
                         {
                             nameLesson = all.Name_Lesson,
                             linkLesson = all.Id_Lesson,

                             nameConcept = all.Name_Concept,
                             linkConcept = all.Link_Concept,

                             nameConstruct = all.Name_Construct,
                             linkConstruct = all.Link_Construct,

                             nameOperator = all.Name_Operator,
                             linkOperator = all.Link_Operator,

                             nameExercise = all.Name_Exercise,
                             linkExercise = all.Link_Exercise
                         };
            return result.ToList();
        }

        //public List<Lesson> Relate(string link)
        //{

        //    var r = from i in _context.Relationship
        //            where i.Id_Lesson_A == link
        //            select i;
        //    var kq = from ls in _context.Lesson
        //             join rel in r on ls.Id_Lesson equals rel.Id_Lesson_B
        //             select ls;

        //    return kq.ToList();
        //}

        public List<Result_Lesson> Relate(string link)
        {

            var rel = from r in _context.Relationship
                      from l in _context.Lesson
                      where l.Id_Lesson.Equals(r.Id_Lesson_A) && l.Id_Lesson.Equals(link)
                      select new
                      {
                          r.Id_Lesson_A,
                          r.Id_Lesson_B,
                          l.Name_Lesson,
                      };

            var les_rel = from l in _context.Lesson
                          from re in rel
                          where l.Id_Lesson.Equals(re.Id_Lesson_B)
                          select new
                          {
                              l.Name_Lesson,
                              l.Id_Lesson
                          };

            var result = from lr in les_rel
                         select new Result_Lesson()
                         {
                             nameRel_Lesson = lr.Name_Lesson,
                             linkRel_Lesson = lr.Id_Lesson
                         };
            return result.ToList();
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
        public IActionResult II()
        {
            return View(Relate("II"));
        }
        public IActionResult II_2()
        {
            return View(Relate("II_2"));
        }
        public IActionResult II_2_1()
        {
            return View(Relate("II_2_1"));
        }
        public IActionResult II_2_2()
        {
            return View(Relate("II_2_2"));
        }
        public IActionResult II_2_3()
        {
            return View(Relate("II_2_3"));
        }
        public IActionResult II_3()
        {
            return View(Relate("II_3"));
        }
        public IActionResult II_3_1()
        {
            return View(Relate("II_3_1"));
        }
        public IActionResult II_3_2()
        {
            return View(Relate("II_3_2"));
        }
        public IActionResult II_3_3()
        {
            return View(Relate("II_3_3"));
        }
        public IActionResult II_3_4()
        {
            return View(Relate("II_3_4"));
        }
        public IActionResult II_3_5()
        {
            return View(Relate("II_3_5"));
        }
        public IActionResult II_4()
        {
            return View(Relate("II_4"));
        }
        public IActionResult II_5()
        {
            return View(Relate("II_5"));
        }
        public IActionResult II_6()
        {
            return View(Relate("II_6"));
        }
        public IActionResult II_7()
        {
            return View(Relate("II_7"));
        }
        public IActionResult III_1()
        {
            return View(Relate("I_2"));
        }
        public IActionResult III_2()
        {
            return View(Relate("I_2#I_2_2"));
        }
        public IActionResult III_3()
        {
            return View(Relate("I_3"));
        }
        public IActionResult III_4()
        {
            return View(Relate("I_4"));
        }
        public IActionResult III_5()
        {
            return View(Relate("I_5"));
        }
        public IActionResult III_6()
        {
            return View(Relate("I_6"));
        }
        public IActionResult III_7()
        {
            return View(Relate("I_7"));
        }
        public IActionResult III_8()
        {
            return View(Relate("II_2"));
        }
        public IActionResult III_9()
        {
            return View(Relate("II_3"));
        }
        public IActionResult III_10()
        {
            return View(Relate("II_4"));
        }
        public IActionResult III_11()
        {
            return View(Relate("II_5"));
        }
        public IActionResult III_12()
        {
            return View(Relate("II_6"));
        }
        public IActionResult III_13()
        {
            return View(Relate("II_7"));
        }
    }
}
