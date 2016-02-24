using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Team01_Project01.Models;

namespace Team01Project01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20160224034325_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Team01_Project01.Models.Courses", b =>
                {
                    b.Property<int>("courseId");

                    b.Property<string>("courseName");

                    b.Property<double>("credits");

                    b.Property<string>("duration");

                    b.HasKey("courseId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Faculty", b =>
                {
                    b.Property<int>("facultyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstMidName");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("facultyId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Location", b =>
                {
                    b.Property<int>("locationId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Longitude");

                    b.Property<string>("buildingId")
                        .IsRequired();

                    b.Property<string>("roomNumber");

                    b.HasKey("locationId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleNumber");

                    b.Property<int>("courseId");

                    b.Property<DateTime>("date");

                    b.Property<string>("facultyId")
                        .IsRequired();

                    b.Property<int>("locationId");

                    b.Property<int>("sectionId");

                    b.Property<string>("studentId");

                    b.Property<string>("time");

                    b.HasKey("ScheduleNumber");
                });

            modelBuilder.Entity("Team01_Project01.Models.Section", b =>
                {
                    b.Property<int>("sectionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("capacity");

                    b.Property<string>("courseId");

                    b.Property<string>("facultyId");

                    b.Property<string>("locationId")
                        .IsRequired();

                    b.HasKey("sectionId");
                });

            modelBuilder.Entity("Team01_Project01.Models.Students", b =>
                {
                    b.Property<int>("studentId");

                    b.Property<string>("CRN");

                    b.Property<string>("CourseId");

                    b.Property<string>("FirstMidName");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("studentId");
                });
        }
    }
}
