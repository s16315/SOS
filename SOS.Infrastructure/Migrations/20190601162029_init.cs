using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Classroom",
                newName: "Name");

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "YearlyPlan",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "WeeklyPlan",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "StudentsCourses",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "School",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "Role",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "Person",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "Lesson",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "Language",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "DailyPlan",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "Course",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "ClassroomDailyPlan",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "Classroom",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Available",
                table: "Address",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "YearlyPlan");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "WeeklyPlan");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "StudentsCourses");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "School");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "DailyPlan");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "ClassroomDailyPlan");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Classroom");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Classroom",
                newName: "name");
        }
    }
}
