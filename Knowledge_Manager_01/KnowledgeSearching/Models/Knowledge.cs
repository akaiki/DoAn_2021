using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeSearching.Models
{
    public class Knowledge
    {
        [Key]
        public string ID { get; set; }
        public string Title { get; set; }
        public string KeyWords { get; set; }
        public string Link { get; set; }


        public Knowledge()
        {

        }
    }
}
