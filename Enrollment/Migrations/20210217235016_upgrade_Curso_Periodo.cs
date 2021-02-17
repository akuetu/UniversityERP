using Microsoft.EntityFrameworkCore.Migrations;

namespace Enrollment.Migrations
{
    public partial class upgrade_Curso_Periodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PeriodId",
                table: "CoursePeriod",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CoursePeriod",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePeriod_CourseId",
                table: "CoursePeriod",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePeriod_PeriodId",
                table: "CoursePeriod",
                column: "PeriodId");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursePeriod_Courses_CourseId",
                table: "CoursePeriod",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CoursePeriod_Periods_PeriodId",
                table: "CoursePeriod",
                column: "PeriodId",
                principalTable: "Periods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoursePeriod_Courses_CourseId",
                table: "CoursePeriod");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursePeriod_Periods_PeriodId",
                table: "CoursePeriod");

            migrationBuilder.DropIndex(
                name: "IX_CoursePeriod_CourseId",
                table: "CoursePeriod");

            migrationBuilder.DropIndex(
                name: "IX_CoursePeriod_PeriodId",
                table: "CoursePeriod");

            migrationBuilder.AlterColumn<int>(
                name: "PeriodId",
                table: "CoursePeriod",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CoursePeriod",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
