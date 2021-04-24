using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManage.Models
{
    public class Knowledge
    {
        [Key]
        public string Id_Knowledge { get; set; }
        public string Id_PreKnowledge { get; set; }
        public string Name_Knowledge { get; set; }
        public string Key_Knowledge { get; set; }
        public string Link_Knowledge { get; set; }

        public virtual Chapter Chapter { get; set; } //This is foreign key

        public ICollection<Relationship> Relationship_Knowledge_A { get; set; }

        public ICollection<Relationship> Relationship_Knowledge_B { get; set; }

        public Knowledge()
        {

        }
    }
}
