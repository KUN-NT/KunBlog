using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	/// <summary>
	/// 字典表
	/// </summary>
	public class SysDictionary
	{
		//CREATE_BY
		[MaxLength(36)]
		public String CREATE_BY {get;set;}

		//CREATE_DATE
		public DateTime? CREATE_DATE {get;set;}

		//字典编号
		[Key]
		[MaxLength(36)]
		public String DIC_ID {get;set;}

		//字典名称
		[MaxLength(50)]
		public String DIC_NAME {get;set;}

		//字典序号
		[MaxLength(3)]
		public String DIC_SEQ {get;set;}

		//字典类型
		[MaxLength(50)]
		public String DIC_TYPE {get;set;}

		//UPDATE_BY
		[MaxLength(36)]
		public String UPDATE_BY {get;set;}

		//UPDATE_DATE
		public DateTime? UPDATE_DATE {get;set;}

	}
}

