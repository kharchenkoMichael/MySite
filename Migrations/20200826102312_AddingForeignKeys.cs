using Microsoft.EntityFrameworkCore.Migrations;

namespace MySite.Migrations
{
    public partial class AddingForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Tests_ExerciseId",
                table: "Tests",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_LessonId",
                table: "Exercises",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComponents_BlogId",
                table: "BlogComponents",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComponents_Blogs_BlogId",
                table: "BlogComponents",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Lessons_LessonId",
                table: "Exercises",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Exercises_ExerciseId",
                table: "Tests",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComponents_Blogs_BlogId",
                table: "BlogComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Lessons_LessonId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Exercises_ExerciseId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_ExerciseId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_LessonId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_BlogComponents_BlogId",
                table: "BlogComponents");
        }
    }
}
