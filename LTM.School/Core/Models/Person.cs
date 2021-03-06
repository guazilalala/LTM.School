﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
	/// <summary>
	/// 人
	/// </summary>
    public class Person
    {
		public int Id { get; set; }

		[Required]
		[MaxLength(30,ErrorMessage ="姓名长度不能超过30个字符。")]
		[DisplayName("姓名")]
		public string RealName { get; set; }
    }
}
