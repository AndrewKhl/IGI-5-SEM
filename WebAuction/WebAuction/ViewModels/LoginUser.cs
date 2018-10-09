using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebAuction.ViewModels
{
	public class LoginUser
	{
		[Required(ErrorMessage = "Email is required")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is empty")]
		[DataType(DataType.Password)]
		public string Password { get; set; }


	}
}

