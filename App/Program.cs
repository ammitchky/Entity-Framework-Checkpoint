using System;
using System.Linq;
using App.Data;
using Microsoft.EntityFrameworkCore;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                Console.WriteLine("Display list of all students\n");
                db.Students.ToList().ForEach(
                    student => Console.WriteLine($"Id: {student.Id} - Name: {student.FirstName} {student.LastName} - Age: {student.Age}")
                );

                Console.WriteLine("\nDisplay list of all grades for Samiel\n");
                var student = db.Students.Include(s => s.Grades).Where(student => student.FirstName == "Samiel").FirstOrDefault();
                student.Grades.ToList().ForEach(
                    grade => Console.WriteLine($"Course: {grade.CourseName} - Grade: {grade.CourseGrade}")
                );

                Console.WriteLine("\nDisplay the average grade across all courses for Samiel\n");
                var AvgGrade = student.Grades.Select(g => g.CourseGrade).Average();
                Console.WriteLine($"Samiel has an average grade of {AvgGrade} across all courses.");

                Console.WriteLine("\nFind and display the student with the highest average grade");
                var highAvgStudent = db.Grades
                .GroupBy(i => i.StudentId)
                .Select(g => new {
                    StudentId = g.Key, 
                    Average = g.Average(a => a.CourseGrade)})
                .Join(
                    db.Students,
                    g => g.StudentId,
                    student => student.Id,
                    (g, student) => new {
                        Id = student.Id,
                        FName = student.FirstName,
                        LName = student.LastName,
                        AvgGrade = g.Average
                    }
                ).OrderByDescending(o => o.AvgGrade).FirstOrDefault();
                Console.WriteLine($"{highAvgStudent.FName} {highAvgStudent.LName} - Average Grade: {highAvgStudent.AvgGrade}");

                
            }
        }
    }
}