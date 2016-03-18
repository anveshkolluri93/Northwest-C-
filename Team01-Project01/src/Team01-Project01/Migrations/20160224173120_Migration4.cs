using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Team01Project01.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    courseId = table.Column<int>(nullable: false),
                    courseName = table.Column<string>(nullable: true),
                    credits = table.Column<double>(nullable: false),
                    duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.courseId);
                });
            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    facultyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstMidName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.facultyId);
                });
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    locationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Longitude = table.Column<double>(nullable: false),
                    buildingId = table.Column<string>(nullable: false),
                    roomNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.locationId);
                });
            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleNumber = table.Column<int>(nullable: false),
                    courseId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    facultyId = table.Column<string>(nullable: false),
                    locationId = table.Column<int>(nullable: false),
                    sectionId = table.Column<int>(nullable: false),
                    studentId = table.Column<string>(nullable: true),
                    time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleNumber);
                });
            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    sectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    capacity = table.Column<int>(nullable: false),
                    courseId = table.Column<string>(nullable: true),
                    facultyId = table.Column<string>(nullable: true),
                    locationId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.sectionId);
                });
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentId = table.Column<int>(nullable: false),
                    CRN = table.Column<string>(nullable: true),
                    CourseId = table.Column<string>(nullable: true),
                    FirstMidName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Courses");
            migrationBuilder.DropTable("Faculty");
            migrationBuilder.DropTable("Location");
            migrationBuilder.DropTable("Schedule");
            migrationBuilder.DropTable("Section");
            migrationBuilder.DropTable("Students");
        }
    }
}
