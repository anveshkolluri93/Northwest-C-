using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Team01Project01.Migrations
{
    public partial class ii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Section_Courses_CoursesCoursesId", table: "Section");
            migrationBuilder.DropForeignKey(name: "FK_Section_Faculty_FacultyFacultyId", table: "Section");
            migrationBuilder.DropForeignKey(name: "FK_Section_Location_LocationLocationId", table: "Section");
            migrationBuilder.DropColumn(name: "CoursesCoursesId", table: "Section");
            migrationBuilder.DropColumn(name: "FacultyFacultyId", table: "Section");
            migrationBuilder.DropColumn(name: "LocationLocationId", table: "Section");
            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Section",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "Section",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "CoursesID",
                table: "Section",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Section",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "ScheduleId",
                table: "Schedule",
                nullable: false);
            migrationBuilder.AddForeignKey(
                name: "FK_Section_Courses_CoursesID",
                table: "Section",
                column: "CoursesID",
                principalTable: "Courses",
                principalColumn: "CoursesId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Section_Faculty_FacultyId",
                table: "Section",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Section_Location_LocationId",
                table: "Section",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Section_Courses_CoursesID", table: "Section");
            migrationBuilder.DropForeignKey(name: "FK_Section_Faculty_FacultyId", table: "Section");
            migrationBuilder.DropForeignKey(name: "FK_Section_Location_LocationId", table: "Section");
            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "Section",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "FacultyId",
                table: "Section",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CoursesID",
                table: "Section",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Section",
                nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            migrationBuilder.AddColumn<int>(
                name: "CoursesCoursesId",
                table: "Section",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "FacultyFacultyId",
                table: "Section",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "LocationLocationId",
                table: "Section",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "ScheduleId",
                table: "Schedule",
                nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            migrationBuilder.AddForeignKey(
                name: "FK_Section_Courses_CoursesCoursesId",
                table: "Section",
                column: "CoursesCoursesId",
                principalTable: "Courses",
                principalColumn: "CoursesId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Section_Faculty_FacultyFacultyId",
                table: "Section",
                column: "FacultyFacultyId",
                principalTable: "Faculty",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Section_Location_LocationLocationId",
                table: "Section",
                column: "LocationLocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
