﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManage.Models
{
    public class Exercise
    {
        [Key]
        public int Id_Exercise { get; set; }
        public string Link_Exercise { get; set; }
        public string Name_Exercise { get; set; }
        public string Id_Lesson { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
