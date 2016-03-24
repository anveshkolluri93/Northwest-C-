using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Team01Project01.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CoursesId = table.Column<int>(nullable: false),
                    courseName = table.Column<string>(nullable: true),
                    credits = table.Column<int>(nullable: false),
                    duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CoursesId);
                });
            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FacultyId = table.Column<int>(nullable: false),
                    FirstMidName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.FacultyId);
                });
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false),
                    buildingId = table.Column<string>(nullable: true),
                    roomNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentsId = table.Column<int>(nullable: false),
                    CoursesId = table.Column<int>(nullable: false),
                    FirstMidName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentsId);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "CoursesId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    SectionId = table.Column<int>(nullable: false),
                    CoursesId = table.Column<int>(nullable: false),
                    FacultyId = table.Column<int>(nullable: false),
                    capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.SectionId);
                    table.ForeignKey(
                        name: "FK_Section_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "CoursesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Section_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(nullable: false),
                    CoursesId = table.Column<int>(nullable: false),
                    FacultyId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedule_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "CoursesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedule_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedule_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Schedule");
            migrationBuilder.DropTable("Section");
            migrationBuilder.DropTable("Students");
            migrationBuilder.DropTable("Location");
            migrationBuilder.DropTable("Faculty");
            migrationBuilder.DropTable("Courses");
        }
    }
}
