﻿// <auto-generated />
using KnowledgeManage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KnowledgeManage.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210428022625_AddToDb")]
    partial class AddToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KnowledgeManage.Models.Concept", b =>
                {
                    b.Property<int>("Id_Concept")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LessonId_Lesson")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Link_Concept")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Concept")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Concept");

                    b.HasIndex("LessonId_Lesson");

                    b.ToTable("Concept");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Construct", b =>
                {
                    b.Property<int>("Id_Construct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LessonId_Lesson")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Link_Construct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Construct")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Construct");

                    b.HasIndex("LessonId_Lesson");

                    b.ToTable("Construct");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Exercise", b =>
                {
                    b.Property<int>("Id_Exercise")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LessonId_Lesson")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Link_Exercise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Exercise")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Exercise");

                    b.HasIndex("LessonId_Lesson");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Lesson", b =>
                {
                    b.Property<string>("Id_Lesson")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_PreLesson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Lesson")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Lesson");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Operator", b =>
                {
                    b.Property<int>("Id_Operator")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LessonId_Lesson")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Link_Operator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Operator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Operator");

                    b.HasIndex("LessonId_Lesson");

                    b.ToTable("Operator");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Property", b =>
                {
                    b.Property<int>("Id_Property")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LessonId_Lesson")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Link_Property")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Property")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Property");

                    b.HasIndex("LessonId_Lesson");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Relationship", b =>
                {
                    b.Property<int>("Id_Relationship")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Id_Lesson_A")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id_Lesson_B")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id_Relationship");

                    b.HasIndex("Id_Lesson_A");

                    b.HasIndex("Id_Lesson_B");

                    b.ToTable("Relationship");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Concept", b =>
                {
                    b.HasOne("KnowledgeManage.Models.Lesson", "Lesson")
                        .WithMany("Concept")
                        .HasForeignKey("LessonId_Lesson");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Construct", b =>
                {
                    b.HasOne("KnowledgeManage.Models.Lesson", "Lesson")
                        .WithMany("Construct")
                        .HasForeignKey("LessonId_Lesson");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Exercise", b =>
                {
                    b.HasOne("KnowledgeManage.Models.Lesson", "Lesson")
                        .WithMany("Exercise")
                        .HasForeignKey("LessonId_Lesson");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Operator", b =>
                {
                    b.HasOne("KnowledgeManage.Models.Lesson", "Lesson")
                        .WithMany("Operator")
                        .HasForeignKey("LessonId_Lesson");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Property", b =>
                {
                    b.HasOne("KnowledgeManage.Models.Lesson", "Lesson")
                        .WithMany("Property")
                        .HasForeignKey("LessonId_Lesson");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Relationship", b =>
                {
                    b.HasOne("KnowledgeManage.Models.Lesson", "Lesson_A")
                        .WithMany("Relationship_Lesson_A")
                        .HasForeignKey("Id_Lesson_A")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("KnowledgeManage.Models.Lesson", "Lesson_B")
                        .WithMany("Relationship_Lesson_B")
                        .HasForeignKey("Id_Lesson_B")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Lesson_A");

                    b.Navigation("Lesson_B");
                });

            modelBuilder.Entity("KnowledgeManage.Models.Lesson", b =>
                {
                    b.Navigation("Concept");

                    b.Navigation("Construct");

                    b.Navigation("Exercise");

                    b.Navigation("Operator");

                    b.Navigation("Property");

                    b.Navigation("Relationship_Lesson_A");

                    b.Navigation("Relationship_Lesson_B");
                });
#pragma warning restore 612, 618
        }
    }
}
