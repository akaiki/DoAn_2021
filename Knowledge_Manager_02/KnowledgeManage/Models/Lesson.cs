using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManage.Models
{
    public class Lesson
    {
        [Key]
        public string Id_Lesson { get; set; }
        public string Name_Lesson { get; set; }

        public ICollection<Relationship> Relationship_Lesson_A { get; set; }

        public ICollection<Relationship> Relationship_Lesson_B { get; set; }

        public ICollection<Concept> Concept { get; set; }
        public ICollection<Construct> Construct { get; set; }
        public ICollection<Operator> Operator { get; set; }
        public ICollection<Exercise> Exercise { get; set; }

        public Lesson()
        {

        }
    }
}
