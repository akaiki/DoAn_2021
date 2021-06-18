using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManage.Models
{
    public class Result_Lesson
    {
        public string nameLesson { get; set; }
        public string linkLesson { get; set; }
        public string nameRel_Lesson { get; set; }
        public string linkRel_Lesson { get; set; }
        public string nameConcept { get; set; }
        public string linkConcept { get; set; }

        public string nameConstruct { get; set; }
        public string linkConstruct { get; set; }

        public string nameOperator { get; set; }
        public string linkOperator { get; set; }

        public string nameExercise { get; set; }
        public string linkExercise { get; set; }
    }
}
