using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class SchoolContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            options.UseSqlite("Data Source=school.db");
            options.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder mb) {

            var samiel = new Student { Id = 1, FirstName = "Samiel", LastName = "Jacobs", Age = 13, Classification = Student.SchoolYear.Freshman};
            var sarah = new Student { Id = 2, FirstName = "Sarah", LastName = "Vega", Age = 16, Classification = Student.SchoolYear.Junior};
            var mark = new Student { Id = 3, FirstName = "Mark", LastName = "Plier", Age = 18, Classification = Student.SchoolYear.Senior};
            var audrey = new Student { Id = 4, FirstName = "Audrey", LastName = "White", Age = 14, Classification = Student.SchoolYear.Sophomore};
            var andrew = new Student {Id = 5, FirstName = "Andrew", LastName = "Neuton", Age = 14, Classification = Student.SchoolYear.Freshman};
            var thomas = new Student {Id = 6, FirstName = "Thomas", LastName = "Reetin", Age = 17, Classification = Student.SchoolYear.Sophomore};

            mb.Entity<Student>().HasData(
                samiel,
                sarah,
                mark,
                audrey,
                andrew,
                thomas
            );

            mb.Entity<Grade>().HasData(
                new Grade { Id = 1, StudentId = 1, CourseName = "Geometry 102", CourseGrade = 87.7f },
                new Grade { Id = 2, StudentId = 1, CourseName = "Art 201", CourseGrade = 98.7f },
                new Grade { Id = 3, StudentId = 1, CourseName = "Chemistry 301", CourseGrade = 100.0f },
                new Grade { Id = 4, StudentId = 1, CourseName = "English 102", CourseGrade = 82.6f },
                new Grade { Id = 5, StudentId = 2, CourseName = "Chemistry 301", CourseGrade = 99.2f },
                new Grade { Id = 6, StudentId = 2, CourseName = "Art 201", CourseGrade = 70.2f },
                new Grade { Id = 7, StudentId = 3, CourseName = "English 102", CourseGrade = 93.5f },
                new Grade { Id = 8, StudentId = 3, CourseName = "Art 301", CourseGrade = 100.0f },
                new Grade { Id = 9, StudentId = 4, CourseName = "Art 301", CourseGrade = 65.0f },
                new Grade { Id = 10, StudentId = 6, CourseName = "Precalculus 301", CourseGrade = 88.8f}
            );
        }
    }
}