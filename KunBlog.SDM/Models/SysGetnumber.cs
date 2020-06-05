using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	/// <summary>
	/// È¡ºÅ±í
	/// </summary>
	public class SysGetnumber
	{
		//CREATE_BY
		[MaxLength(36)]
		public String CREATE_BY {get;set;}

		//CREATE_DATE
		public DateTime? CREATE_DATE {get;set;}

		//CURRENT_NUM
		[MaxLength()]
		public String CURRENT_NUM {get;set;}

		//NUM_FORMAT
		[MaxLength(20)]
		public String NUM_FORMAT {get;set;}

		//NUM_HEAD
		[MaxLength(5)]
		public String NUM_HEAD {get;set;}

		//NUM_ID
		[Key]
		[MaxLength(36)]
		public String NUM_ID {get;set;}

		//NUM_LENGTH
		[MaxLength()]
		public String NUM_LENGTH {get;set;}

		//UPDATE_BY
		[MaxLength(36)]
		public String UPDATE_BY {get;set;}

		//UPDATE_DATE
		public DateTime? UPDATE_DATE {get;set;}

	}
}

