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
        public string Id_Relationship { get; set; }
        public string Id_Knowledge_A { get; set; }
        public string Id_Knowledge_B { get; set; }


        [ForeignKey("ID_Knowledge_A")]
        public virtual Knowledge Knowledge_A { get; set; }
        [ForeignKey("ID_Knowledge_B")]
        public virtual Knowledge Knowledge_B { get; set; }

        public Relationship()
        {

        }
    }
}
