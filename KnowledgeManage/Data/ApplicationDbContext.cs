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

        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Relationship> Relationship { get; set; }
        public DbSet<Concept> Concept { get; set; }
        public DbSet<Construct> Construct { get; set; }
        public DbSet<Operator> Operator { get; set; }
        public DbSet<Exercise> Exercise { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Relationship>()
                        .HasOne(m => m.Lesson_A)
                        .WithMany(t => t.Relationship_Lesson_A)
                        .HasForeignKey(m => m.Id_Lesson_A)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Relationship>()
                        .HasOne(m => m.Lesson_B)
                        .WithMany(t => t.Relationship_Lesson_B)
                        .HasForeignKey(m => m.Id_Lesson_B)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
