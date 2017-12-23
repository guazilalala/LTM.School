﻿using LTM.School.Application.EnumsType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
	/// <summary>
	/// 注册信息
	/// </summary>
    public class Enrollment
    {
		public int EnrollmentId { get; set; }
		[DisplayFormat(NullDisplayText = "暂无成绩")]
		public CourseGrade? Grade { get; set; }
		public int StudentId { get; set; }
		public int CourseId { get; set; }
		public Student Student { get; set; }
		public Course Course { get; set; }
    }
}
