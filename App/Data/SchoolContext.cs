using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class SchoolContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        => options.UseSqlite("Data Source=school.db");

        // protected override void OnModelCreating(ModelBuilder mb) {
        //     mb.Entity<Student>().HasData()
        // }
    }
}