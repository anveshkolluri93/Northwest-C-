using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Team01Project01.Migrations
{
    public partial class ijjjj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Schedule_Courses_CoursesId", table: "Schedule");
            migrationBuilder.DropForeignKey(name: "FK_Schedule_Location_LocationId", table: "Schedule");
            migrationBuilder.DropForeignKey(name: "FK_Schedule_Section_SectionId", table: "Schedule");
            migrationBuilder.DropForeignKey(name: "FK_Students_Courses_CoursesId", table: "Students");
            migrationBuilder.DropForeignKey(name: "FK_Students_Schedule_ScheduleId", table: "Students");
            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "Section",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Courses_CoursesId",
                table: "Schedule",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "CoursesId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Location_LocationId",
                table: "Schedule",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Section_SectionId",
                table: "Schedule",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CoursesId",
                table: "Students",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "CoursesId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schedule_ScheduleId",
                table: "Students",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "ScheduleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Schedule_Courses_CoursesId", table: "Schedule");
            migrationBuilder.DropForeignKey(name: "FK_Schedule_Location_LocationId", table: "Schedule");
            migrationBuilder.DropForeignKey(name: "FK_Schedule_Section_SectionId", table: "Schedule");
            migrationBuilder.DropForeignKey(name: "FK_Students_Courses_CoursesId", table: "Students");
            migrationBuilder.DropForeignKey(name: "FK_Students_Schedule_ScheduleId", table: "Students");
            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "Section",
                nullable: false);
            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Courses_CoursesId",
                table: "Schedule",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "CoursesId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Location_LocationId",
                table: "Schedule",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Section_SectionId",
                table: "Schedule",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CoursesId",
                table: "Students",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "CoursesId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schedule_ScheduleId",
                table: "Students",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "ScheduleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
