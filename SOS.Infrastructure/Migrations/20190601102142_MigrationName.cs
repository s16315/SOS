using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.Infrastructure.Migrations
{
    public partial class MigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classroom",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classroom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Pesel = table.Column<string>(nullable: true),
                    AddressId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    IsActive = table.Column<short>(nullable: true),
                    RoleId = table.Column<long>(nullable: true),
                    SchoolId = table.Column<long>(nullable: true),
                    Instructor_SchoolId = table.Column<long>(nullable: true),
                    OfficeWorker_SchoolId = table.Column<long>(nullable: true),
                    ToPay = table.Column<float>(nullable: true),
                    Payments = table.Column<float>(nullable: true),
                    Student_SchoolId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_School_Instructor_SchoolId",
                        column: x => x.Instructor_SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_School_OfficeWorker_SchoolId",
                        column: x => x.OfficeWorker_SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_School_Student_SchoolId",
                        column: x => x.Student_SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "YearlyPlan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    Year = table.Column<DateTime>(nullable: false),
                    SchoolId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YearlyPlan_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    InstructorId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Language_Person_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyPlan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    weekInYearNumber = table.Column<int>(nullable: false),
                    YearlyPlanId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeeklyPlan_YearlyPlan_YearlyPlanId",
                        column: x => x.YearlyPlanId,
                        principalTable: "YearlyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    InstructorId = table.Column<long>(nullable: true),
                    MaxStudents = table.Column<int>(nullable: false),
                    Cost = table.Column<float>(nullable: false),
                    LanguageId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Person_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Course_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyPlan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    Day = table.Column<DateTime>(nullable: false),
                    WeeklyPlanId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyPlan_WeeklyPlan_WeeklyPlanId",
                        column: x => x.WeeklyPlanId,
                        principalTable: "WeeklyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    StudentId = table.Column<long>(nullable: true),
                    CourseId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Person_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassroomDailyPlan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    ClassroomId = table.Column<long>(nullable: true),
                    DailyPlanId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassroomDailyPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassroomDailyPlan_Classroom_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classroom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassroomDailyPlan_DailyPlan_DailyPlanId",
                        column: x => x.DailyPlanId,
                        principalTable: "DailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    DateOfUpdate = table.Column<DateTime>(nullable: false),
                    LessonNumber = table.Column<int>(nullable: false),
                    CourseId = table.Column<long>(nullable: true),
                    ReplacementId = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId1 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId10 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId11 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId12 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId13 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId2 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId3 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId4 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId5 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId6 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId7 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId8 = table.Column<long>(nullable: true),
                    ClassroomDailyPlanId9 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId",
                        column: x => x.ClassroomDailyPlanId,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId1",
                        column: x => x.ClassroomDailyPlanId1,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId10",
                        column: x => x.ClassroomDailyPlanId10,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId11",
                        column: x => x.ClassroomDailyPlanId11,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId12",
                        column: x => x.ClassroomDailyPlanId12,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId13",
                        column: x => x.ClassroomDailyPlanId13,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId2",
                        column: x => x.ClassroomDailyPlanId2,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId3",
                        column: x => x.ClassroomDailyPlanId3,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId4",
                        column: x => x.ClassroomDailyPlanId4,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId5",
                        column: x => x.ClassroomDailyPlanId5,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId6",
                        column: x => x.ClassroomDailyPlanId6,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId7",
                        column: x => x.ClassroomDailyPlanId7,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId8",
                        column: x => x.ClassroomDailyPlanId8,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_ClassroomDailyPlan_ClassroomDailyPlanId9",
                        column: x => x.ClassroomDailyPlanId9,
                        principalTable: "ClassroomDailyPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_Person_ReplacementId",
                        column: x => x.ReplacementId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassroomDailyPlan_ClassroomId",
                table: "ClassroomDailyPlan",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassroomDailyPlan_DailyPlanId",
                table: "ClassroomDailyPlan",
                column: "DailyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_InstructorId",
                table: "Course",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_LanguageId",
                table: "Course",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyPlan_WeeklyPlanId",
                table: "DailyPlan",
                column: "WeeklyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Language_InstructorId",
                table: "Language",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId",
                table: "Lesson",
                column: "ClassroomDailyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId1",
                table: "Lesson",
                column: "ClassroomDailyPlanId1");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId10",
                table: "Lesson",
                column: "ClassroomDailyPlanId10");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId11",
                table: "Lesson",
                column: "ClassroomDailyPlanId11");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId12",
                table: "Lesson",
                column: "ClassroomDailyPlanId12");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId13",
                table: "Lesson",
                column: "ClassroomDailyPlanId13");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId2",
                table: "Lesson",
                column: "ClassroomDailyPlanId2");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId3",
                table: "Lesson",
                column: "ClassroomDailyPlanId3");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId4",
                table: "Lesson",
                column: "ClassroomDailyPlanId4");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId5",
                table: "Lesson",
                column: "ClassroomDailyPlanId5");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId6",
                table: "Lesson",
                column: "ClassroomDailyPlanId6");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId7",
                table: "Lesson",
                column: "ClassroomDailyPlanId7");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId8",
                table: "Lesson",
                column: "ClassroomDailyPlanId8");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomDailyPlanId9",
                table: "Lesson",
                column: "ClassroomDailyPlanId9");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_CourseId",
                table: "Lesson",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ReplacementId",
                table: "Lesson",
                column: "ReplacementId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_SchoolId",
                table: "Person",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Instructor_SchoolId",
                table: "Person",
                column: "Instructor_SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_OfficeWorker_SchoolId",
                table: "Person",
                column: "OfficeWorker_SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_AddressId",
                table: "Person",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Student_SchoolId",
                table: "Person",
                column: "Student_SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RoleId",
                table: "Person",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_CourseId",
                table: "StudentsCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_StudentId",
                table: "StudentsCourses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyPlan_YearlyPlanId",
                table: "WeeklyPlan",
                column: "YearlyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_YearlyPlan_SchoolId",
                table: "YearlyPlan",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "StudentsCourses");

            migrationBuilder.DropTable(
                name: "ClassroomDailyPlan");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Classroom");

            migrationBuilder.DropTable(
                name: "DailyPlan");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "WeeklyPlan");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "YearlyPlan");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "School");
        }
    }
}
