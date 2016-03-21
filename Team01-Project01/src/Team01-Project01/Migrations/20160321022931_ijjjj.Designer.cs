using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Team01_Project01.Models;

namespace Team01Project01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20160321022931_ijjjj")]
    partial class ijjjj
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Team01_Project01.Models.Courses", b =>
                {
                    b.Property<int>("CoursesId");

                    b.Property<string>("courseName");

                    b.Property<double>("credits");

                    b.Property<string>("duration");

                    b.HasKey("CoursesId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstMidName");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("FacultyId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("buildingId")
                        .IsRequired();

                    b.Property<string>("roomNumber");

                    b.HasKey("LocationId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CoursesId");

                    b.Property<int?>("FacultyFacultyId");

                    b.Property<string>("FacultyId");

                    b.Property<int>("LocationId");

                    b.Property<int>("SectionId");

                    b.Property<DateTime>("date");

                    b.Property<string>("time");

                    b.HasKey("ScheduleId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Section", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CoursesCoursesId");

                    b.Property<string>("CoursesID");

                    b.Property<int?>("FacultyFacultyId");

                    b.Property<string>("FacultyId");

                    b.Property<string>("LocationId");

                    b.Property<int?>("LocationLocationId");

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

                    b.Property<int>("ScheduleId");

                    b.HasKey("StudentsId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Schedule", b =>
                {
                    b.HasOne("Team01_Project01.Models.Courses")
                        .WithMany()
                        .HasForeignKey("CoursesId");

                    b.HasOne("Team01_Project01.Models.Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyFacultyId");

                    b.HasOne("Team01_Project01.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("Team01_Project01.Models.Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Section", b =>
                {
                    b.HasOne("Team01_Project01.Models.Courses")
                        .WithMany()
                        .HasForeignKey("CoursesCoursesId");

                    b.HasOne("Team01_Project01.Models.Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyFacultyId");

                    b.HasOne("Team01_Project01.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationLocationId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Students", b =>
                {
                    b.HasOne("Team01_Project01.Models.Courses")
                        .WithMany()
                        .HasForeignKey("CoursesId");

                    b.HasOne("Team01_Project01.Models.Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId");
                });
        }
    }
}
