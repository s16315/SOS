﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SOS.Infrastructure.Context;

namespace SOS.Infrastructure.Migrations
{
    [DbContext(typeof(SOSContext))]
    [Migration("20190601162029_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("SOS.Infrastructure.Model.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Classroom", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Classroom");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.ClassroomDailyPlan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<long?>("ClassroomId");

                    b.Property<long?>("DailyPlanId");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("DailyPlanId");

                    b.ToTable("ClassroomDailyPlan");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<float>("Cost");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<long?>("InstructorId");

                    b.Property<long?>("LanguageId");

                    b.Property<int>("MaxStudents");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.DailyPlan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<DateTime>("Day");

                    b.Property<long?>("WeeklyPlanId");

                    b.HasKey("Id");

                    b.HasIndex("WeeklyPlanId");

                    b.ToTable("DailyPlan");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Language", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<long?>("InstructorId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Lesson", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<long?>("ClassroomDailyPlanId");

                    b.Property<long?>("ClassroomDailyPlanId1");

                    b.Property<long?>("ClassroomDailyPlanId10");

                    b.Property<long?>("ClassroomDailyPlanId11");

                    b.Property<long?>("ClassroomDailyPlanId12");

                    b.Property<long?>("ClassroomDailyPlanId13");

                    b.Property<long?>("ClassroomDailyPlanId2");

                    b.Property<long?>("ClassroomDailyPlanId3");

                    b.Property<long?>("ClassroomDailyPlanId4");

                    b.Property<long?>("ClassroomDailyPlanId5");

                    b.Property<long?>("ClassroomDailyPlanId6");

                    b.Property<long?>("ClassroomDailyPlanId7");

                    b.Property<long?>("ClassroomDailyPlanId8");

                    b.Property<long?>("ClassroomDailyPlanId9");

                    b.Property<long?>("CourseId");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<int>("LessonNumber");

                    b.Property<long?>("ReplacementId");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomDailyPlanId");

                    b.HasIndex("ClassroomDailyPlanId1");

                    b.HasIndex("ClassroomDailyPlanId10");

                    b.HasIndex("ClassroomDailyPlanId11");

                    b.HasIndex("ClassroomDailyPlanId12");

                    b.HasIndex("ClassroomDailyPlanId13");

                    b.HasIndex("ClassroomDailyPlanId2");

                    b.HasIndex("ClassroomDailyPlanId3");

                    b.HasIndex("ClassroomDailyPlanId4");

                    b.HasIndex("ClassroomDailyPlanId5");

                    b.HasIndex("ClassroomDailyPlanId6");

                    b.HasIndex("ClassroomDailyPlanId7");

                    b.HasIndex("ClassroomDailyPlanId8");

                    b.HasIndex("ClassroomDailyPlanId9");

                    b.HasIndex("CourseId");

                    b.HasIndex("ReplacementId");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AddressId");

                    b.Property<bool>("Available");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Pesel");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.School", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("School");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.StudentCourse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<long?>("CourseId");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<long?>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentsCourses");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.WeeklyPlan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<long?>("YearlyPlanId");

                    b.Property<int>("weekInYearNumber");

                    b.HasKey("Id");

                    b.HasIndex("YearlyPlanId");

                    b.ToTable("WeeklyPlan");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.YearlyPlan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<DateTime>("DateOfCreation");

                    b.Property<DateTime>("DateOfUpdate");

                    b.Property<long?>("SchoolId");

                    b.Property<DateTime>("Year");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("YearlyPlan");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.User", b =>
                {
                    b.HasBaseType("SOS.Infrastructure.Model.Person");

                    b.Property<bool>("IsActive");

                    b.Property<string>("PasswordHash");

                    b.Property<long?>("RoleId");

                    b.Property<string>("Username");

                    b.HasIndex("RoleId");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Administrator", b =>
                {
                    b.HasBaseType("SOS.Infrastructure.Model.User");

                    b.Property<long?>("SchoolId");

                    b.HasIndex("SchoolId");

                    b.HasDiscriminator().HasValue("Administrator");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Instructor", b =>
                {
                    b.HasBaseType("SOS.Infrastructure.Model.User");

                    b.Property<long?>("SchoolId")
                        .HasColumnName("Instructor_SchoolId");

                    b.HasIndex("SchoolId");

                    b.HasDiscriminator().HasValue("Instructor");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.OfficeWorker", b =>
                {
                    b.HasBaseType("SOS.Infrastructure.Model.User");

                    b.Property<long?>("SchoolId")
                        .HasColumnName("OfficeWorker_SchoolId");

                    b.HasIndex("SchoolId");

                    b.HasDiscriminator().HasValue("OfficeWorker");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Student", b =>
                {
                    b.HasBaseType("SOS.Infrastructure.Model.User");

                    b.Property<float>("Payments");

                    b.Property<long?>("SchoolId")
                        .HasColumnName("Student_SchoolId");

                    b.Property<float>("ToPay");

                    b.HasIndex("SchoolId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.ClassroomDailyPlan", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.Classroom", "Classroom")
                        .WithMany()
                        .HasForeignKey("ClassroomId");

                    b.HasOne("SOS.Infrastructure.Model.DailyPlan")
                        .WithMany("ClassroomsDailyPlan")
                        .HasForeignKey("DailyPlanId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Course", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId");

                    b.HasOne("SOS.Infrastructure.Model.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.DailyPlan", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.WeeklyPlan")
                        .WithMany("DailyPlans")
                        .HasForeignKey("WeeklyPlanId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Language", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.Instructor")
                        .WithMany("Languages")
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Lesson", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur08")
                        .HasForeignKey("ClassroomDailyPlanId");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur09")
                        .HasForeignKey("ClassroomDailyPlanId1");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur18")
                        .HasForeignKey("ClassroomDailyPlanId10");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur19")
                        .HasForeignKey("ClassroomDailyPlanId11");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur20")
                        .HasForeignKey("ClassroomDailyPlanId12");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur21")
                        .HasForeignKey("ClassroomDailyPlanId13");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur10")
                        .HasForeignKey("ClassroomDailyPlanId2");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur11")
                        .HasForeignKey("ClassroomDailyPlanId3");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur12")
                        .HasForeignKey("ClassroomDailyPlanId4");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur13")
                        .HasForeignKey("ClassroomDailyPlanId5");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur14")
                        .HasForeignKey("ClassroomDailyPlanId6");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur15")
                        .HasForeignKey("ClassroomDailyPlanId7");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur16")
                        .HasForeignKey("ClassroomDailyPlanId8");

                    b.HasOne("SOS.Infrastructure.Model.ClassroomDailyPlan")
                        .WithMany("haur17")
                        .HasForeignKey("ClassroomDailyPlanId9");

                    b.HasOne("SOS.Infrastructure.Model.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("SOS.Infrastructure.Model.Instructor", "Replacement")
                        .WithMany()
                        .HasForeignKey("ReplacementId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Person", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.StudentCourse", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("SOS.Infrastructure.Model.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.WeeklyPlan", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.YearlyPlan")
                        .WithMany("WeeklyPlans")
                        .HasForeignKey("YearlyPlanId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.YearlyPlan", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.School")
                        .WithMany("Schedule")
                        .HasForeignKey("SchoolId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.User", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Administrator", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.School")
                        .WithMany("Administrators")
                        .HasForeignKey("SchoolId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Instructor", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.School")
                        .WithMany("Instructors")
                        .HasForeignKey("SchoolId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.OfficeWorker", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.School")
                        .WithMany("OfficeWorkers")
                        .HasForeignKey("SchoolId");
                });

            modelBuilder.Entity("SOS.Infrastructure.Model.Student", b =>
                {
                    b.HasOne("SOS.Infrastructure.Model.School")
                        .WithMany("Students")
                        .HasForeignKey("SchoolId");
                });
#pragma warning restore 612, 618
        }
    }
}
