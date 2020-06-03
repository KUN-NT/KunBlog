using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunBlog.SDM.Models
{
	public class SysPurview
	{
		//PURVIEW_ID
		[Key]
		[MaxLength(36)]
		public String PURVIEW_ID {get;set;}

		//PURVIEW_NAME
		[MaxLength(50)]
		public String PURVIEW_NAME {get;set;}

	}
}

