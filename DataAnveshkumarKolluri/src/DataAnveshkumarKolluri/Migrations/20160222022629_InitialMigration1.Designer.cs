using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using DataAnveshkumarKolluri.Models;

namespace DataAnveshkumarKolluri.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20160222022629_InitialMigration1")]
    partial class InitialMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAnveshkumarKolluri.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Place");

                    b.Property<string>("State");

                    b.Property<string>("StateAbbreviation");

                    b.Property<string>("ZipCode");

                    b.HasKey("LocationID");
                });

            modelBuilder.Entity("DataAnveshkumarKolluri.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActorName");

                    b.Property<string>("ActressName");

                    b.Property<int>("LocationID");

                    b.Property<string>("MovieGenre");

                    b.Property<string>("MovieReviews");

                    b.Property<string>("MovieTitle");

                    b.HasKey("MovieID");
                });

            modelBuilder.Entity("DataAnveshkumarKolluri.Models.Movie", b =>
                {
                    b.HasOne("DataAnveshkumarKolluri.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationID");
                });
        }
    }
}
