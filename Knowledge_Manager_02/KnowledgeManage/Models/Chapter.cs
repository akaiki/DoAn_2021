using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManage.Models
{
    public class Chapter
    {
        [Key]
        public string Id_Chap { get; set; }
        public string Name_Chap { get; set; }
        public string Key_Chap { get; set; }
        public string Link_Chap { get; set; }


        public ICollection<Knowledge> Knowledge { get; set; }
        public Chapter()
        {

        }
    }
}
