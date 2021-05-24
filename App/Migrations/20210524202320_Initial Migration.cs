using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Classification = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CourseName = table.Column<string>(type: "TEXT", nullable: true),
                    CourseGrade = table.Column<float>(type: "REAL", nullable: false),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 1, 13, 0, "Samiel", "Jacobs" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 2, 16, 2, "Sarah", "Vega" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 3, 18, 3, "Mark", "Plier" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 4, 14, 1, "Audrey", "White" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 5, 14, 0, "Andrew", "Neuton" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 6, 17, 1, "Thomas", "Reetin" });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseGrade", "CourseName", "StudentId" },
                values: new object[] { 1, 87.7f, "Geometry 102", 1 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseGrade", "CourseName", "StudentId" },
                values: new object[] { 2, 98.7f, "Art 201", 1 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseGrade", "CourseName", "StudentId" },
                values: new object[] { 3, 100f, "Chemistry 301", 1 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseGrade", "CourseName", "StudentId" },
                values: new object[] { 4, 82.6f, "English 102", 1 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseGrade", "CourseName", "StudentId" },
                values: new object[] { 5, 99.2f, "Chemistry 301", 2 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseGrade", "CourseName", "StudentId" },
                values: new object[] { 6, 70.2f, "Art 201", 2 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseGrade", "CourseName", "StudentId" },
                values: new object[] { 7, 93.5f, "English 102", 3 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseGrade", "CourseName", "StudentId" },
                values: new object[] { 8, 100f, "Art 301", 3 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseGrade", "CourseName", "StudentId" },
                values: new object[] { 9, 65f, "Art 301", 4 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseGrade", "CourseName", "StudentId" },
                values: new object[] { 10, 88.8f, "Precalculus 301", 6 });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
