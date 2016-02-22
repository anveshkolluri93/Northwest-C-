using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace DataAnveshkumarKolluri.Migrations
{
    public partial class InitialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Movie_Location_LocationID", table: "Movie");
            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Location_LocationID",
                table: "Movie",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Movie_Location_LocationID", table: "Movie");
            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Location_LocationID",
                table: "Movie",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
