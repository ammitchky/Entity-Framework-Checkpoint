// <auto-generated />
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("App.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("CourseGrade")
                        .HasColumnType("REAL");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseGrade = 87.7f,
                            CourseName = "Geometry 102",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseGrade = 98.7f,
                            CourseName = "Art 201",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseGrade = 100f,
                            CourseName = "Chemistry 301",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 4,
                            CourseGrade = 82.6f,
                            CourseName = "English 102",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 5,
                            CourseGrade = 99.2f,
                            CourseName = "Chemistry 301",
                            StudentId = 2
                        },
                        new
                        {
                            Id = 6,
                            CourseGrade = 70.2f,
                            CourseName = "Art 201",
                            StudentId = 2
                        },
                        new
                        {
                            Id = 7,
                            CourseGrade = 93.5f,
                            CourseName = "English 102",
                            StudentId = 3
                        },
                        new
                        {
                            Id = 8,
                            CourseGrade = 100f,
                            CourseName = "Art 301",
                            StudentId = 3
                        },
                        new
                        {
                            Id = 9,
                            CourseGrade = 65f,
                            CourseName = "Art 301",
                            StudentId = 4
                        },
                        new
                        {
                            Id = 10,
                            CourseGrade = 88.8f,
                            CourseName = "Precalculus 301",
                            StudentId = 6
                        });
                });

            modelBuilder.Entity("App.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Classification")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 13,
                            Classification = 0,
                            FirstName = "Samiel",
                            LastName = "Jacobs"
                        },
                        new
                        {
                            Id = 2,
                            Age = 16,
                            Classification = 2,
                            FirstName = "Sarah",
                            LastName = "Vega"
                        },
                        new
                        {
                            Id = 3,
                            Age = 18,
                            Classification = 3,
                            FirstName = "Mark",
                            LastName = "Plier"
                        },
                        new
                        {
                            Id = 4,
                            Age = 14,
                            Classification = 1,
                            FirstName = "Audrey",
                            LastName = "White"
                        },
                        new
                        {
                            Id = 5,
                            Age = 14,
                            Classification = 0,
                            FirstName = "Andrew",
                            LastName = "Neuton"
                        },
                        new
                        {
                            Id = 6,
                            Age = 17,
                            Classification = 1,
                            FirstName = "Thomas",
                            LastName = "Reetin"
                        });
                });

            modelBuilder.Entity("App.Models.Grade", b =>
                {
                    b.HasOne("App.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("App.Models.Student", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
