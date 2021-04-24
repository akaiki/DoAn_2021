using Microsoft.EntityFrameworkCore.Migrations;

namespace KnowledgeManage.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    Id_Chap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name_Chap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key_Chap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link_Chap = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.Id_Chap);
                });

            migrationBuilder.CreateTable(
                name: "Knowledge",
                columns: table => new
                {
                    Id_Knowledge = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_PreKnowledge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_Knowledge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key_Knowledge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link_Knowledge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterId_Chap = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledge", x => x.Id_Knowledge);
                    table.ForeignKey(
                        name: "FK_Knowledge_Chapter_ChapterId_Chap",
                        column: x => x.ChapterId_Chap,
                        principalTable: "Chapter",
                        principalColumn: "Id_Chap",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Relationship",
                columns: table => new
                {
                    Id_Relationship = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_Knowledge_A = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id_Knowledge_B = table.Column<string>(type: "nvarchar(450)", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.Id_Relationship);
                    table.ForeignKey(
                        name: "FK_Relationship_Knowledge_Id_Knowledge_A",
                        column: x => x.Id_Knowledge_A,
                        principalTable: "Knowledge",
                        principalColumn: "Id_Knowledge",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relationship_Knowledge_Id_Knowledge_B",
                        column: x => x.Id_Knowledge_B,
                        principalTable: "Knowledge",
                        principalColumn: "Id_Knowledge",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Knowledge_ChapterId_Chap",
                table: "Knowledge",
                column: "ChapterId_Chap");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_Id_Knowledge_A",
                table: "Relationship",
                column: "Id_Knowledge_A");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_Id_Knowledge_B",
                table: "Relationship",
                column: "Id_Knowledge_B");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropTable(
                name: "Knowledge");

            migrationBuilder.DropTable(
                name: "Chapter");
        }
    }
}
