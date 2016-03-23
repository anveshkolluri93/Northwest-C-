using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Team01_Project01.Models;

namespace Team01Project01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Team01_Project01.Models.Courses", b =>
                {
                    b.Property<int>("CoursesId");

                    b.Property<string>("courseName");

                    b.Property<int>("credits");

                    b.Property<string>("duration");

                    b.HasKey("CoursesId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyId");

                    b.Property<string>("FirstMidName");

                    b.Property<string>("LastName");

                    b.HasKey("FacultyId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Location", b =>
                {
                    b.Property<int>("LocationId");

                    b.Property<string>("buildingId");

                    b.Property<string>("roomNumber");

                    b.HasKey("LocationId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId");

                    b.Property<int>("CoursesId");

                    b.Property<int>("FacultyId");

                    b.Property<int>("LocationId");

                    b.Property<DateTime>("date");

                    b.HasKey("ScheduleId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Section", b =>
                {
                    b.Property<int>("SectionId");

                    b.Property<int>("CoursesId");

                    b.Property<int>("FacultyId");

                    b.Property<int>("capacity");

                    b.HasKey("SectionId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Students", b =>
                {
                    b.Property<int>("StudentsId");

                    b.Property<int>("CoursesId");

                    b.Property<string>("FirstMidName");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("StudentsId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Schedule", b =>
                {
                    b.HasOne("Team01_Project01.Models.Courses")
                        .WithMany()
                        .HasForeignKey("CoursesId");

                    b.HasOne("Team01_Project01.Models.Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId");

                    b.HasOne("Team01_Project01.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Section", b =>
                {
                    b.HasOne("Team01_Project01.Models.Courses")
                        .WithMany()
                        .HasForeignKey("CoursesId");

                    b.HasOne("Team01_Project01.Models.Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Students", b =>
                {
                    b.HasOne("Team01_Project01.Models.Courses")
                        .WithMany()
                        .HasForeignKey("CoursesId");
                });
        }
    }
}
