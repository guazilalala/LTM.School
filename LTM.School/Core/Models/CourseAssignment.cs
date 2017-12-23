using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
	/// <summary>
	/// 课程分配
	/// </summary>
	public class CourseAssignment
    {
		public int InstructorId { get; set; }
		public int CourseId { get; set; }
		public Instructor Instructor { get; set; }
		public Course Course { get; set; }
	}
}
