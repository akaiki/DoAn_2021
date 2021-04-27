using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManage.Models
{
    public class Relationship
    {
        [Key]
        public int Id_Relationship { get; set; }
        public string Id_Lesson_A { get; set; }
        public string Id_Lesson_B { get; set; }


        [ForeignKey("ID_Lesson_A")]
        public virtual Lesson Lesson_A { get; set; }
        [ForeignKey("ID_Lesson_B")]
        public virtual Lesson Lesson_B { get; set; }

        public Relationship()
        {

        }
    }
}
