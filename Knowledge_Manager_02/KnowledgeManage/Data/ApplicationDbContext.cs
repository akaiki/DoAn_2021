using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KnowledgeManage.Models;

namespace KnowledgeManage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<KnowledgeManage.Models.Knowledge> Knowledge { get; set; }

        public DbSet<KnowledgeManage.Models.Relationship> Relationship { get; set; }

        public DbSet<KnowledgeManage.Models.Chapter> Chapter { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Relationship>()
                        .HasOne(m => m.Knowledge_A)
                        .WithMany(t => t.Relationship_Knowledge_A)
                        .HasForeignKey(m => m.Id_Knowledge_A)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Relationship>()
                        .HasOne(m => m.Knowledge_B)
                        .WithMany(t => t.Relationship_Knowledge_B)
                        .HasForeignKey(m => m.Id_Knowledge_B)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
