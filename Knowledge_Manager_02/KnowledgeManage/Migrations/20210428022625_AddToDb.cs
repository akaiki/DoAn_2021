using Microsoft.EntityFrameworkCore.Migrations;

namespace KnowledgeManage.Migrations
{
    public partial class AddToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id_Lesson = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_PreLesson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_Lesson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id_Lesson);
                });

            migrationBuilder.CreateTable(
                name: "Concept",
                columns: table => new
                {
                    Id_Concept = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link_Concept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_Concept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonId_Lesson = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concept", x => x.Id_Concept);
                    table.ForeignKey(
                        name: "FK_Concept_Lesson_LessonId_Lesson",
                        column: x => x.LessonId_Lesson,
                        principalTable: "Lesson",
                        principalColumn: "Id_Lesson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Construct",
                columns: table => new
                {
                    Id_Construct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link_Construct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_Construct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonId_Lesson = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Construct", x => x.Id_Construct);
                    table.ForeignKey(
                        name: "FK_Construct_Lesson_LessonId_Lesson",
                        column: x => x.LessonId_Lesson,
                        principalTable: "Lesson",
                        principalColumn: "Id_Lesson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id_Exercise = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link_Exercise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_Exercise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonId_Lesson = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id_Exercise);
                    table.ForeignKey(
                        name: "FK_Exercise_Lesson_LessonId_Lesson",
                        column: x => x.LessonId_Lesson,
                        principalTable: "Lesson",
                        principalColumn: "Id_Lesson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Operator",
                columns: table => new
                {
                    Id_Operator = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link_Operator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_Operator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonId_Lesson = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operator", x => x.Id_Operator);
                    table.ForeignKey(
                        name: "FK_Operator_Lesson_LessonId_Lesson",
                        column: x => x.LessonId_Lesson,
                        principalTable: "Lesson",
                        principalColumn: "Id_Lesson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id_Property = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link_Property = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_Property = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonId_Lesson = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id_Property);
                    table.ForeignKey(
                        name: "FK_Property_Lesson_LessonId_Lesson",
                        column: x => x.LessonId_Lesson,
                        principalTable: "Lesson",
                        principalColumn: "Id_Lesson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Relationship",
                columns: table => new
                {
                    Id_Relationship = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Lesson_A = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id_Lesson_B = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.Id_Relationship);
                    table.ForeignKey(
                        name: "FK_Relationship_Lesson_Id_Lesson_A",
                        column: x => x.Id_Lesson_A,
                        principalTable: "Lesson",
                        principalColumn: "Id_Lesson",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relationship_Lesson_Id_Lesson_B",
                        column: x => x.Id_Lesson_B,
                        principalTable: "Lesson",
                        principalColumn: "Id_Lesson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Concept_LessonId_Lesson",
                table: "Concept",
                column: "LessonId_Lesson");

            migrationBuilder.CreateIndex(
                name: "IX_Construct_LessonId_Lesson",
                table: "Construct",
                column: "LessonId_Lesson");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_LessonId_Lesson",
                table: "Exercise",
                column: "LessonId_Lesson");

            migrationBuilder.CreateIndex(
                name: "IX_Operator_LessonId_Lesson",
                table: "Operator",
                column: "LessonId_Lesson");

            migrationBuilder.CreateIndex(
                name: "IX_Property_LessonId_Lesson",
                table: "Property",
                column: "LessonId_Lesson");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_Id_Lesson_A",
                table: "Relationship",
                column: "Id_Lesson_A");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_Id_Lesson_B",
                table: "Relationship",
                column: "Id_Lesson_B");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Concept");

            migrationBuilder.DropTable(
                name: "Construct");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Operator");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropTable(
                name: "Lesson");
        }
    }
}
