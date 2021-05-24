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
                // var testing = db.Students.Include(s => s.Grades).GroupBy(g => g.Id)
                // .Select(groups => new {Id = groups.Key, AverageGrade = groups.Average(a => a.Grades.)});

                // var testing2 = db.Students.Join(
                //     db.Grades,
                //     student => student.Id,
                //     grade => grade.StudentId,
                //     (student, grade) => new
                //     {
                //         Id = student.Id,
                //         FName = student.FirstName,
                //         LName = student.LastName,
                //         Course = grade.CourseName,
                //         Grade = grade.CourseGrade
                //     }
                // ).GroupBy(group => group.Id).Select(g => new {
                //     Id = g.Key,
                //     Name = g
                //     Average = g.Average(a => a.Grade)
                // });

                // foreach (var obj in testing2){
                //     Console.WriteLine(obj);
                // }

                // var HighestAverageId = db.Grades
                // .GroupBy(i => i.StudentId)
                // .Select(g => new {
                //     StudentId = g.Key, 
                //     Average = g.Average(a => a.CourseGrade)}
                // ).OrderByDescending(g => g.Average).FirstOrDefault();
                // Console.WriteLine(HighestAverageId);
            }
        }
    }
}