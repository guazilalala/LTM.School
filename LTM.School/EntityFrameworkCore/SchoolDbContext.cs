using LTM.School.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.EntityFrameworkCore
{
    public class SchoolDbContext:DbContext
    {
		public SchoolDbContext(DbContextOptions<SchoolDbContext> options):base(options)
		{

		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Instructor> Instructors { get; set; }
		public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
		public DbSet<CourseAssignment> CourseAssignments { get; set; }
		public DbSet<Department> Departments { get; set; }
		//public DbSet<Person> Persons { get; set; }






		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>().ToTable("Students");
			modelBuilder.Entity<Instructor>().ToTable("Instructors");
			modelBuilder.Entity<Course>().Property(a=>a.CourseId).ValueGeneratedNever();
			modelBuilder.Entity<CourseAssignment>().HasKey(a => new { a.CourseId, a.InstructorId });
		}
	}
}
