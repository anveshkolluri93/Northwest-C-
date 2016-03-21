using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Team01Project01.Migrations
{
    public partial class iniiii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Schedule_Faculty_FacultyFacultyId", table: "Schedule");
            migrationBuilder.DropColumn(name: "FacultyFacultyId", table: "Schedule");
            migrationBuilder.AlterColumn<int>(
                name: "ScheduleId",
                table: "Students",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "CoursesId",
                table: "Students",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Schedule",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Schedule",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "Schedule",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "CoursesId",
                table: "Schedule",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Faculty_FacultyId",
                table: "Schedule",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Schedule_Faculty_FacultyId", table: "Schedule");
            migrationBuilder.AlterColumn<int>(
                name: "ScheduleId",
                table: "Students",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "CoursesId",
                table: "Students",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Schedule",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Schedule",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "FacultyId",
                table: "Schedule",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "CoursesId",
                table: "Schedule",
                nullable: false);
            migrationBuilder.AddColumn<int>(
                name: "FacultyFacultyId",
                table: "Schedule",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Faculty_FacultyFacultyId",
                table: "Schedule",
                column: "FacultyFacultyId",
                principalTable: "Faculty",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
