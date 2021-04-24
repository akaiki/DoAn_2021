using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KnowledgeSearching.Models;

namespace KnowledgeSearching.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<KnowledgeSearching.Models.Knowledge> Knowledge { get; set; }
    }
}
