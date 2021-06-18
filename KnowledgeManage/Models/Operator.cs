using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManage.Models
{
    public class Operator
    {
        [Key]
        public int Id_Operator { get; set; }
        public string Link_Operator { get; set; }
        public string Name_Operator { get; set; }
        public string LessonId_Lesson { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
